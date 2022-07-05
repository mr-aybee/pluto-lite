using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace POS_mini
{
    public partial class Login : Form
    {
        List<Models.User> Users = new List<Models.User>();
        public Login()
        {
            InitializeComponent();
            try
            {
                if (!System.IO.File.Exists(App_Code.Constants.DBPath))
                {
                    System.IO.File.WriteAllBytes(App_Code.Constants.DBPath, Properties.Resources.DB);
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.Users.Add(new Models.User
                        {
                            DateTime = DateTime.Now,
                            Name = "Admin",
                            Password = "123",
                            Phone = "03222228324",
                            Rank = "admin",
                            Username = "admin",
                            ExpiryDate = DateTime.Now.AddDays(300)
                        });
                        db.Customers.Add(new Models.Customer
                        {
                            Name = "Walk In Customer",
                            Email = "donotremove@data.com",
                            Phone = "03244600333"
                        });
                        ImageConverter converter = new ImageConverter();
                        var cImage = (byte[])converter.ConvertTo(Properties.Resources.plutoLogo, typeof(byte[]));
                        File.WriteAllBytes(Constants.cLogoImage, cImage);
                        db.PlutoSettings.Add(new Models.PlutoSettings
                        {
                            ComapnySaleNote = "Testing",
                            CompanyAddress = "Ashiana Tower 12 A",
                            CompanyName = "Pluto Lite",
                            CompanyPhone = "03222228324",
                            CompanyPhone2 = "03244600333"
                        });
                        db.SaveChanges();
                    }
                }
                bunifuThinButton21.BackColor = Color.Transparent;
                bunifuThinButton21.Width -= 1;
                CopyrightTxt.Text = "© " + DateTime.Now.Year.ToString();
                Users = App_Code.DBCache.User;


            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openWeb();
        }

        private void CopyrightTxt_Click(object sender, EventArgs e)
        {
            openWeb();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openWeb();
        }

        public static void openWeb()
        {
            System.Diagnostics.Process.Start("https://abmalik.com");
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            login();
        }

        void login()
        {
            try
            {
                if (!File.Exists("EntityFramework.DbConnnection.db"))
                    File.WriteAllText("EntityFramework.DbConnnection.db", DateTime.Now.AddDays(10).ToString() + "|" + DateTime.Now.AddDays(10).ToString());
                var dtCheck = DateTime.Parse(File.ReadAllText("EntityFramework.DbConnnection.db").Split('|')[0]);
                if (dtCheck < DateTime.Now)
                {
                    Alert.Show("This POS is expired. Contact your service provider at info@abmalik.co", Alert.alertType.error);
                }
                else
                {

                    var pass = passTxt.text.Replace("\r", "").Replace("\n", "");
                    if (Users.Exists(X => X.Username == userTxt.text && X.Password == pass))
                    {
                        App_Code.Constants.WriteCookie(Users.Find(X => X.Username == userTxt.text && X.Password == pass).ID);
                        new Splash().Show(); this.Hide();
                        //Home h = new Home();
                        //h.Show();
                        //this.Hide();
                    }
                    else
                    {
                        Alert.Show("Incorrect Username or Password", Alert.alertType.warning);
                        userTxt.text = ""; passTxt.text = "";
                    }
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.error); }
        }

        private void passTxt_OnTextChange(object sender, EventArgs e)
        {
            if (passTxt.text.EndsWith("\n"))
            {
                login();
            }
        }
    }
}
