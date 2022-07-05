using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.InvoiceControls
{

    public partial class InvoiceControl : UserControl
    {
        Models.InvoicesItemsRepo InvoicesItemsRepos { get; set; }
        double TotalPrice { get; set; }
        double CashPaid { get; set; }
        double CashReturn { get; set; }
        Models.DBEntities db = new Models.DBEntities();
        public InvoiceControl()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            try
            {
                TotalPrice = 0;
                InvoicesItemsRepos = new Models.InvoicesItemsRepo
                {
                    VendorID = "",
                    DateTime = "",
                    InvoicesLists = new List<Models.InvoicesList>(),
                    SameID = Constants.GetRandomString(10),
                    UserID = Constants.UserID
                };
                productsCombo.DataSource = db.Products.Select(X => X.Name).OrderBy(X => X).ToArray();//.ToList().ForEach(X => { Application.DoEvents(); productsCombo.Items.Add(X); });
                vendorNameCombo.DataSource = db.Vendors.Select(X => X.Name).OrderBy(X => X).ToArray();//.ToList().ForEach(X => { Application.DoEvents(); vendorNameCombo.Items.Add(X); });
                bunifuCustomDataGrid1.Rows.Clear();
                tPriceTxt.Text = "0";
                cashPaidTxt.Text = "0";
                cashReturnTxt.Text = "0";
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsCombo.SelectedIndex < 0 || productsCombo.Text == "") { Alert.Show("Kindly Select Any Product", Alert.alertType.warning); return; }
                if (iQuantityTxt.Text == "") iQuantityTxt.Text = "1";
                if (iPurchaseTxt.Text == "") { Alert.Show("Purchase Price Cannot Be Empty", Alert.alertType.warning); return; }
                try { var d = double.Parse(iQuantityTxt.Text); } catch { Alert.Show("Quantity can Only Be Numberic", Alert.alertType.warning); return; }
                try { var d = double.Parse(iPurchaseTxt.Text); } catch { Alert.Show("Purchase Price can Only Be Numeric", Alert.alertType.warning); return; }

                if (InvoicesItemsRepos.InvoicesLists.Exists(X => X.ProductID == db.Products.FirstOrDefault(C => C.Name == productsCombo.Text).ID))
                {
                    InvoicesItemsRepos.InvoicesLists.Find(X => X.ProductID == db.Products.FirstOrDefault(C => C.Name == productsCombo.Text).ID).Quantity += float.Parse(iQuantityTxt.Text);
                    InvoicesItemsRepos.InvoicesLists.Find(X => X.ProductID == db.Products.FirstOrDefault(C => C.Name == productsCombo.Text).ID).PurchasePricePerQuantity = double.Parse(iPurchaseTxt.Text);
                }
                else
                {
                    InvoicesItemsRepos.InvoicesLists.Add(new Models.InvoicesList
                    {
                        ProductID = db.Products.FirstOrDefault(C => C.Name == productsCombo.Text).ID,
                        PurchasePricePerQuantity = double.Parse(iPurchaseTxt.Text),
                        Quantity = float.Parse(iQuantityTxt.Text)
                    });
                }
                fillGrid();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    InvoicesItemsRepos.InvoicesLists.Remove(InvoicesItemsRepos.InvoicesLists.Find(X => X.ProductID == int.Parse(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    fillGrid();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        void fillGrid()
        {
            try
            {
                TotalPrice = 0;
                bunifuCustomDataGrid1.Rows.Clear();
                int i = 1;
                InvoicesItemsRepos.InvoicesLists.ForEach(X =>
                {
                    bunifuCustomDataGrid1.Rows.Add(X.ProductID, i, db.Products.FirstOrDefault(C => C.ID == X.ProductID).Name, X.Quantity, X.PurchasePricePerQuantity, X.UnitTotal, "X");
                    TotalPrice += X.UnitTotal; i++;
                });
                tPriceTxt.Text = TotalPrice.ToString();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void tPriceTxt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                try { var d = double.Parse(cashPaidTxt.Text); } catch { Alert.Show("Cash Paid Can Only Be Numeric", Alert.alertType.warning); return; }
                CashPaid = double.Parse(cashPaidTxt.Text);
                CashReturn = CashPaid - TotalPrice;
                cashReturnTxt.Text = CashReturn.ToString();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void cashPaidTxt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                try { var d = double.Parse(cashPaidTxt.Text); } catch { Alert.Show("Cash Paid Can Only Be Numeric", Alert.alertType.warning); return; }
                CashPaid = double.Parse(cashPaidTxt.Text);
                CashReturn = CashPaid - TotalPrice;
                cashReturnTxt.Text = CashReturn.ToString();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void iSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (vendorNameCombo.SelectedIndex < 0)
                {
                    Alert.Show("Kindly Select Any Vendor", Alert.alertType.warning); return;
                }
                if (InvoicesItemsRepos.InvoicesLists.Count == 0)
                {
                    Alert.Show("Kindly Add Some Products in Entry", Alert.alertType.warning); return;
                }
                if (CashPaid < TotalPrice)
                {
                    if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Make Debit Of RS:" + (TotalPrice - CashPaid).ToString() + " With " + vendorNameCombo.Text + "") == DialogResult.Yes)
                    {
                        using (Models.DBEntities db = new Models.DBEntities())
                        {
                            List<ItemsListRpt> ItemsListRpts = new List<ItemsListRpt>();
                            int a = 1;
                            foreach (var i in InvoicesItemsRepos.InvoicesLists)
                            {
                                ItemsListRpts.Add(new ItemsListRpt
                                {
                                    ID = a.ToString(),
                                    ProductName = db.Products.FirstOrDefault(X => X.ID == i.ProductID).Name.ToString(),
                                    Quantity = i.Quantity.ToString(),
                                    UnitPrice = i.PurchasePricePerQuantity.ToString(),
                                    UnitTotal = i.UnitTotal.ToString()
                                });
                                db.Invoices.Add(new Models.Invoice
                                {
                                    Datetime = DateTime.Now,
                                    ProductID = (int)i.ProductID,
                                    PurchasePriceUnit = i.PurchasePricePerQuantity,
                                    Quantity = i.Quantity,
                                    oneTimeID = InvoicesItemsRepos.SameID,
                                    UserID = InvoicesItemsRepos.UserID,
                                    VendorID = db.Vendors.FirstOrDefault(X => X.Name == vendorNameCombo.Text).ID
                                });
                            }
                            db.SaveChanges();
                            db.VendorAccounts.Add(new Models.VendorAccount
                            {
                                Amount = TotalPrice - CashPaid,
                                DateTime = DateTime.Now,
                                InvoiceID = InvoicesItemsRepos.SameID,
                                TransactionType = Constants.TransactionType.credit,
                                UserID = InvoicesItemsRepos.UserID,
                                VendorID = DBCache.Vendors.Find(X => X.Name == vendorNameCombo.Text).ID
                            });
                            db.SaveChanges();
                            Alert.Show("Invoice Saved with Debit Amount " + (TotalPrice - CashPaid).ToString(), Alert.alertType.success);
                            SInvoiceRpt sir = new SInvoiceRpt
                            {
                                CashPaid = cashPaidTxt.Text,
                                CashRemaining = cashReturnTxt.Text,
                                Date = DateTime.Now.ToShortDateString(),
                                Time = DateTime.Now.ToShortTimeString(),
                                InvoiceID = InvoicesItemsRepos.SameID,
                                VendorName = vendorNameCombo.Text,
                                TotalPayment = tPriceTxt.Text
                            };

                            object[] obj = new object[3];
                            obj[0] = Constants.ReportTypes.InvoiceSlip;
                            obj[1] = ItemsListRpts;
                            obj[2] = sir;
                            new Reports.Report(obj).Show();
                            //new Reports.InvoiceReportForm(sir, ItemsListRpts).Show();
                            Alert.Show("Bill Printed", Alert.alertType.success);

                        }

                    }
                }
                else if (CashPaid >= TotalPrice)
                {
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        List<App_Code.ItemsListRpt> ItemsListRpts = new List<App_Code.ItemsListRpt>();
                        int a = 1;
                        foreach (var i in InvoicesItemsRepos.InvoicesLists)
                        {
                            ItemsListRpts.Add(new ItemsListRpt
                            {
                                ID = a.ToString(),
                                ProductName = db.Products.FirstOrDefault(X => X.ID == i.ProductID).Name.ToString(),
                                Quantity = i.Quantity.ToString(),
                                UnitPrice = i.PurchasePricePerQuantity.ToString(),
                                UnitTotal = i.UnitTotal.ToString()
                            });
                            db.Invoices.Add(new Models.Invoice
                            {
                                Datetime = DateTime.Now,
                                ProductID = (int)i.ProductID,
                                PurchasePriceUnit = i.PurchasePricePerQuantity,
                                Quantity = i.Quantity,
                                oneTimeID = InvoicesItemsRepos.SameID,
                                UserID = InvoicesItemsRepos.UserID,
                                VendorID = DBCache.Vendors.Find(X => X.Name == vendorNameCombo.Text).ID
                            });
                        }
                        db.SaveChanges();
                        Alert.Show("Invoice Saved", Alert.alertType.success);
                        SInvoiceRpt sir = new SInvoiceRpt
                        {
                            CashPaid = cashPaidTxt.Text??"0",
                            CashRemaining = cashReturnTxt.Text??"0",
                            Date = DateTime.Now.ToShortDateString(),
                            Time = DateTime.Now.ToShortTimeString(),
                            InvoiceID = InvoicesItemsRepos.SameID,
                            VendorName = vendorNameCombo.Text ?? "error Vendor Name",
                            TotalPayment = tPriceTxt.Text ?? "0"
                        };
                        object[] obj = new object[3];
                        obj[0] = Constants.ReportTypes.InvoiceSlip;
                        obj[1] = ItemsListRpts;
                        obj[2] = sir;
                        new Reports.Report(obj).Show();
                        Alert.Show("Bill Printed", Alert.alertType.success);
                    }

                }
                Refresher();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void iPurchaseTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }
    }
}
