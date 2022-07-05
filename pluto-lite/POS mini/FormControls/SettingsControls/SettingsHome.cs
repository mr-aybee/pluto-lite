using System;
using System.IO;
using System.Windows.Forms;

namespace POS_mini.FormControls.SettingsControls
{
    public partial class SettingsHome : UserControl
    {
        
        public SettingsHome()
        {
            InitializeComponent();
            if (File.Exists(App_Code.Constants.UserSession))
            {
                if (App_Code.DBCache.User.Find(X => X.ID == App_Code.Constants.UserID).Rank == "user")
                {
                    var SBRC = new SettingsBackupAndRestoreControl();
                    settingUserBtn.Hide();
                    billSettingsBtn.Hide();
                    menuPanel.Left = settingBackupBtn.Left;
                    menuPanel.Width = settingBackupBtn.Width;
                    this.pBackWorker.Controls.Clear();
                    this.pBackWorker.Controls.Add(SBRC);
                    SBRC.Refresher();
                    SBRC.Dock = DockStyle.Fill;
                    return;
                }

            }
            SettingsUsersControl SUC = new SettingsUsersControl();
            menuPanel.Left = settingUserBtn.Left;
            menuPanel.Width = settingUserBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SUC);
            SUC.Refresher();
            SUC.Dock = DockStyle.Fill;
        }

        private void settingUserBtn_Click(object sender, EventArgs e)
        {
            SettingsUsersControl SUC = new SettingsUsersControl();
            menuPanel.Left = settingUserBtn.Left;
            menuPanel.Width = settingUserBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SUC);
            SUC.Refresher();
            SUC.Dock = DockStyle.Fill;
        }

        private void settingBackupBtn_Click(object sender, EventArgs e)
        {
            SettingsBackupAndRestoreControl SBRC = new SettingsBackupAndRestoreControl();
            menuPanel.Left = settingBackupBtn.Left;
            menuPanel.Width = settingBackupBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SBRC);
            SBRC.Refresher();
            SBRC.Dock = DockStyle.Fill;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SettingsUpdateControl SUC = new SettingsUpdateControl();
            menuPanel.Left = bunifuFlatButton1.Left;
            menuPanel.Width = bunifuFlatButton1.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SUC);
            //SUC.Refresher();
            SUC.Dock = DockStyle.Fill;

        }

        private void billSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsBillControl SBC = new SettingsBillControl();
            menuPanel.Left = billSettingsBtn.Left;
            menuPanel.Width = billSettingsBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SBC);
            SBC.Refresher();
            SBC.Dock = DockStyle.Fill;
            
        }
    }
}
