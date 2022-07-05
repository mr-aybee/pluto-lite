using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POS_mini.FormControls.ProductControls
{
    public partial class ProductReportControl : UserControl
    {
        List<ProductsInventoryRpt> PRC = new List<ProductsInventoryRpt>();
        List<Thread> BGWorker = new List<Thread>();
        Models.DBEntities db = new Models.DBEntities();
        public ProductReportControl()
        {
            InitializeComponent();
            PRC = new List<ProductsInventoryRpt>();
            // Refresher();
        }

        public void Refresher()
        {
            PRC = new List<ProductsInventoryRpt>();
            bunifuThinButton21.Enabled = false;
            BGWorker = new List<Thread>();
            BGWorker.ForEach(X => X.Abort());
            BGWorker.Clear();
            BGWorker.Add(new Thread(new ThreadStart(delegate
            {
                List<Models.Product> Products = DBCache.Products;
                List<Models.Invoice> Invoices = DBCache.Invoices;
                List<Models.SaleItem> saleItems = DBCache.SaleItems;
                int i = 0;
                var prc_dump = new List<ProductsInventoryRpt>();
                Products.ForEach(X =>
                {
                    double invoiced = 0, totalPurchases = 0, sold = 0, stock = 0;
                    Invoices.FindAll(C => C.ProductID == X.ID).ForEach(C =>
                    {
                        invoiced += C.Quantity;
                        totalPurchases += (C.Quantity * C.PurchasePriceUnit);
                    });
                    saleItems.FindAll(C => C.ProductID == X.ID).ForEach(V =>
                    {
                        sold += V.Quantity;
                    });
                    stock = invoiced - sold;
                    prc_dump.Add(new ProductsInventoryRpt
                    {
                        ID = i.ToString(),
                        Invoiced = invoiced.ToString(),
                        ProductName = X.Name,
                        SalePrice = X.SalePrice.ToString(),
                        Sold = sold.ToString(),
                        Stock = stock.ToString(),
                        TotalPurchase = totalPurchases.ToString()
                    });
                    i++;
                });
                Invoke(new Action(delegate
                {
                    bunifuCustomDataGrid1.Rows.Clear();
                    PRC = prc_dump;
                    PRC.ForEach(X =>
                    {
                        Application.DoEvents();
                        bunifuCustomDataGrid1.Rows.Add(X.ID, X.ProductName, X.SalePrice, X.Stock, X.Invoiced, X.TotalPurchase, X.Sold);
                    });
                    bunifuThinButton21.Enabled = true;
                }));
            })));
            BGWorker.ForEach(X => X.Start());


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            var obj = new object[2];
            obj[0] = Constants.ReportTypes.ProductReport;
            obj[1] = PRC;
            new Reports.Report(obj).Show();
            //new Reports.ProductReport(PRC).Show();
            Alert.Show("Inventory Report Printed", Alert.alertType.success);
        }

        private void pSearchBox_OnTextChange(object sender, EventArgs e)
        {
            var pText = pSearchBox.text;
            if (string.IsNullOrEmpty(pText)) return;
            PRC = new List<ProductsInventoryRpt>();
            bunifuThinButton21.Enabled = false;
            BGWorker.ForEach(X => X.Abort());
            BGWorker.Clear();
            BGWorker.Add(new Thread(new ThreadStart(delegate
            {
                List<Models.Product> Products = db.Products.Where(X => X.Name.ToLower().Contains(pText.ToLower())).ToList();
                List<Models.Invoice> Invoices = DBCache.Invoices;
                List<Models.SaleItem> saleItems = DBCache.SaleItems;
                int i = 0;
                var prc_dump = new List<ProductsInventoryRpt>();
                Products.ForEach(X =>
                {
                    double invoiced = 0, totalPurchases = 0, sold = 0, stock = 0;
                    Invoices.FindAll(C => C.ProductID == X.ID).ForEach(C =>
                    {
                        invoiced += C.Quantity;
                        totalPurchases += (C.Quantity * C.PurchasePriceUnit);
                    });
                    saleItems.FindAll(C => C.ProductID == X.ID).ForEach(V =>
                    {
                        sold += V.Quantity;
                    });
                    stock = invoiced - sold;

                    prc_dump.Add(new ProductsInventoryRpt
                    {
                        ID = i.ToString(),
                        Invoiced = invoiced.ToString(),
                        ProductName = X.Name,
                        SalePrice = X.SalePrice.ToString(),
                        Sold = sold.ToString(),
                        Stock = stock.ToString(),
                        TotalPurchase = totalPurchases.ToString()
                    });
                    i++;
                });
                Invoke(new Action(delegate
                {
                    PRC = prc_dump;
                    bunifuCustomDataGrid1.Rows.Clear();
                    PRC.ForEach(X =>
                    {
                        try
                        {
                            Application.DoEvents();
                            bunifuCustomDataGrid1.Rows.Add(X.ID, X.ProductName, X.SalePrice, X.Stock, X.Invoiced, X.TotalPurchase, X.Sold);
                        }
                        catch { }
                    });
                    bunifuThinButton21.Enabled = true;
                }));
            })));
            BGWorker.ForEach(X => X.Start());

        }

    }
}
