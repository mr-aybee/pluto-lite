namespace POS_mini.FormControls.SettingsControls
{
    partial class SettingsHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsHome));
            this.NavBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.billSettingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingBackupBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pBackWorker = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavBar.BackgroundImage")));
            this.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NavBar.Controls.Add(this.menuPanel);
            this.NavBar.Controls.Add(this.bunifuFlatButton1);
            this.NavBar.Controls.Add(this.billSettingsBtn);
            this.NavBar.Controls.Add(this.settingUserBtn);
            this.NavBar.Controls.Add(this.settingBackupBtn);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Quality = 10;
            this.NavBar.Size = new System.Drawing.Size(834, 43);
            this.NavBar.TabIndex = 3;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Dev Only";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(531, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(167, 43);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Dev Only";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Location = new System.Drawing.Point(4, 38);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(175, 5);
            this.menuPanel.TabIndex = 3;
            // 
            // billSettingsBtn
            // 
            this.billSettingsBtn.Activecolor = System.Drawing.Color.Transparent;
            this.billSettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.billSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.billSettingsBtn.BorderRadius = 0;
            this.billSettingsBtn.ButtonText = "Bill Settings";
            this.billSettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billSettingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.billSettingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.billSettingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("billSettingsBtn.Iconimage")));
            this.billSettingsBtn.Iconimage_right = null;
            this.billSettingsBtn.Iconimage_right_Selected = null;
            this.billSettingsBtn.Iconimage_Selected = null;
            this.billSettingsBtn.IconMarginLeft = 0;
            this.billSettingsBtn.IconMarginRight = 0;
            this.billSettingsBtn.IconRightVisible = true;
            this.billSettingsBtn.IconRightZoom = 0D;
            this.billSettingsBtn.IconVisible = true;
            this.billSettingsBtn.IconZoom = 60D;
            this.billSettingsBtn.IsTab = false;
            this.billSettingsBtn.Location = new System.Drawing.Point(358, 0);
            this.billSettingsBtn.Name = "billSettingsBtn";
            this.billSettingsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.billSettingsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.billSettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.billSettingsBtn.selected = false;
            this.billSettingsBtn.Size = new System.Drawing.Size(167, 43);
            this.billSettingsBtn.TabIndex = 4;
            this.billSettingsBtn.Text = "Bill Settings";
            this.billSettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billSettingsBtn.Textcolor = System.Drawing.Color.White;
            this.billSettingsBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billSettingsBtn.Click += new System.EventHandler(this.billSettingsBtn_Click);
            // 
            // settingUserBtn
            // 
            this.settingUserBtn.Activecolor = System.Drawing.Color.Transparent;
            this.settingUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingUserBtn.BorderRadius = 0;
            this.settingUserBtn.ButtonText = " Users";
            this.settingUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingUserBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingUserBtn.Iconimage")));
            this.settingUserBtn.Iconimage_right = null;
            this.settingUserBtn.Iconimage_right_Selected = null;
            this.settingUserBtn.Iconimage_Selected = null;
            this.settingUserBtn.IconMarginLeft = 0;
            this.settingUserBtn.IconMarginRight = 0;
            this.settingUserBtn.IconRightVisible = true;
            this.settingUserBtn.IconRightZoom = 0D;
            this.settingUserBtn.IconVisible = true;
            this.settingUserBtn.IconZoom = 60D;
            this.settingUserBtn.IsTab = false;
            this.settingUserBtn.Location = new System.Drawing.Point(2, 0);
            this.settingUserBtn.Name = "settingUserBtn";
            this.settingUserBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.settingUserBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.settingUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingUserBtn.selected = false;
            this.settingUserBtn.Size = new System.Drawing.Size(167, 43);
            this.settingUserBtn.TabIndex = 0;
            this.settingUserBtn.Text = " Users";
            this.settingUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingUserBtn.Textcolor = System.Drawing.Color.White;
            this.settingUserBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingUserBtn.Click += new System.EventHandler(this.settingUserBtn_Click);
            // 
            // settingBackupBtn
            // 
            this.settingBackupBtn.Activecolor = System.Drawing.Color.Transparent;
            this.settingBackupBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBackupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBackupBtn.BorderRadius = 0;
            this.settingBackupBtn.ButtonText = " Backups";
            this.settingBackupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBackupBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingBackupBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingBackupBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingBackupBtn.Iconimage")));
            this.settingBackupBtn.Iconimage_right = null;
            this.settingBackupBtn.Iconimage_right_Selected = null;
            this.settingBackupBtn.Iconimage_Selected = null;
            this.settingBackupBtn.IconMarginLeft = 0;
            this.settingBackupBtn.IconMarginRight = 0;
            this.settingBackupBtn.IconRightVisible = true;
            this.settingBackupBtn.IconRightZoom = 0D;
            this.settingBackupBtn.IconVisible = true;
            this.settingBackupBtn.IconZoom = 60D;
            this.settingBackupBtn.IsTab = false;
            this.settingBackupBtn.Location = new System.Drawing.Point(185, 0);
            this.settingBackupBtn.Name = "settingBackupBtn";
            this.settingBackupBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.settingBackupBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.settingBackupBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingBackupBtn.selected = false;
            this.settingBackupBtn.Size = new System.Drawing.Size(167, 43);
            this.settingBackupBtn.TabIndex = 1;
            this.settingBackupBtn.Text = " Backups";
            this.settingBackupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBackupBtn.Textcolor = System.Drawing.Color.White;
            this.settingBackupBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBackupBtn.Click += new System.EventHandler(this.settingBackupBtn_Click);
            // 
            // pBackWorker
            // 
            this.pBackWorker.AutoScroll = true;
            this.pBackWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBackWorker.Location = new System.Drawing.Point(0, 43);
            this.pBackWorker.Name = "pBackWorker";
            this.pBackWorker.Size = new System.Drawing.Size(834, 569);
            this.pBackWorker.TabIndex = 4;
            // 
            // SettingsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBackWorker);
            this.Controls.Add(this.NavBar);
            this.Name = "SettingsHome";
            this.Size = new System.Drawing.Size(834, 612);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel NavBar;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton settingUserBtn;
        private Bunifu.Framework.UI.BunifuFlatButton settingBackupBtn;
        private System.Windows.Forms.Panel pBackWorker;
        private Bunifu.Framework.UI.BunifuFlatButton billSettingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
