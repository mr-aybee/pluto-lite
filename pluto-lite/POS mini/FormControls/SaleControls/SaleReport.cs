using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class SaleReport : UserControl
    {
        List<Models.Sale> Sales = new List<Models.Sale>();
        List<Models.SaleItem> SaleItems = new List<Models.SaleItem>();
        List<Models.Customer> Customers = new List<Models.Customer>();
        List<Models.Product> Products = new List<Models.Product>();
        List<MultiSaleRecord> MSR = new List<MultiSaleRecord>();
        Models.DBEntities db = new Models.DBEntities();
        public SaleReport()
        {
            InitializeComponent();

            MSR = new List<MultiSaleRecord>();
            try
            {
                bunifuCustomDataGrid1.Rows.Clear();
                int i = 0;
                if (Sales.Count < 1000)
                {
                    Sales.FindAll(X => Convert.ToDateTime(X.DateTime).Day == DateTime.Now.Day).ForEach(V =>
                    {
                        SaleItems.FindAll(C => C.SaleID == V.ID).ForEach(C =>
                        {
                            if (V.isWalkInCustomer)
                            {
                                try { bunifuCustomDataGrid1.Rows.Add("Walk In Customer", Products.Find(X => X.ID == C.ProductID).Name, C.Quantity, C.SalePriceUnit, (C.Quantity * C.SalePriceUnit).ToString(), Convert.ToDateTime(V.DateTime).ToShortDateString()); } catch { }
                                MSR.Add(new MultiSaleRecord
                                {
                                    ID = i.ToString(),
                                    CustomerName = "Walk In Customer",
                                    Date = Convert.ToDateTime(V.DateTime).ToShortDateString(),
                                    ProductName = Products.Find(B => B.ID == C.ProductID).Name,
                                    Quantity = C.Quantity.ToString(),
                                    SalePrice = C.SalePriceUnit.ToString(),
                                    UnitTotal = (C.Quantity * C.SalePriceUnit).ToString(),
                                    Time = Convert.ToDateTime(V.DateTime).ToShortTimeString()
                                });
                            }
                            else
                            {
                                try { bunifuCustomDataGrid1.Rows.Add(Customers.Find(X => X.ID == V.CustomerID).Name, Products.Find(X => X.ID == C.ProductID).Name, C.Quantity, C.SalePriceUnit, (C.Quantity * C.SalePriceUnit).ToString(), Convert.ToDateTime(V.DateTime).ToShortDateString()); } catch { }
                                MSR.Add(new MultiSaleRecord
                                {
                                    ID = i.ToString(),
                                    CustomerName = Customers.Find(X => X.ID == V.CustomerID).Name,
                                    Date = Convert.ToDateTime(V.DateTime).ToShortDateString(),
                                    ProductName = Products.Find(B => B.ID == C.ProductID).Name,
                                    Quantity = C.Quantity.ToString(),
                                    SalePrice = C.SalePriceUnit.ToString(),
                                    UnitTotal = (C.Quantity * C.SalePriceUnit).ToString(),
                                    Time = Convert.ToDateTime(V.DateTime).ToShortTimeString()
                                });
                            }
                            i++;
                        });
                    });
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }

        }

        // (to) date time picker disables
        private void singleDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (singleDayCheck.Checked)
                toDatePicker.Enabled = true;
            else
                toDatePicker.Enabled = false;
        }
        //Export button
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (frmDatePicker.Value == null) return;
            if (MSR.Count < 1) return;
            try
            {

                var obj = new object[3];
                obj[0] = Constants.ReportTypes.SaleSheet;
                obj[1] = MSR;
                obj[2] = frmDatePicker.Value.ToShortDateString();
                new Reports.Report(obj).Show();
                //new Reports.MultiSaleRecord(MSR, frmDatePicker.Value.ToShortDateString()).Show();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }
        // Get Button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime toCurrent;
                DateTime toNext;

                if (!toDatePicker.Enabled)
                {
                    toCurrent = frmDatePicker.Value;
                    toNext = frmDatePicker.Value.AddDays(1);
                }
                else
                {
                    toCurrent = frmDatePicker.Value;
                    toNext = toDatePicker.Value;
                }
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.SaleReportQuery(toCurrent, toNext);
                if(cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                bunifuCustomDataGrid1.DataSource = table;
                for (int j = 0; j <= bunifuCustomDataGrid1.ColumnCount - 1; j++)
                    bunifuCustomDataGrid1.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                MSR = new List<MultiSaleRecord>();
                int i= 0;
                foreach(DataRow dr in table.Rows)
                {
                    var mss = new MultiSaleRecord { 
                        ID = i.ToString(),
                        CustomerName = dr["Customer"].ToString(),
                        Quantity = dr["Quantity"].ToString(),
                        SalePrice = dr["SalePriceUnit"].ToString(),
                        Date = Convert.ToDateTime(dr["DateTime"]).ToShortDateString(),
                        Time = Convert.ToDateTime(dr["DateTime"]).ToShortTimeString(),
                        ProductName = dr["Product"].ToString(),
                        UnitTotal = dr["UnitTotal"].ToString()
                    };
                    MSR.Add(mss);
                    i++;
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }
    }
}
