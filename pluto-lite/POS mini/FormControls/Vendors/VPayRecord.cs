using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.Vendors
{
    public partial class VPayRecord : UserControl
    {
        List<Models.Vendor> Vendors { get; set; }
        List<Models.VendorAccount> VendorAccounts { get; set; }
        public VPayRecord()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            VendorAccounts = DBCache.VendorAccounts;
            Vendors = DBCache.Vendors;
            vendorDropDown.Items.Clear();
            Vendors.OrderBy(X => X.Name).ToList().ForEach(X =>
            {
                vendorDropDown.Items.Add(X.Name);
            });

        }

        private void VendorDropDown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Models.Vendor V = Vendors.Find(X => X.Name == vendorDropDown.Text);
            FillGrid(V);
        }


        private void FillGrid(Models.Vendor V)
        {
            VendorsGrid.Rows.Clear();
            var va = VendorAccounts.FindAll(X => X.VendorID == V.ID);
            va.ForEach(X =>
            {
                VendorsGrid.Rows.Add(X.ID, V.Name, Convert.ToDateTime(X.DateTime).ToShortDateString(), Convert.ToDateTime(X.DateTime).ToShortTimeString(), X.Amount, X.TransactionType, "Remove");
            });
        }

        private void VendorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Delete") == DialogResult.Yes)
                {
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        var vid = int.Parse(VendorsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        Models.VendorAccount vaSelected = db.VendorAccounts.Where(X => X.ID == vid).First();
                        db.VendorAccounts.Remove(vaSelected);
                        db.SaveChanges();
                        Alert.Show("Vendor Pay Deleted", Alert.alertType.success);
                        Refresher();
                    }
                }
            }
        }

        private void VendorDropDown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Models.Vendor V = Vendors.Find(X => X.Name == vendorDropDown.Text);
            FillGrid(V);
        }
    }
}
