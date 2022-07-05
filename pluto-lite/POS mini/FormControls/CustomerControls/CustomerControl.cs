using POS_mini.App_Code;
using System;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.CustomerControls
{
    public partial class CustomerControl : UserControl
    {
        Models.Customer Customer { get; set; }
        Models.DBEntities db = new Models.DBEntities();
        public CustomerControl()
        {
            InitializeComponent();
        }

        public void Refresher()
        {
            try
            {
                Customer = new Models.Customer();
                cNameTxt.Text = "";
                cEmailTxt.Text = "";
                cPhoneTxt.Text = "";
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }


        private void RefreshGridBtn_Click(object sender, EventArgs e)
        {
            CustomersGrid.Rows.Clear();
            db.Customers.ToList().ForEach(X =>
            {
                CustomersGrid.Rows.Add(X.ID, X.Name, X.Email, X.Phone, "show");
            });
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cNameTxt.Text == "")
                {
                    Alert.Show("Please Enter Customer Name Must", Alert.alertType.warning); return;
                }
                var c = db.Customers.FirstOrDefault(X => X.Name == cNameTxt.Text);
                if (c != null)
                {
                    Alert.Show("Customer with same name Already Exists", Alert.alertType.warning); return;
                }
                Customer = new Models.Customer
                {
                    Email = cEmailTxt.Text,
                    Name = cNameTxt.Text,
                    Phone = cPhoneTxt.Text
                };
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    db.Customers.Add(Customer); db.SaveChanges();
                    Alert.Show(Customer.Name + " Saved", Alert.alertType.success);
                    Refresher();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Customer.Name == null)
                {
                    Alert.Show("Kindly Select Any Customer from Table", Alert.alertType.warning); return;
                }
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Update Customer") == DialogResult.Yes)
                {
                    Customer.Name = cNameTxt.Text;
                    Customer.Phone = cPhoneTxt.Text;
                    Customer.Email = cEmailTxt.Text;
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.Customers.Attach(Customer);
                        db.Entry(Customer).State = System.Data.Entity.EntityState.Modified;
                    }
                    Alert.Show("Customer Updated", Alert.alertType.success);
                    Refresher();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Customer = DBCache.Customers.Find(X => X.ID == int.Parse(CustomersGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    cNameTxt.Text = Customer.Name;
                    cPhoneTxt.Text = Customer.Phone;
                    cEmailTxt.Text = Customer.Email;
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void cSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                CustomersGrid.Rows.Clear();
                var t = cSearchTxt.text.ToLower();
                db.Customers.Where(X => X.Name.ToLower().Contains(t) || X.Phone.ToLower().Contains(t) || X.Email.ToLower().Contains(t))
                .ToList().ForEach(X =>
                {
                    CustomersGrid.Rows.Add(X.ID, X.Name, X.Email, X.Phone, "show");
                });
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Customer.Name == null)
                {
                    Alert.Show("Kindly Select Any Customer from Table", Alert.alertType.warning); return;
                }
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Delete Customer And Its Data") == DialogResult.Yes)
                {
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.Customers.Remove(db.Customers.Where(X => X.ID == Customer.ID).First());
                        var ca = DBCache.CustomerAccounts.FindAll(X => X.CustomerID == Customer.ID);
                        var sales = db.Sales.Where(X => X.CustomerID == Customer.ID).ToList();
                        ca.ForEach(X =>
                        {
                            db.CustomerAccounts.Remove(db.CustomerAccounts.FirstOrDefault(C => C.ID == X.ID));
                        });
                        sales.ForEach(X =>
                        {
                            X.isWalkInCustomer = true;
                            db.Sales.Attach(X);
                            db.Entry(X).State = System.Data.Entity.EntityState.Modified;
                        });
                        db.SaveChanges();
                    }
                    Alert.Show("Customer Deleted", Alert.alertType.success);
                    Refresher();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

    }
}
