using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.InvoiceControls
{
    public partial class InvoicesReportControl : UserControl
    {
        List<Models.Vendor> Vendors = new List<Models.Vendor>();
        List<Models.Invoice> Invoices = new List<Models.Invoice>();

        InvoicesDetailsRpt IDR = new InvoicesDetailsRpt();
        List<AllInvoicesRpt> AIR = new List<AllInvoicesRpt>();
        public InvoicesReportControl()
        {
            InitializeComponent();
            Refresher();
        }

        public void Refresher()
        {
            try
            {
                vendorNameDropDown.ResetText();
                fromDatePicker.ResetText();
                Vendors = DBCache.Vendors;
                Invoices = DBCache.Invoices;
                IDR = new InvoicesDetailsRpt();
                AIR = new List<AllInvoicesRpt>();
                vendorNameDropDown.Items.Clear();
                vendorNameDropDown.Items.Add("ALL|");
                Vendors.ForEach(X => { Application.DoEvents(); vendorNameDropDown.Items.Add(X.Name + "  |" + X.ID); });
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void printInvoicesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string vendorName = "ALL";

                if (vendorNameDropDown.Text != "ALL|" && vendorNameDropDown.Text != "")
                {
                    vendorName = vendorNameDropDown.Text.Split('|')[0];
                    Invoices = Invoices.FindAll(X => X.VendorID == int.Parse(vendorNameDropDown.Text.Split('|')[1]));
                }
                if (allTimeCheck.Checked == false)
                    Invoices.FindAll(X => X.Datetime.Day == fromDatePicker.Value.Day && X.Datetime.Month == fromDatePicker.Value.Month && X.Datetime.Year == fromDatePicker.Value.Year);
                IDR = new InvoicesDetailsRpt
                {
                    FromDate = "ALL",
                    TotalInvoice = Invoices.GroupBy(X => X.oneTimeID).Count().ToString(),
                    TotalProductsInvoice = Invoices.Count.ToString(),
                    VendorName = vendorName,
                };
                if (allTimeCheck.Checked == false)
                    IDR.FromDate = fromDatePicker.Value.ToString();
                int asd = 0;
                Invoices.ForEach(X =>
                {
                    try
                    {
                        AIR.Add(new AllInvoicesRpt
                        {
                            ID = asd.ToString(),
                            ProductName = DBCache.Products.Find(V => V.ID == X.ProductID).Name,
                            Quantity = X.Quantity.ToString(),
                            UnitPrice = X.PurchasePriceUnit.ToString(),
                            UnitTotal = (X.Quantity * X.PurchasePriceUnit).ToString(),
                            VendorName = Vendors.Find(x => x.ID == X.VendorID).Name,
                            Date = Convert.ToDateTime(X.Datetime).ToShortDateString(),
                            Time = Convert.ToDateTime(X.Datetime).ToShortTimeString(),
                            InvoiceID = X.oneTimeID
                        });
                        asd++;
                    }
                    catch { }
                });

                object[] obj = new object[3];
                obj[0] = Constants.ReportTypes.InvoiceReportFile;
                obj[1] = AIR;
                obj[2] = IDR;
                new Reports.Report(obj).Show();
                //new Reports.InvoiceReport(IDR, AIR).Show();
                Alert.Show("Invoices Record Printed", Alert.alertType.success);
                Refresher();
                return;


            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }


        }

        private void allTimeCheck_OnChange(object sender, EventArgs e)
        {
            try
            {
                if (allTimeCheck.Checked)
                    fromDatePicker.Enabled = false;
                else
                    fromDatePicker.Enabled = true;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void InvoicesReportControl_Load(object sender, EventArgs e)
        {

        }
    }
}
