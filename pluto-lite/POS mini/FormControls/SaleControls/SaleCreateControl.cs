using POS_mini.App_Code;
using POS_mini.CustomControls;
using POS_mini.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class SaleCreateControl : UserControl
    {
        Models.DBEntities db = new Models.DBEntities();
        //private double tAmountTxt.Text.ToDouble() { get; set; }
        //private double tCashReceivedTxt.Text.ToDouble() { get; set; }
        //private double tNetBillTxt.Text.ToDouble() { get; set; }
        //private double tDiscountTxt.Text.ToDouble() { get; set; }
        //private double tCashReturnTxt.Text.ToDouble() { get; set; }

        List<Models.SaleItemsRepo> saleItemsRepos = new List<Models.SaleItemsRepo>();
        //Report Models
        SaleDetailRpt SDR = new SaleDetailRpt();
        List<ItemsListRpt> ILR = new List<ItemsListRpt>();

        public SaleCreateControl()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            try
            {
                saleItemsRepos = new List<Models.SaleItemsRepo>();
                saleGrid.Rows.Clear();
                customersCombo.DataSource = db.Customers.Select(X => X.Name).ToArray();//.ForEach(X => { Application.DoEvents(); customersCombo.Items.Add(X); });
                //tAmountTxt.Text.ToDouble() = 0; tCashReturnTxt.Text.ToDouble() = 0; tCashReturnTxt.Text.ToDouble() = 0; tDiscountTxt.Text.ToDouble() = 0; tNetBillTxt.Text.ToDouble() = 0;
                saleGrid.Rows.Clear();
                //tAmountTxt.Text = "0"; tDiscountTxt.Text = "0"; tNetBillTxt.Text = "0"; tCashReceivedTxt.Text = "0";
                dateTimePicker1.Value = DateTime.Now;
                barcodeTxt.Text = "";
                avgDiscountTxt.Text = "";
                prodSearchTxt.Text = "";
                tCashReceivedTxt.Text = "";
                tNetBillTxt.Text = "";
                tCashReturnTxt.Text = "";
                CreatButton("");
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }
        //Search Box
        private void bunifuMetroTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { CreatButton(prodSearchTxt.Text); }
                catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
            }


        }

        public void CreatButton(string text)
        {
            try
            {
                var searchTxt = text.ToLower();
                if (searchTxt != "")
                {
                    var products = db.Products.Where(X => X.Name.ToLower().Contains(searchTxt)).OrderBy(X => X.Name).ToList();
                    productListGrid.Rows.Clear();
                    products.ForEach(X =>
                    {
                        var stock = 0.0;
                        Application.DoEvents();
                        db.Invoices.Where(C => C.ProductID == X.ID).ToList().ForEach(C => { stock += C.Quantity; });
                        db.SaleItems.Where(C => C.ProductID == X.ID).ToList().ForEach(C => { stock -= C.Quantity; });

                        productListGrid.Rows.Add(X.Name + "(" + stock.ToString() + ")");


                    });
                }
                else
                {
                    productListGrid.Rows.Clear();
                    var products = db.Products.OrderBy(X => X.Name).ToList();
                    productListGrid.Rows.Clear();
                    products.ForEach(X =>
                    {
                        var stock = 0.0;
                        Application.DoEvents();
                        db.Invoices.Where(C => C.ProductID == X.ID).ToList().ForEach(C => { stock += C.Quantity; });
                        db.SaleItems.Where(C => C.ProductID == X.ID).ToList().ForEach(C => { stock -= C.Quantity; });
                        //
                        productListGrid.Rows.Add(X.Name + "(" + stock.ToString() + ")");
                    });
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void barcodeTxt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (barcodeTxt.Text != "")
                {
                    var product = new Models.Product();
                    product = db.Products.FirstOrDefault(X => X.Barcode == barcodeTxt.Text);
                    if (product != null)
                    {
                        AddProduct(product.ID);
                    }
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void AddProduct(int productID)
        {
            try
            {
                var Product = db.Products.FirstOrDefault(X => X.ID == productID);
                double stock = 0;
                try { stock += db.Invoices.Where(X => X.ProductID == Product.ID).Sum(X => X.Quantity); } catch { }
                try { stock -= db.SaleItems.Where(X => X.ProductID == Product.ID).Sum(X => X.Quantity); } catch { }
                if (stock < 1) { if (MessageBox.Show("Not In Stock", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { }; return; }
                if (saleItemsRepos.Exists(X => X.ProductID == productID))
                {
                    saleItemsRepos.Find(X => X.ProductID == productID).Quantity++;
                    WinAPI.Beep(800, 200);
                }
                else
                {
                    saleItemsRepos.Add(new Models.SaleItemsRepo
                    {
                        DiscountPKR = 0,
                        Quantity = 1,
                        ProductID = Product.ID,
                        SalePricePerQuantity = Product.SalePrice
                    });
                    WinAPI.Beep(800, 200);
                }
                fillsalesGrid();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void fillsalesGrid()
        {
            try
            {


                saleGrid.Rows.Clear();
                int i = 1; //tDiscountTxt.Text.ToDouble() = 0; tAmountTxt.Text.ToDouble() = 0; tCashReceivedTxt.Text.ToDouble() = 0; tCashReturnTxt.Text.ToDouble() = 0; tNetBillTxt.Text.ToDouble() = 0;
                saleItemsRepos.ForEach(X =>
                {
                    saleGrid.Rows.Add(X.ProductID, i, db.Products.FirstOrDefault(C => C.ID == X.ProductID).Name, X.Quantity, X.SalePricePerQuantity, X.DiscountPKR, X.UntTotalWithDiscount, "X");
                    i++;
                    //tAmountTxt.Text.ToDouble() += X.UnitTotal; tDiscountTxt.Text.ToDouble() += (X.UnitTotal - X.UntTotalWithDiscount); tNetBillTxt.Text.ToDouble() += X.UntTotalWithDiscount;
                });
                //tAmountTxt.Text = tAmountTxt.Text.ToDouble().ToString(); tDiscountTxt.Text = tDiscountTxt.Text.ToDouble().ToString(); tNetBillTxt.Text = tNetBillTxt.Text.ToDouble().ToString();
                barcodeTxt.Text = "";
                Calculations();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void saleGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3) //quantitychange
                {
                    try { var a = double.Parse(saleGrid.Rows[e.RowIndex].Cells[3].Value.ToString()); } catch { }// { Alert.Show("Kindly Enter Numeric Value", Alert.alertType.warning); return; }
                    saleItemsRepos.Find(X => X.ProductID == int.Parse(saleGrid.Rows[e.RowIndex].Cells[0].Value.ToString())).Quantity = Convert.ToDouble(saleGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else if (e.ColumnIndex == 4) //sale price
                {
                    try { var a = double.Parse(saleGrid.Rows[e.RowIndex].Cells[4].Value.ToString()); } catch { }//
                    //{ Alert.Show("Kindly Enter Numeric Value", Alert.alertType.warning); return; }
                    saleItemsRepos.Find(X => X.ProductID == int.Parse(saleGrid.Rows[e.RowIndex].Cells[0].Value.ToString())).SalePricePerQuantity = Convert.ToDouble(saleGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
                else if (e.ColumnIndex == 5) //discount
                {
                    try { var a = double.Parse(saleGrid.Rows[e.RowIndex].Cells[5].Value.ToString()); } catch { }// { Alert.Show("Kindly Enter Numeric Value", Alert.alertType.warning); return; }
                    saleItemsRepos.Find(X => X.ProductID == int.Parse(saleGrid.Rows[e.RowIndex].Cells[0].Value.ToString())).DiscountPKR = Convert.ToDouble(saleGrid.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
                fillsalesGrid();
            }
            catch { }
        }

        private void tCashReceivedTxt_OnValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }


        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            try
            {
                switch (keys)
                {
                    case Keys.Alt | Keys.X:
                        {

                            barcodeTxt.Focus();
                            barcodeTxt.Text = "";
                            return true;
                        }
                    case Keys.Alt | Keys.S:
                        {
                            prodSearchTxt.Focus();
                            prodSearchTxt.Text = "";
                            return true;
                        }

                    case Keys.Alt | Keys.C:
                        {
                            saleGrid.Focus();
                            return true;
                        }
                    case Keys.Alt | Keys.D:
                        {
                            productListGrid.Focus();
                            return true;
                        }

                    case Keys.Alt | Keys.P:
                        {
                            printAndSave();
                            return true;
                        }

                }
                return base.ProcessCmdKey(ref message, keys);
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); return false; }
        }

        void Calculations()
        {
            double totalAmount = 0,
                totalProductDiscount = 0;
            saleItemsRepos.ForEach(X =>
            {
                totalAmount += (X.SalePricePerQuantity * X.Quantity);
                totalProductDiscount += X.DiscountPKR;
            });

            tAmountTxt.Text = totalAmount.ToString();
            tDiscountTxt.Text = totalProductDiscount.ToString();
            tNetBillTxt.Text = (totalAmount - totalProductDiscount - avgDiscountTxt.Text.ToDouble()).ToString();
            if (tCashReceivedTxt.Text.ToDouble() > tNetBillTxt.Text.ToDouble())
                tCashReturnTxt.Text = ((tNetBillTxt.Text.ToDouble() - tCashReceivedTxt.Text.ToDouble()) * -1).ToString();
            else
                tCashReturnTxt.Text = "0";

        }

        private void SaleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    if (saleItemsRepos.Exists(X => X.ProductID == int.Parse(saleGrid.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        saleItemsRepos.RemoveAll(X => X.ProductID == int.Parse(saleGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    }
                    fillsalesGrid();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void saleGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    e.Handled = true;
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    e.Handled = true;
            }
            catch (Exception t)
            {
                Alert.Show(t.Message, Alert.alertType.warning);
            }
        }

        private void productListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    var pName = productListGrid.Rows[e.RowIndex].Cells[0].Value.ToString().Split('(')[0];
                    if (string.IsNullOrEmpty(pName)) return;
                    var product = db.Products.FirstOrDefault(X => X.Name == pName);
                    if (product == null) return;
                    AddProduct(product.ID);
                    saleGrid.Focus();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void printAndSaveBtn_Click_1(object sender, EventArgs e)
        {
            //
            printAndSave();
        }




        private void printAndSave()
        {
            bool continueSale = true;
            bool addRemainingInCustomerAccount = false;
            try
            {
                if (saleItemsRepos.Count < 1) { Alert.Show("Kindly Add Any Product", Alert.alertType.warning); return; }
                Models.Sale SaleMajor = new Models.Sale();
                if (avgDiscountTxt.Text == "") avgDiscountTxt.Text = "0";
                if (!string.IsNullOrEmpty(avgDiscountTxt.Text) || avgDiscountTxt.Text != "0")
                {
                    var avgDiscount = double.Parse(avgDiscountTxt.Text ?? "0") / saleItemsRepos.Count;
                    saleItemsRepos.ForEach(X => X.DiscountPKR += avgDiscount);
                }
                foreach (SaleItemsRepo X in saleItemsRepos)
                {
                    var pInvoice =
                    db.Invoices.FirstOrDefault(I => I.ProductID == X.ProductID && I.Datetime == db.Invoices.Where(D => D.ProductID == X.ProductID).Max(D => D.Datetime));
                    if (pInvoice != null)
                        if (pInvoice.PurchasePriceUnit * X.Quantity > X.UntTotalWithDiscount)
                        {
                            var d = CustomMessageBox.ShowDialog(this, "Do you want to continue with this sale as it has less sale price then purchase");
                            if (d == DialogResult.No)
                            {
                                continueSale = false;
                                break;
                            }

                        }
                }
                if (!continueSale) return;

                //Setting Up Customer
                string customerName = customersCombo.Text ?? "";
                var customer = db.Customers.FirstOrDefault(X => X.Name == customerName);
                if (customer == null && customersCombo.Text != "Walk In Customer")
                {
                    db.Customers.Add(new Models.Customer
                    {
                        Name = customersCombo.Text,
                        Phone = "none",
                        Email = "none"
                    });
                    db.SaveChanges();
                }
                customer = db.Customers.FirstOrDefault(X => X.Name == customerName);
                int CustomerAccountID = 0;
                if (customerName == "" || customersCombo.Text == "Walk In Customer" || customer == null)
                { SaleMajor.isWalkInCustomer = true; SaleMajor.CustomerID = 0; }
                else
                {
                    SaleMajor.isWalkInCustomer = false;
                    SaleMajor.CustomerID = customer.ID;
                    if (tCashReceivedTxt.Text.ToDouble() < tNetBillTxt.Text.ToDouble())
                    {
                        if (CustomControls.CustomMessageBox.ShowDialog(this, "Net Amount is greater then tCashReceivedTxt.Text.ToDouble(). If You Proceed Remaining balance will be added in customer pay record") != DialogResult.Yes)
                        {
                            continueSale = false;
                        }
                        else
                        {
                            addRemainingInCustomerAccount = true;
                        }
                    }
                }
                if (!continueSale) return;
                try { SDR.CustomerName = customer.Name; } catch { SDR.CustomerName = "Walk In Customer"; };
                try { SDR.CustomerPhone = customer.Phone; } catch { SDR.CustomerPhone = ""; };
                SaleMajor.TotalCash = tAmountTxt.Text.ToDouble();
                SaleMajor.CashRecieved = tCashReceivedTxt.Text.ToDouble();
                SaleMajor.CashReturn = tCashReturnTxt.Text.ToDouble();
                SaleMajor.DateTime = dateTimePicker1.Value;
                SaleMajor.TotalDiscount = tDiscountTxt.Text.ToDouble() + double.Parse(avgDiscountTxt.Text ?? "0");
                if (saleTypeCheck.Checked)
                    SaleMajor.Type = Constants.SaleType.sale;
                else
                    SaleMajor.Type = Constants.SaleType.return_;
                SaleMajor.noOfItems = saleItemsRepos.Count;
                db.Sales.Add(SaleMajor);
                db.SaveChanges();


                if (addRemainingInCustomerAccount)
                {
                    var ca = new Models.CustomerAccount
                    {
                        CustomerID = SaleMajor.CustomerID,
                        DateTime = DateTime.Now,
                        TransactionType = Constants.TransactionType.debit,
                        Amount = tNetBillTxt.Text.ToDouble() - tCashReceivedTxt.Text.ToDouble(),
                        UserID = Constants.UserID,
                        SaleID = Convert.ToInt32(SaleMajor.ID),

                    };
                    db.CustomerAccounts.Add(ca);
                    db.SaveChanges();
                }

                SDR.AmountReceived = tCashReceivedTxt.Text.ToDouble().ToString() ?? "0";
                SDR.TotalDiscount = (tDiscountTxt.Text.ToDouble() + double.Parse(avgDiscountTxt.Text ?? "0")).ToString() ?? "0";
                SDR.TotalPrice = tAmountTxt.Text.ToDouble().ToString() ?? "0";
                SDR.NetAmount = tNetBillTxt.Text.ToDouble().ToString() ?? "0";
                SDR.CashReturn = tCashReturnTxt.Text.ToDouble().ToString() ?? "0";
                SDR.SaleID = SaleMajor.ID.ToString() ?? "none";
                SDR.Date = SaleMajor.DateTime.ToShortDateString();
                SDR.Time = SaleMajor.DateTime.ToShortTimeString();
                ILR.Clear();

                int i = 1;
                if (SaleMajor.Type == Constants.SaleType.return_)
                {
                    saleItemsRepos.ForEach(X => { X.Quantity = X.Quantity * -1; });
                }
                saleItemsRepos.ForEach(X =>
                {
                    db.SaleItems.Add(new Models.SaleItem
                    {
                        Discount = X.DiscountPKR,
                        ProductID = X.ProductID,
                        Quantity = X.Quantity,
                        SaleID = SaleMajor.ID,
                        SalePriceUnit = X.SalePricePerQuantity
                    });
                    ILR.Add(new ItemsListRpt
                    {
                        ID = i.ToString(),
                        ProductName = db.Products.FirstOrDefault(V => V.ID == X.ProductID).Name ?? "not Exists",
                        Quantity = X.Quantity.ToString(),
                        UnitPrice = X.SalePricePerQuantity.ToString(),
                        UnitTotal = X.UnitTotal.ToString()
                    });
                    i++;

                });
                db.SaveChanges();

                //////// 
                var obj = new object[3];
                obj[0] = Constants.ReportTypes.SaleSlip;
                obj[1] = SDR;
                obj[2] = ILR;

                new Reports.Report(obj).Show();
                //new Reports.SaleReport(SDR, ILR).Show();
                Alert.Show("Sale Slip Generated", Alert.alertType.success);
                Refresher();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }


        private void SaleGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (saleGrid.CurrentCell.ColumnIndex == 1 || saleGrid.CurrentCell.ColumnIndex == 2 || saleGrid.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }


        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    e.Handled = true;
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    e.Handled = true;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void productListGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void avgDiscountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculations();
        }

        private void avgDiscountBox_OnValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void ProdSearchTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AvgDiscountBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Calculations();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
