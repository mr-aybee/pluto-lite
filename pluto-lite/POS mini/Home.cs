using POS_mini.FormControls.CustomerControls;
using POS_mini.FormControls.DashboardSettings;
using POS_mini.FormControls.InvoiceControls;
using POS_mini.FormControls.ProductControls;
using POS_mini.FormControls.SaleControls;
using POS_mini.FormControls.SettingsControls;
using POS_mini.FormControls.Vendors;
using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace POS_mini
{
    public partial class Home : Form
    {



        public Home()
        {


            InitializeComponent();

            //App_Code.WinAPI.AnimateWindow(this.Handle, 200, App_Code.WinAPI.HOR_Positive);
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
            sideOption.Top = dashboardBtn.Top;
            this.workSpacePanel.Controls.Clear();
            DashboardControl DC = new DashboardControl();
            this.workSpacePanel.Controls.Add(DC);
            DC.Dock = DockStyle.Fill;
            DC.Refresher();
            if (File.Exists(App_Code.Constants.UserSession))
            {
                if (App_Code.DBCache.User.Find(X => X.ID == App_Code.Constants.UserID).Rank == "user")
                {
                    productsBtn.Hide();
                    vendorsBtn.Hide();
                    InvoicesBtn.Hide();
                    //settingBtn.Hide();
                    customersBtn.Hide();
                }
            }
            //new System.Threading.Thread(new System.Threading.ThreadStart(delegate
            //{


            //    try
            //    {
            //        string boardNumber = "";
            //        try
            //        {
            //            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Product, SerialNumber FROM Win32_BaseBoard");
            //            ManagementObjectCollection information = searcher.Get();
            //            foreach (ManagementObject obj in information)
            //            {
            //                foreach (PropertyData data in obj.Properties)
            //                    boardNumber += data.Name + data.Value;
            //            }
            //            searcher.Dispose();
            //        }
            //        catch { return; }

            //        if (File.Exists("SystemDataFile.txt"))
            //        {
            //            var a = File.ReadAllText("SystemDataFile.txt");
            //            if (boardNumber != a)
            //            {
            //                Alert.Show("Contact Developer", Alert.alertType.error);
            //                Invoke(new Action(delegate { this.Close(); }));
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            File.WriteAllText("SystemDataFile.txt", boardNumber);
            //            Alert.Show("Welcome To Pluto Lite", Alert.alertType.success);
            //        }
            //    }
            //    catch { }


            //})).Start();
        }

        //App Exit Controllers
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        // Size Cotrollers
        private void MaxMinBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                MaxMinBtn.Image = Properties.Resources.maxScreen;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                MaxMinBtn.Image = Properties.Resources.normalScreen;
            }
        }
        private void TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                MaxMinBtn.Image = Properties.Resources.maxScreen;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                MaxMinBtn.Image = Properties.Resources.normalScreen;
            }

        }

        //App Minimize Controller
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Side Bar Controller
        private void meuBtn_Click(object sender, EventArgs e)
        {
            if (SideBar.Width < 100)
            {
                //SideBar.Hide();
                titleImage2.Hide();
                SideBar.Width = 201;
                titleImage1.Show();
                titleImage1.Image = Properties.Resources.plutoWhiteLogo;
                //LogoAnimator.ShowSync(SideBar);
            }
            else if (SideBar.Width > 100)
            {
                //SideBar.Hide();
                titleImage1.Hide();
                SideBar.Width = 50;
                titleImage2.Show();
                titleImage2.Image = Properties.Resources.plutoWhiteLogo;
                //LogoAnimator.ShowSync(SideBar);
            }
        }



        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsHome PH = new ProductsHome();
            sideOption.Top = productsBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(PH);
            PH.Dock = DockStyle.Fill;
            
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            CustomerHome CH = new CustomerHome();
            sideOption.Top = customersBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(CH);
            CH.Dock = DockStyle.Fill;
            
        }

        private void vendorsBtn_Click(object sender, EventArgs e)
        {
            VendorsHome VH = new VendorsHome();
            sideOption.Top = vendorsBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(VH);
            VH.Dock = DockStyle.Fill;
            //VC.Refresher();

        }

        private void makeSaleBtn_Click(object sender, EventArgs e)
        {
            SaleHome SH = new SaleHome();
            sideOption.Top = makeSaleBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(SH);
            SH.Dock = DockStyle.Fill;

        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            InvoiceHome IH = new InvoiceHome();
            sideOption.Top = InvoicesBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(IH);
            //VC.Refresher();
            IH.Dock = DockStyle.Fill;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            SettingsHome SeH = new SettingsHome();
            sideOption.Top = settingBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(SeH);
            SeH.Dock = DockStyle.Fill;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardControl DC = new DashboardControl();
            sideOption.Top = dashboardBtn.Top;
            this.workSpacePanel.Controls.Clear();
            this.workSpacePanel.Controls.Add(DC);
            DC.Dock = DockStyle.Fill;
            DC.Refresher();
        }
    }
}
