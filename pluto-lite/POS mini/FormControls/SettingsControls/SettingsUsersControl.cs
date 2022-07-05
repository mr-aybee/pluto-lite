using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.SettingsControls
{
    public partial class SettingsUsersControl : UserControl
    {
        List<Models.User> Users = new List<Models.User>();
        Models.User u = new Models.User();
        public SettingsUsersControl()
        {
            InitializeComponent();
            Refresher();
        }

        public void Refresher()
        {
            u = new Models.User();
            Users = DBCache.User;
            uNameTxt.Text = "";
            uPhoneTxt.Text = "";
            uUsernameTxt.Text = "";
            uPasswordTxt.Text = "";
            CustomersGrid.Rows.Clear();
            Users.ForEach(X =>
            {
                CustomersGrid.Rows.Add(X.ID, X.Name, X.Username, X.Phone, X.Rank, "Edit");
            });
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (uNameTxt.Text == "" || uUsernameTxt.Text == "" || uPasswordTxt.Text == "" || uPhoneTxt.Text == "" || pTypeCombo.SelectedIndex < 0)
            {
                Alert.Show("Kindly Fill All Input Fiels", Alert.alertType.warning); return;
            }
            Models.User u = new Models.User
            {
                DateTime = DateTime.Now,
                Name = uNameTxt.Text,
                Password = uPasswordTxt.Text,
                Phone = uPhoneTxt.Text,
                Rank = pTypeCombo.Text,
                Username = uUsernameTxt.Text,
                ExpiryDate = DateTime.Now.AddMonths(6)
            };
            using (Models.DBEntities db = new Models.DBEntities())
            {
                db.Users.Add(u);
                db.SaveChanges();



                Alert.Show("New user Saved", Alert.alertType.success);
                Refresher();
            }
        }

        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    u = DBCache.User.Find(X => X.ID == int.Parse(CustomersGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (u == null) { Alert.Show("Kindly Select Any User First", Alert.alertType.warning); return; }
                    uNameTxt.Text = u.Name;
                    uPhoneTxt.Text = u.Phone;
                    uUsernameTxt.Text = u.Username;
                    uPasswordTxt.Text = u.Password;

                }
            }
            catch { }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (u == null) { Alert.Show("Kindly Select Any User First", Alert.alertType.warning); return; }
            u.Name = uNameTxt.Text;
            u.Phone = uPhoneTxt.Text;
            u.Username = uUsernameTxt.Text;
            u.Password = uPasswordTxt.Text;
            using (Models.DBEntities db = new Models.DBEntities())
            {
                db.Users.Attach(u);
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Alert.Show("User Updated", Alert.alertType.success);
                Refresher();
            }

        }
    }
}
