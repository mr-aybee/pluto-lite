namespace POS_mini.FormControls.Vendors
{
    partial class VendorsHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsHome));
            this.NavBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.vpayRecordBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.vendorCBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vPayBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vPanelBack = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavBar.BackgroundImage")));
            this.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NavBar.Controls.Add(this.menuPanel);
            this.NavBar.Controls.Add(this.vpayRecordBtn);
            this.NavBar.Controls.Add(this.vendorCBtn);
            this.NavBar.Controls.Add(this.vPayBtn);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Quality = 10;
            this.NavBar.Size = new System.Drawing.Size(728, 43);
            this.NavBar.TabIndex = 1;
            // 
            // vpayRecordBtn
            // 
            this.vpayRecordBtn.Activecolor = System.Drawing.Color.Transparent;
            this.vpayRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.vpayRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vpayRecordBtn.BorderRadius = 0;
            this.vpayRecordBtn.ButtonText = "  Pay Record";
            this.vpayRecordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpayRecordBtn.DisabledColor = System.Drawing.Color.Gray;
            this.vpayRecordBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vpayRecordBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("vpayRecordBtn.Iconimage")));
            this.vpayRecordBtn.Iconimage_right = null;
            this.vpayRecordBtn.Iconimage_right_Selected = null;
            this.vpayRecordBtn.Iconimage_Selected = null;
            this.vpayRecordBtn.IconMarginLeft = 0;
            this.vpayRecordBtn.IconMarginRight = 0;
            this.vpayRecordBtn.IconRightVisible = true;
            this.vpayRecordBtn.IconRightZoom = 0D;
            this.vpayRecordBtn.IconVisible = true;
            this.vpayRecordBtn.IconZoom = 60D;
            this.vpayRecordBtn.IsTab = false;
            this.vpayRecordBtn.Location = new System.Drawing.Point(358, 0);
            this.vpayRecordBtn.Name = "vpayRecordBtn";
            this.vpayRecordBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.vpayRecordBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vpayRecordBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vpayRecordBtn.selected = false;
            this.vpayRecordBtn.Size = new System.Drawing.Size(167, 43);
            this.vpayRecordBtn.TabIndex = 4;
            this.vpayRecordBtn.Text = "  Pay Record";
            this.vpayRecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vpayRecordBtn.Textcolor = System.Drawing.Color.White;
            this.vpayRecordBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpayRecordBtn.Click += new System.EventHandler(this.VpayRecordBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Location = new System.Drawing.Point(0, 38);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(175, 5);
            this.menuPanel.TabIndex = 3;
            // 
            // vendorCBtn
            // 
            this.vendorCBtn.Activecolor = System.Drawing.Color.Transparent;
            this.vendorCBtn.BackColor = System.Drawing.Color.Transparent;
            this.vendorCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vendorCBtn.BorderRadius = 0;
            this.vendorCBtn.ButtonText = "  Vendors";
            this.vendorCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendorCBtn.DisabledColor = System.Drawing.Color.Gray;
            this.vendorCBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vendorCBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("vendorCBtn.Iconimage")));
            this.vendorCBtn.Iconimage_right = null;
            this.vendorCBtn.Iconimage_right_Selected = null;
            this.vendorCBtn.Iconimage_Selected = null;
            this.vendorCBtn.IconMarginLeft = 0;
            this.vendorCBtn.IconMarginRight = 0;
            this.vendorCBtn.IconRightVisible = true;
            this.vendorCBtn.IconRightZoom = 0D;
            this.vendorCBtn.IconVisible = true;
            this.vendorCBtn.IconZoom = 60D;
            this.vendorCBtn.IsTab = false;
            this.vendorCBtn.Location = new System.Drawing.Point(2, 0);
            this.vendorCBtn.Name = "vendorCBtn";
            this.vendorCBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.vendorCBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vendorCBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vendorCBtn.selected = false;
            this.vendorCBtn.Size = new System.Drawing.Size(167, 43);
            this.vendorCBtn.TabIndex = 0;
            this.vendorCBtn.Text = "  Vendors";
            this.vendorCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendorCBtn.Textcolor = System.Drawing.Color.White;
            this.vendorCBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorCBtn.Click += new System.EventHandler(this.vendorCBtn_Click);
            // 
            // vPayBtn
            // 
            this.vPayBtn.Activecolor = System.Drawing.Color.Transparent;
            this.vPayBtn.BackColor = System.Drawing.Color.Transparent;
            this.vPayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vPayBtn.BorderRadius = 0;
            this.vPayBtn.ButtonText = "  Vendor Pays";
            this.vPayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vPayBtn.DisabledColor = System.Drawing.Color.Gray;
            this.vPayBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vPayBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("vPayBtn.Iconimage")));
            this.vPayBtn.Iconimage_right = null;
            this.vPayBtn.Iconimage_right_Selected = null;
            this.vPayBtn.Iconimage_Selected = null;
            this.vPayBtn.IconMarginLeft = 0;
            this.vPayBtn.IconMarginRight = 0;
            this.vPayBtn.IconRightVisible = true;
            this.vPayBtn.IconRightZoom = 0D;
            this.vPayBtn.IconVisible = true;
            this.vPayBtn.IconZoom = 60D;
            this.vPayBtn.IsTab = false;
            this.vPayBtn.Location = new System.Drawing.Point(185, 0);
            this.vPayBtn.Name = "vPayBtn";
            this.vPayBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.vPayBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vPayBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vPayBtn.selected = false;
            this.vPayBtn.Size = new System.Drawing.Size(167, 43);
            this.vPayBtn.TabIndex = 1;
            this.vPayBtn.Text = "  Vendor Pays";
            this.vPayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vPayBtn.Textcolor = System.Drawing.Color.White;
            this.vPayBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPayBtn.Click += new System.EventHandler(this.vPayBtn_Click);
            // 
            // vPanelBack
            // 
            this.vPanelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vPanelBack.Location = new System.Drawing.Point(0, 43);
            this.vPanelBack.Name = "vPanelBack";
            this.vPanelBack.Size = new System.Drawing.Size(728, 501);
            this.vPanelBack.TabIndex = 2;
            // 
            // VendorsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vPanelBack);
            this.Controls.Add(this.NavBar);
            this.Name = "VendorsHome";
            this.Size = new System.Drawing.Size(728, 544);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel NavBar;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton vendorCBtn;
        private Bunifu.Framework.UI.BunifuFlatButton vPayBtn;
        private System.Windows.Forms.Panel vPanelBack;
        private Bunifu.Framework.UI.BunifuFlatButton vpayRecordBtn;
    }
}
