using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.Vendors
{
    public partial class VendorPayControl : UserControl
    {
        List<Models.Vendor> Vendors = new List<Models.Vendor>();
        List<Models.VendorAccount> VendorAccounts = new List<Models.VendorAccount>();
        Models.Vendor V = new Models.Vendor();

        public VendorPayControl()
        {
            InitializeComponent();
            Refresher();
        }

        public void Refresher()
        {
            creditCheck.Checked = false;
            debitCheck.Checked = false;
            Vendors = App_Code.DBCache.Vendors;
            VendorAccounts = App_Code.DBCache.VendorAccounts;
            vendorDropdown.Items.Clear();
            Vendors.OrderBy(X => X.Name).ToList().ForEach(X =>
            {
                vendorDropdown.Items.Add(X.Name + " |" + X.ID);
            });

        }

        private void vendorDropdown_onItemSelected(object sender, EventArgs e)
        {

        }


        private void creditCheck_OnChange(object sender, EventArgs e)
        {
            if (!creditCheck.Checked)
            {
                debitCheck.Checked = true;
            }
            else
            {
                debitCheck.Checked = false;
            }
        }

        private void debitCheck_OnChange(object sender, EventArgs e)
        {
            if (debitCheck.Checked)
            {
                creditCheck.Checked = false;
            }
            else
            {
                creditCheck.Checked = true;
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                try { var a = double.Parse(cPayTxt.Text); } catch { Alert.Show("Payment Can Only Be Numeric", Alert.alertType.warning); return; }
                var tType = App_Code.Constants.TransactionType.debit;
                if (debitCheck.Checked)
                {
                    tType = App_Code.Constants.TransactionType.debit;
                }
                else if (creditCheck.Checked)
                {
                    tType = App_Code.Constants.TransactionType.credit;
                }
                Models.VendorAccount VA = new Models.VendorAccount
                {
                    Amount = double.Parse(cPayTxt.Text),
                    VendorID = V.ID,
                    DateTime = dateTimePicker1.Value,
                    InvoiceID = "non",
                    TransactionType = tType,
                    UserID = App_Code.Constants.UserID
                };
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    ////print Code

                    object[] obj = new Object[2];
                    obj[0] = Constants.ReportTypes.VendorPaySlip;
                    obj[1] = new PayRpt
                    {
                        AmountPaid = VA.Amount.ToString(),
                        Date = DateTime.Now.ToShortDateString(),
                        Name = App_Code.DBCache.Vendors.Find(X => X.ID == VA.VendorID).Name,
                        RemainingAmount = (double.Parse(CashPaymenttxt.Text) - double.Parse(cPayTxt.Text)).ToString()
                    };
                    new Reports.Report(obj).Show();

                    db.VendorAccounts.Add(VA);
                    db.SaveChanges();
                    Alert.Show("Vendor Account Saved With " + VA.TransactionType, Alert.alertType.success);
                }
            }
            catch { }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (vendorDropdown.Text == "" || V == null)
            {
                Alert.Show("Kindly Select Any Vendor First", Alert.alertType.warning); return;
            }
            List<App_Code.PayRecord> PR = new List<App_Code.PayRecord>();
            List<Models.VendorAccount> vvvv = VendorAccounts.FindAll(X => X.VendorID == V.ID);
            int i = 1;
            var invoices = App_Code.DBCache.Invoices;
            vvvv.ForEach(X =>
            {

                if (X.InvoiceID == "none")
                {
                    PR.Add(new PayRecord
                    {
                        Amount = X.Amount.ToString(),
                        CustomerOrVendorName = V.Name,
                        Date = Convert.ToDateTime(X.DateTime).ToShortDateString(),
                        Time = Convert.ToDateTime(X.DateTime).ToShortTimeString(),
                        ID = i.ToString(),
                        PaymentType = X.TransactionType.ToString(),
                        SaleStatus = X.InvoiceID.ToString(),
                        SaleAmount = "0"
                    });
                }
                if (X.InvoiceID != "none")
                {
                    double TotalBill = 0;
                    invoices.FindAll(C => C.oneTimeID == X.InvoiceID.ToString()).ForEach(C =>
                    {
                        TotalBill += (C.Quantity * C.PurchasePriceUnit);
                    });

                    PR.Add(new PayRecord
                    {
                        Amount = X.Amount.ToString(),
                        CustomerOrVendorName = V.Name,
                        Date = Convert.ToDateTime(X.DateTime).ToShortDateString(),
                        Time = Convert.ToDateTime(X.DateTime).ToShortTimeString(),
                        ID = i.ToString(),
                        PaymentType = X.TransactionType.ToString(),
                        SaleStatus = X.InvoiceID.ToString(),
                        SaleAmount = (TotalBill - X.Amount).ToString()
                    });
                }

                i++;
            });
            var innerObj =new object[3];
            var obj =new object[3];
            obj[0] = Constants.ReportTypes.VendorReportFile;
            obj[1] = PR;
            innerObj[0] = V.Name;
            innerObj[1] = rOrPTxt.Text;
            innerObj[2] = CashPaymenttxt.Text;
            obj[2] = innerObj;
            new Reports.Report(obj).Show();
            Refresher();
        }

        private void VendorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var v = Vendors.Find(X => X.ID == int.Parse(vendorDropdown.Text.Split('|')[1]));
            V = v;
            double totalCredits = 0;
            double totalDebits = 0;
            List<Models.VendorAccount> vvvv = VendorAccounts.FindAll(X => X.VendorID == v.ID);
            if (vvvv.Count == 0)
            {
                rOrPTxt.Text = "No Previos Records";
                CashPaymenttxt.Text = "0";
                return;
            }
            vvvv.FindAll(X => X.TransactionType == App_Code.Constants.TransactionType.credit).ForEach(X =>
            {
                totalCredits += X.Amount;
            });
            vvvv.FindAll(X => X.TransactionType == App_Code.Constants.TransactionType.debit).ForEach(X =>
            {
                totalDebits += X.Amount;
            });
            if (totalCredits > totalDebits)
            {
                rOrPTxt.Text = "Payable (credits)";
                CashPaymenttxt.Text = (totalCredits - totalDebits).ToString();
            }
            else if (totalCredits < totalDebits)
            {
                rOrPTxt.Text = "Recievable (debits)";
                CashPaymenttxt.Text = (totalDebits - totalCredits).ToString();
            }
            else
            {
                rOrPTxt.Text = "nill";
                CashPaymenttxt.Text = "0";
            }
        }
    }
}
