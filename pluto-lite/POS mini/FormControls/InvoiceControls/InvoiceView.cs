using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.InvoiceControls
{
    public partial class InvoiceView : UserControl
    {
        List<Models.Product> Products = new List<Models.Product>();
        List<Models.Vendor> Vendors = new List<Models.Vendor>();
        Models.DBEntities db = new Models.DBEntities();
        string invoiceID { get; set; }
        public InvoiceView()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            try
            {
                invoiceID = "";
                bunifuCustomDataGrid1.Rows.Clear();
                Products = App_Code.DBCache.Products;
                Vendors = App_Code.DBCache.Vendors;
                db.Invoices.GroupBy(x => x.oneTimeID)
                .Select(y => new { Element = y.Key, Counter = y.Count() })
                .ToList().ForEach(X =>
                {
                    var i = db.Invoices.FirstOrDefault(x => x.oneTimeID == X.Element);
                    bunifuCustomDataGrid1.Rows.Add(i.oneTimeID, Vendors.Find(V => V.ID == i.VendorID).Name, Convert.ToDateTime(i.Datetime).ToShortDateString(), Convert.ToDateTime(i.Datetime).ToShortTimeString(), "Details");
                    Application.DoEvents();
                });
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    bunifuCustomDataGrid3.Rows.Clear();
                    detialsPanel.Show();
                    invoiceID = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var ins = db.Invoices.Where(X => X.oneTimeID == invoiceID).ToList(); ;
                    double totalPaid = 0;
                    ins.ForEach(X =>
                    {
                        bunifuCustomDataGrid3.Rows.Add(Products.Find(C => C.ID == X.ProductID).Name, X.PurchasePriceUnit, X.Quantity, (X.PurchasePriceUnit * X.Quantity).ToString());
                        totalPaid += (X.PurchasePriceUnit * X.Quantity);
                    });
                    bunifuCustomDataGrid3.Rows.Add();
                    bunifuCustomDataGrid3.Rows.Add("", "", "Total", totalPaid.ToString());
                    SIR = new SInvoiceRpt
                    {
                        CashPaid = ins.Sum(X=>(X.Quantity*X.PurchasePriceUnit)).ToString(),
                        CashRemaining = "0",
                        Date = DateTime.Now.ToShortDateString(),
                        Time = DateTime.Now.ToShortTimeString(),
                        InvoiceID = ins.First().oneTimeID,
                        VendorName = db.Vendors.FirstOrDefault(X=>X.ID == ins.First().VendorID).Name ?? "None",
                        TotalPayment = ins.Sum(X => (X.Quantity * X.PurchasePriceUnit)).ToString()
                    };
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }
        List<App_Code.ItemsListRpt> ItemsListRpts = new List<App_Code.ItemsListRpt>();
        SInvoiceRpt SIR = new SInvoiceRpt();
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Avaiable ");
        }

        private void delInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(invoiceID)) { Alert.Show("Kindly Select any Invice By Clicking On Any Detail button from particular row", Alert.alertType.warning); return; }
            db.Invoices.RemoveRange(db.Invoices.Where(X => X.oneTimeID == invoiceID).AsEnumerable());
            db.SaveChanges();
            Alert.Show("Invoice Deleted", Alert.alertType.success);
            Refresher();
        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { } catch { }
        }
    }
}
