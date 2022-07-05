using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_mini.FormControls.DashboardSettings

{
    public partial class DashboardControl : UserControl
    {
        Models.DBEntities db = new Models.DBEntities();
        public DashboardControl()
        {
            InitializeComponent();
            Refresher();
        }


        public void Refresher()
        {
            try
            {

                todaySaleGraph();
                todayInvoiceGraph();
                productAlertNotif();
                oneDayData();
                oneWeekData();
                oneMonthData();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }


        //////////////////////
        //// 1st Row
        //////////////////
        private void productAlertNotif()
        {
            try
            {
                new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        var table = new DataTable();
                        var cmd = db.Database.Connection.CreateCommand();
                        cmd.CommandText = Constants.productAlertNotif;
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        table.Load(cmd.ExecuteReader());
                        Invoke(new Action(delegate
                        {
                            try
                            {
                                bunifuCustomDataGrid1.DataSource = table;
                                for (int j = 0; j <= bunifuCustomDataGrid1.ColumnCount - 1; j++)
                                    bunifuCustomDataGrid1.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
                        }));
                    }
                    catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }

                })).Start();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void todaySaleGraph()
        {
            try
            {
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.todaysSaleGraphQuery;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                todaysSaleGraph.DataSource = table;
                todaysSaleGraph.Series["Series1"].XValueMember = "ProductName";
                todaysSaleGraph.Series["Series1"].YValueMembers = "Count";
                todaysSaleGrid.DataSource = table;
                for (int j = 0; j <= todaysSaleGrid.ColumnCount - 1; j++)
                    todaysSaleGrid.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void todayInvoiceGraph()
        {
            try
            {
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.todaysInvoiceGraphQuery;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                todaysInvoiceGraph.DataSource = table;
                todaysInvoiceGraph.Series["Series1"].XValueMember = "ProductName";
                todaysInvoiceGraph.Series["Series1"].YValueMembers = "Count";
                todaysInvoiceGrid.DataSource = table;
                for (int j = 0; j <= todaysInvoiceGrid.ColumnCount - 1; j++)
                    todaysInvoiceGrid.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private bool g = true;
        private void todaysInvoiceHeading_Click(object sender, EventArgs e)
        {
            try
            {
                if (g)
                {
                    todaysInvoiceGrid.BringToFront();
                    g = false;
                }
                else
                {
                    todaysInvoiceGraph.BringToFront();
                    g = true;
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }
        private bool gs = true;
        private void todaySaleHeading_Click(object sender, EventArgs e)
        {
            try
            {
                if (gs)
                {
                    todaysSaleGrid.BringToFront();
                    gs = false;
                }
                else
                {
                    todaysSaleGraph.BringToFront();
                    gs = true;
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }



        //////////////////////
        //// 2nd Row
        //////////////////
        private void oneDayData()
        {
            try
            {
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.DayValuesQuery;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                dayGrid.DataSource = table;
                for (int j = 0; j <= dayGrid.ColumnCount - 1; j++)
                    dayGrid.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void oneWeekData()
        {
            try
            {
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.WeekValuesQuery;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                WeekGrid.DataSource = table;
                for (int j = 0; j <= WeekGrid.ColumnCount - 1; j++)
                    WeekGrid.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void oneMonthData()
        {
            try
            {
                var table = new DataTable();
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = Constants.MonthValuesQuery;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                MonthGrid.DataSource = table;
                for (int j = 0; j <= MonthGrid.ColumnCount - 1; j++)
                    MonthGrid.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

    }
}
