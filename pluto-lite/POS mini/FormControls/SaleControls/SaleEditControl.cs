using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class SaleEditControl : UserControl
    {
        Models.DBEntities db = new Models.DBEntities();

        List<Models.Customer> Customers { get; set; }
        List<Models.Sale> Sales { get; set; }
        Models.Sale Sale { get; set; }
        List<Models.SaleItem> SaleItemsDump { get; set; }
        List<Thread> BGWorker { get; set; }
        /// 
        List<Models.SaleItemsRepo> saleItemsRepos = new List<Models.SaleItemsRepo>();
        SaleDetailRpt SDR = new SaleDetailRpt();
        List<ItemsListRpt> ILR = new List<ItemsListRpt>();
        /// 


        public SaleEditControl()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            Customers = DBCache.Customers;
            Sales = DBCache.Sales;
            saleDetailPanel.Hide();
            customersCombo.Items.Clear();
            Customers.ForEach(X =>
            {
                Application.DoEvents();
                customersCombo.Items.Add(X.Name);
            });
            dataGridView1.Rows.Clear();
            BGWorker = new List<Thread>();
            BGWorker.ForEach(X => X.Abort());
            BGWorker.Clear();
            BGWorker.Add(
                new Thread(new ThreadStart(delegate
                {
                    Sales.ForEach(X =>
                    {
                        if (X.isWalkInCustomer)
                        {
                            Invoke(new Action(delegate { Application.DoEvents(); dataGridView1.Rows.Add(X.ID, "Walk In Customer", Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                        }
                        else
                        {
                            Invoke(new Action(delegate { Application.DoEvents(); dataGridView1.Rows.Add(X.ID, Customers.Find(C => C.ID == X.CustomerID).Name, Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                        }
                    });
                }))
            );
            BGWorker.ForEach(X => X.Start());
        }
        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            var sortedSales = db.Sales.Where(X => X.isWalkInCustomer == true).ToList();

            dataGridView1.Rows.Clear();
            BGWorker.ForEach(X => X.Abort());
            BGWorker.Clear();
            BGWorker.Add(
                new Thread(new ThreadStart(delegate
                {
                    sortedSales.ForEach(X =>
                    {
                        Invoke(new Action(delegate { Application.DoEvents(); dataGridView1.Rows.Add(X.ID, "Walk In Customer", Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                    });
                }))
            );
            BGWorker.ForEach(X => X.Start());
        }
        private void CustomersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Models.Customer ccc = new Models.Customer();
                ccc = db.Customers.FirstOrDefault(C => C.Name == customersCombo.Text);
                if (ccc != null)
                {
                    var sortedSales = Sales.FindAll(X => X.CustomerID == ccc.ID);
                    dataGridView1.Rows.Clear();
                    BGWorker.ForEach(X => X.Abort());
                    BGWorker.Clear();
                    BGWorker.Add(
                        new Thread(new ThreadStart(delegate
                        {
                            sortedSales.ForEach(X =>
                            {
                                if (X.isWalkInCustomer)
                                {
                                    Invoke(new Action(delegate { dataGridView1.Rows.Add(X.ID, "Walk In Customer", Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                                }
                                else
                                {
                                    Invoke(new Action(delegate { dataGridView1.Rows.Add(X.ID, Customers.Find(C => C.ID == X.CustomerID).Name, Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                                }
                            });
                        }))
                    );
                    BGWorker.ForEach(X => X.Start());
                }
            }
            catch { }
        }

        private void SaleDateTimePicker_ValueChanged(object sender, EventArgs e)
        {


            var currentValue = saleDateTimePicker.Value;
            var currentValueNext = saleDateTimePicker.Value.AddDays(1);
            var sortedSales = db.Sales.Where(X => X.DateTime >= currentValue && X.DateTime <= currentValueNext).ToList();
            dataGridView1.Rows.Clear();
            BGWorker.ForEach(X => X.Abort());
            BGWorker.Clear();
            BGWorker.Add(
                new Thread(new ThreadStart(delegate
                {
                    sortedSales.ForEach(X =>
                    {
                        if (X.isWalkInCustomer)
                        {
                            Invoke(new Action(delegate { dataGridView1.Rows.Add(X.ID, "Walk In Customer", Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                        }
                        else
                        {
                            Invoke(new Action(delegate { dataGridView1.Rows.Add(X.ID, Customers.Find(C => C.ID == X.CustomerID).Name, Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString()); }));
                        }
                    });
                }))
            );
            BGWorker.ForEach(X => X.Start());
        }

        //select A Sale From Grid
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var saleId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Sale = db.Sales.FirstOrDefault(X => X.ID == saleId);
            SaleItemsDump = db.SaleItems.Where(X => X.SaleID == saleId).ToList();
            saleDetailPanel.Show();
            if (Sale.isWalkInCustomer)
                sdCustomerTxt.Text = "Walk In Customer";
            else
                sdCustomerTxt.Text = Customers.Find(X => X.ID == Sale.CustomerID).Name;
            var dt = Convert.ToDateTime(Sale.DateTime);
            sdDate.Text = dt.ToLongDateString();
            sdTime.Text = dt.ToShortTimeString();
            if (Sale.Type == Constants.SaleType.return_)
                sTypeTxt.Text = "Sale Type : Return";
            else
                sTypeTxt.Text = "Sale Type : Sale";
            saleItemsRepos.Clear();
            SaleItemsDump.ForEach(X =>
            {
                saleItemsRepos.Add(new Models.SaleItemsRepo
                {
                    DiscountPKR = X.Discount,
                    ProductID = X.ProductID,
                    Quantity = X.Quantity,
                    SalePricePerQuantity = X.SalePriceUnit,
                });
            });
            var products = DBCache.Products;
            fillSaleItemGrid();

            sdProductsCombo.DataSource = products;
            sdProductsCombo.DisplayMember = "Name";
        }

        private void SaleItemsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var products = DBCache.Products;
                saleItemsRepos.RemoveAll(X => X.ProductID == products.Find(C => C.Name == saleItemsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ID);
                fillSaleItemGrid();
            }
        }

        private void SaleItemsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //quantity
            if (e.ColumnIndex == 1)
            {
                try
                {
                    var products = DBCache.Products;
                    saleItemsRepos.Find(X => X.ProductID == products.Find(C => C.Name == saleItemsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ID).Quantity = double.Parse(saleItemsGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    fillSaleItemGrid();
                }
                catch { Alert.Show("Kindly Enter Numeric Value Only", Alert.alertType.warning); }
            }
            //unitprice
            if (e.ColumnIndex == 2)
            {
                try
                {
                    var products = DBCache.Products;
                    saleItemsRepos.Find(X => X.ProductID == products.Find(C => C.Name == saleItemsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ID).SalePricePerQuantity = double.Parse(saleItemsGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    fillSaleItemGrid();
                }
                catch { Alert.Show("Kindly Enter Numeric Value Only", Alert.alertType.warning); }
            }
            //discount
            if (e.ColumnIndex == 3)
            {
                try
                {
                    var products = DBCache.Products;
                    saleItemsRepos.Find(X => X.ProductID == products.Find(C => C.Name == saleItemsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).ID).DiscountPKR = double.Parse(saleItemsGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    fillSaleItemGrid();
                }
                catch { Alert.Show("Kindly Enter Numeric Value Only", Alert.alertType.warning); }
            }
        }

        private void fillSaleItemGrid()
        {
            var products = DBCache.Products;
            double totalPrice = 0;
            saleItemsGrid.Rows.Clear();
            saleItemsRepos.ForEach(X =>
            {
                saleItemsGrid.Rows.Add(products.Find(V => V.ID == X.ProductID).Name, X.Quantity, X.SalePricePerQuantity, X.DiscountPKR, X.UnitTotal, "X");
                totalPrice += X.UntTotalWithDiscount;
            });
            tpricewdTxt.Text = totalPrice.ToString();
        }

        //add sale Item
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (sdProductsCombo.Text == "") { Alert.Show("Kindly Select Any Combo", Alert.alertType.warning); return; }
            var product = DBCache.Products.Find(X => X.Name == sdProductsCombo.Text);
            if (saleItemsRepos.Exists(X => X.ProductID == product.ID))
            {
                saleItemsRepos.Find(X => X.ProductID == product.ID).Quantity += 1;
                fillSaleItemGrid();
            }
            else
            {
                saleItemsRepos.Add(new Models.SaleItemsRepo
                {
                    ProductID = product.ID,
                    Quantity = 1,
                    DiscountPKR = 0,
                    SalePricePerQuantity = product.SalePrice
                });
                fillSaleItemGrid();
            }

        }

        private void SaleEditUpdateBtn_Click(object sender, EventArgs e)
        {
            using (Models.DBEntities db = new Models.DBEntities())
            {
                SDR = new SaleDetailRpt
                {
                    SaleID = Sale.ID.ToString(),
                    AmountReceived = Sale.CashRecieved.ToString() ?? "0",
                    CashReturn = Sale.CashReturn.ToString() ?? "0",
                    Date = Sale.DateTime.ToShortDateString(),
                    Time = Sale.DateTime.ToShortTimeString(),
                    NetAmount = (Sale.TotalCash - Sale.TotalDiscount).ToString() ?? "0",
                    TotalDiscount = Sale.TotalDiscount.ToString() ?? "0",
                    TotalPrice = Sale.TotalCash.ToString() ?? "0"
                };
                SaleItemsDump.ForEach(X =>
                {
                    db.SaleItems.Remove(db.SaleItems.Where(C => C.ID == X.ID).First());
                });
                int i = 1;
                saleItemsRepos.ForEach(X =>
                {
                    db.SaleItems.Add(new Models.SaleItem
                    {
                        Discount = X.DiscountPKR,
                        ProductID = X.ProductID,
                        Quantity = X.Quantity,
                        SaleID = Sale.ID,
                        SalePriceUnit = X.SalePricePerQuantity
                    });
                    ILR.Add(new ItemsListRpt
                    {
                        ID = i.ToString(),
                        ProductName = db.Products.FirstOrDefault(C => C.ID == X.ProductID).Name ?? "None",
                        Quantity = X.Quantity.ToString() ?? "0",
                        UnitPrice = X.SalePricePerQuantity.ToString() ?? "0",
                        UnitTotal = X.UnitTotal.ToString() ?? "0"
                    });
                });
                db.SaveChanges();
                Alert.Show("Sale Updated", Alert.alertType.success);

                var obj = new object[3];
                obj[0] = Constants.ReportTypes.SaleSlip;
                obj[1] = SDR;
                obj[2] = ILR;
                new Reports.Report(obj).Show();
                Refresher();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            saleDetailPanel.Hide();
            Refresher();
        }

        private void DeleteSaleBtn_Click(object sender, EventArgs e)
        {
            using (Models.DBEntities db = new Models.DBEntities())
            {
                db.Sales.Remove(db.Sales.Where(X => X.ID == Sale.ID).First());

                SaleItemsDump.ForEach(X =>
                {
                    db.SaleItems.Remove(db.SaleItems.Where(C => C.ID == X.ID).First());
                });
                db.SaveChanges();
                Alert.Show("Sale Deleted", Alert.alertType.success);
                Refresher();
            }
        }

        private void PrintAgainBtn_Click(object sender, EventArgs e)
        {



            // new Reports.SaleReport();
        }

        private void SaleItemsGrid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SaleItemsGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3) //Desired Column
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
    }
}
