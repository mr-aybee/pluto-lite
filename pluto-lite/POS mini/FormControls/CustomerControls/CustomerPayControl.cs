using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.CustomerControls
{
    public partial class cPayBtn : UserControl
    {
        List<Models.CustomerAccount> CustomerAccounts = new List<Models.CustomerAccount>();
        List<Models.Customer> Customers = new List<Models.Customer>();
        Models.Customer C = new Models.Customer();
        Models.DBEntities db = new Models.DBEntities();
        public cPayBtn()
        {
            InitializeComponent();
            Refresher();
        }

        public void Refresher()
        {
            try
            {
                creditCheck.Checked = false;
                debitCheck.Checked = false;
                Customers = DBCache.Customers;
                CustomerAccounts = DBCache.CustomerAccounts;
                customerDropDown.Items.Clear();
                saleIDTxt.Text = "0";
                Customers.ForEach(X =>
                {
                    customerDropDown.Items.Add(X.Name + "  |" + X.ID);
                });
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }


        private void creditCheck_OnChange(object sender, EventArgs e)
        {
            try
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
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void debitCheck_OnChange(object sender, EventArgs e)
        {
            try
            {
                if (debitCheck.Checked)
                    creditCheck.Checked = false;
                else
                    creditCheck.Checked = true;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void customerDropDown_onItemSelected(object sender, EventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                try { var a = double.Parse(cPayTxt.Text); } catch { Alert.Show("Payment Can Only Be Numeric", Alert.alertType.warning); return; }
                try { var a = int.Parse(saleIDTxt.Text); } catch { Alert.Show("Sale Id Mus Only be Numeric", Alert.alertType.warning); return; }
                var tType = Constants.TransactionType.debit;
                if (debitCheck.Checked)
                {
                    tType = Constants.TransactionType.debit;
                }
                else if (creditCheck.Checked)
                {
                    tType = Constants.TransactionType.credit;
                }
                Models.CustomerAccount CA = new Models.CustomerAccount
                {
                    Amount = double.Parse(cPayTxt.Text),
                    CustomerID = C.ID,
                    DateTime = dateTimePicker1.Value,
                    SaleID = int.Parse(saleIDTxt.Text),
                    TransactionType = tType,
                    UserID = Constants.UserID
                };
                object[] obj = new object[2];
                obj[0] = Constants.ReportTypes.CustomerPaySlip;
                obj[1] = new App_Code.PayRpt
                {
                    AmountPaid = CA.Amount.ToString(),
                    Date = DateTime.Now.ToShortDateString(),
                    Name = DBCache.Customers.Find(X => X.ID == CA.CustomerID).Name,
                    RemainingAmount = (double.Parse(CashPaymenttxt.Text) - double.Parse(cPayTxt.Text)).ToString()
                };
                new Reports.Report(obj).Show();
                db.CustomerAccounts.Add(CA);
                db.SaveChanges();
                Alert.Show("Customer Account Saved With " + CA.TransactionType, Alert.alertType.success);
                Refresher();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void customerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cidSelected = int.Parse(customerDropDown.Text.Split('|')[1]);
                var c = db.Customers.FirstOrDefault(X => X.ID == cidSelected);
                C = c;
                double totalCredits = 0;
                double totalDebits = 0;
                List<Models.CustomerAccount> cccc = db.CustomerAccounts.Where(X => X.CustomerID == c.ID).ToList();
                if (cccc.Count == 0)
                {
                    rOrPTxt.Text = "No Previos Records";
                    CashPaymenttxt.Text = "0";
                    return;
                }
                cccc.FindAll(X => X.TransactionType == Constants.TransactionType.credit).ForEach(X =>
                {
                    totalCredits += X.Amount;
                });
                cccc.FindAll(X => X.TransactionType == Constants.TransactionType.debit).ForEach(X =>
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
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (customerDropDown.SelectedIndex < 0 || string.IsNullOrEmpty(C.Name)) { Alert.Show("Kindly Select Any Customer First", Alert.alertType.warning); return; }
            List<PayRecord> PR = new List<PayRecord>();
            var Sales = DBCache.Sales;
            List<Models.CustomerAccount> cccc = db.CustomerAccounts.Where(X => X.CustomerID == C.ID).ToList();
            int i = 1;

            cccc.ForEach(X =>
            {
                if (Sales.Exists(c => c.ID == X.SaleID))
                    PR.Add(new PayRecord
                    {
                        Amount = X.Amount.ToString(),
                        CustomerOrVendorName = C.Name,
                        Date = Convert.ToDateTime(X.DateTime).ToShortDateString(),
                        Time = Convert.ToDateTime(X.DateTime).ToShortTimeString(),
                        ID = i.ToString(),
                        PaymentType = X.TransactionType.ToString(),
                        SaleStatus = X.SaleID.ToString(),
                        SaleAmount = Sales.FirstOrDefault(V => V.ID == X.SaleID).CashRecieved.ToString()
                    });
                else
                    PR.Add(new PayRecord
                    {
                        Amount = X.Amount.ToString(),
                        CustomerOrVendorName = C.Name,
                        Date = Convert.ToDateTime(X.DateTime).ToShortDateString(),
                        Time = Convert.ToDateTime(X.DateTime).ToShortTimeString(),
                        ID = i.ToString(),
                        PaymentType = X.TransactionType.ToString(),
                        SaleStatus = X.SaleID.ToString(),
                        SaleAmount = "Was No Sale"
                    });
                i++;
            });

            object[] innerObj = new object[4];
            innerObj[0] = PR;
            innerObj[1] = C.Name;
            innerObj[2] = rOrPTxt.Text;
            innerObj[3] = CashPaymenttxt.Text;
            object[] obj = new object[2];
            obj[0] = Constants.ReportTypes.CustomerReportFile;
            obj[1] = innerObj;
            new Reports.Report(obj).Show();
            //new Reports.CustomerPayReport(PR, C.Name, rOrPTxt.Text, CashPaymenttxt.Text).Show();
        }
    }
}
