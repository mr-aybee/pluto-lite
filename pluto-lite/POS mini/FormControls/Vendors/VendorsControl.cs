using POS_mini.App_Code;
using System;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.Vendors
{
    public partial class VendorsControl : UserControl
    {
        Models.Vendor Vendor { get; set; }
        public VendorsControl()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            Vendor = new Models.Vendor();


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (vNameTxt.Text == "" || vNameTxt.Text == "")
            {
                Alert.Show("Kindly Fill Name And Phone Number To Proceed", Alert.alertType.warning);
                return;
            }
            if (DBCache.Vendors.Exists(X => X.Name == vNameTxt.Text && X.Phone == vPhoneTxt.Text))
            {
                Alert.Show("Vendor Name and phone number Already Exists", Alert.alertType.warning);
                return;
            }
            Vendor = new Models.Vendor
            {
                CompanyName = vComapnyNameTxt.Text,
                Email = vEmailTxt.Text,
                Name = vNameTxt.Text,
                Phone = vPhoneTxt.Text
            };
            using (Models.DBEntities db = new Models.DBEntities())
            {
                db.Vendors.Add(Vendor); db.SaveChanges();
                Alert.Show("New Vendor Saved", Alert.alertType.success);
                Vendor = new Models.Vendor();
                Refresher();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Vendor == null)
            {
                Alert.Show("Kindly Select Any Vendor From Table", Alert.alertType.warning);
                return;
            }
            if (vNameTxt.Text == "")
            {
                Alert.Show("Vendor Name cannot be null", Alert.alertType.warning);
                return;
            }
            if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Update Vendor") == DialogResult.Yes)
            {
                Vendor.Name = vNameTxt.Text;
                Vendor.Phone = vPhoneTxt.Text;
                Vendor.Email = vEmailTxt.Text;
                Vendor.CompanyName = vComapnyNameTxt.Text;
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    db.Vendors.Attach(Vendor);
                    db.Entry(Vendor).State = System.Data.Entity.EntityState.Modified;
                    Alert.Show("Vendor Updated", Alert.alertType.success);
                    Refresher();
                }

            }
        }

        private void VendorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Vendor = DBCache.Vendors.Find(X => X.ID == int.Parse(VendorsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                vNameTxt.Text = Vendor.Name;
                vPhoneTxt.Text = Vendor.Phone;
                vEmailTxt.Text = Vendor.Email;
                vComapnyNameTxt.Text = Vendor.CompanyName;
            }
        }

        private void vSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            var t = vSearchTxt.text.ToLower();
            VendorsGrid.Rows.Clear();
            DBCache.Vendors.FindAll(X => X.Name.ToLower().Contains(t) || X.Phone.ToLower().Contains(t) || X.CompanyName.ToLower().Contains(t) || X.Email.ToLower().Contains(t))
                .ForEach(X =>
                {
                    VendorsGrid.Rows.Add(X.ID, X.Name, X.Email, X.Phone, X.CompanyName, "Edit");
                });
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Vendor == null)
                {
                    Alert.Show("Kindly Select Any Vendor From Table", Alert.alertType.warning);
                    return;
                }
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Delete Vendor And Its Data") == DialogResult.Yes)
                {
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.Vendors.Remove(db.Vendors.Where(X => X.ID == Vendor.ID).First());
                        DBCache.VendorAccounts.FindAll(X => X.VendorID == Vendor.ID).ForEach(X =>
                        {
                            db.VendorAccounts.Remove(db.VendorAccounts.Where(C => C.ID == X.ID).First());
                        });
                        DBCache.Invoices.FindAll(X => X.VendorID == Vendor.ID).ForEach(X =>
                        {
                            X.VendorID = 0;
                            db.Invoices.Attach(X);
                            db.Entry(X).State = System.Data.Entity.EntityState.Modified;
                        });
                        db.SaveChanges();
                        Alert.Show("Vendor And Its Data Deleted", Alert.alertType.success);
                    }

                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void RefreshGridBtn_Click(object sender, EventArgs e)
        {
            VendorsGrid.Rows.Clear();
            DBCache.Vendors.ForEach(X =>
            {
                VendorsGrid.Rows.Add(X.ID, X.Name, X.Email, X.Phone, X.CompanyName, "Edit");
            });
        }
    }
}
