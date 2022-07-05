using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.CustomerControls
{
    public partial class CPayRecord : UserControl
    {
        List<Models.Customer> Customers { get; set; }
        List<Models.CustomerAccount> CustomerAccounts { get; set; }
        Models.DBEntities db = new Models.DBEntities();
        public CPayRecord()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            Customers = DBCache.Customers;
            customerDropDown.Items.Clear();
            Customers.OrderBy(X => X.Name).ToList().ForEach(X => { customerDropDown.Items.Add(X.Name); });
        }

        private void CustomerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Customer C = db.Customers.FirstOrDefault(X => X.Name == customerDropDown.Text);
            FillGrid(C);

        }

        private void FillGrid(Models.Customer C)
        {
            customersGrid.Rows.Clear();
            db.CustomerAccounts.Where(X => X.CustomerID == C.ID).ToList().ForEach(X =>
            {
                customersGrid.Rows.Add(X.ID, C.Name, Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString(), X.Amount, X.TransactionType, "Delete");
            });
        }

        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Delete Customer Pay") == DialogResult.Yes)
                {
                    var cid = int.Parse(customersGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    db.CustomerAccounts.Remove(db.CustomerAccounts.Where(X => X.ID == cid).First());
                    db.SaveChanges();
                    Alert.Show("Customer Pay Deleted", Alert.alertType.success);
                }
            }
        }
    }
}
