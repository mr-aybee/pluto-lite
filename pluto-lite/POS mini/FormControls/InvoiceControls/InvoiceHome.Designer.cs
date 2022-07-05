namespace POS_mini.FormControls.InvoiceControls
{
    partial class InvoiceHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceHome));
            this.NavBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ircBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.invoiceCBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customerPBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pDashBoardPanel = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavBar.BackgroundImage")));
            this.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NavBar.Controls.Add(this.menuPanel);
            this.NavBar.Controls.Add(this.ircBtn);
            this.NavBar.Controls.Add(this.invoiceCBtn);
            this.NavBar.Controls.Add(this.customerPBtn);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.NavBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Quality = 10;
            this.NavBar.Size = new System.Drawing.Size(831, 43);
            this.NavBar.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.Location = new System.Drawing.Point(0, 33);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(168, 10);
            this.menuPanel.TabIndex = 3;
            // 
            // ircBtn
            // 
            this.ircBtn.Activecolor = System.Drawing.Color.Transparent;
            this.ircBtn.BackColor = System.Drawing.Color.Transparent;
            this.ircBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ircBtn.BorderRadius = 0;
            this.ircBtn.ButtonText = " Invoice Reports";
            this.ircBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ircBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ircBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ircBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ircBtn.Iconimage")));
            this.ircBtn.Iconimage_right = null;
            this.ircBtn.Iconimage_right_Selected = null;
            this.ircBtn.Iconimage_Selected = null;
            this.ircBtn.IconMarginLeft = 0;
            this.ircBtn.IconMarginRight = 0;
            this.ircBtn.IconRightVisible = true;
            this.ircBtn.IconRightZoom = 0D;
            this.ircBtn.IconVisible = true;
            this.ircBtn.IconZoom = 60D;
            this.ircBtn.IsTab = false;
            this.ircBtn.Location = new System.Drawing.Point(354, 0);
            this.ircBtn.Name = "ircBtn";
            this.ircBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.ircBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.ircBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ircBtn.selected = false;
            this.ircBtn.Size = new System.Drawing.Size(167, 43);
            this.ircBtn.TabIndex = 4;
            this.ircBtn.Text = " Invoice Reports";
            this.ircBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ircBtn.Textcolor = System.Drawing.Color.White;
            this.ircBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ircBtn.Click += new System.EventHandler(this.ircBtn_Click);
            // 
            // invoiceCBtn
            // 
            this.invoiceCBtn.Activecolor = System.Drawing.Color.Transparent;
            this.invoiceCBtn.BackColor = System.Drawing.Color.Transparent;
            this.invoiceCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invoiceCBtn.BorderRadius = 0;
            this.invoiceCBtn.ButtonText = " Make Invoice";
            this.invoiceCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoiceCBtn.DisabledColor = System.Drawing.Color.Gray;
            this.invoiceCBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.invoiceCBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("invoiceCBtn.Iconimage")));
            this.invoiceCBtn.Iconimage_right = null;
            this.invoiceCBtn.Iconimage_right_Selected = null;
            this.invoiceCBtn.Iconimage_Selected = null;
            this.invoiceCBtn.IconMarginLeft = 0;
            this.invoiceCBtn.IconMarginRight = 0;
            this.invoiceCBtn.IconRightVisible = true;
            this.invoiceCBtn.IconRightZoom = 0D;
            this.invoiceCBtn.IconVisible = true;
            this.invoiceCBtn.IconZoom = 60D;
            this.invoiceCBtn.IsTab = false;
            this.invoiceCBtn.Location = new System.Drawing.Point(1, 0);
            this.invoiceCBtn.Name = "invoiceCBtn";
            this.invoiceCBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.invoiceCBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.invoiceCBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.invoiceCBtn.selected = false;
            this.invoiceCBtn.Size = new System.Drawing.Size(167, 43);
            this.invoiceCBtn.TabIndex = 0;
            this.invoiceCBtn.Text = " Make Invoice";
            this.invoiceCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoiceCBtn.Textcolor = System.Drawing.Color.White;
            this.invoiceCBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCBtn.Click += new System.EventHandler(this.customerCBtn_Click);
            // 
            // customerPBtn
            // 
            this.customerPBtn.Activecolor = System.Drawing.Color.Transparent;
            this.customerPBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerPBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerPBtn.BorderRadius = 0;
            this.customerPBtn.ButtonText = " View Invoices";
            this.customerPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerPBtn.DisabledColor = System.Drawing.Color.Gray;
            this.customerPBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.customerPBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("customerPBtn.Iconimage")));
            this.customerPBtn.Iconimage_right = null;
            this.customerPBtn.Iconimage_right_Selected = null;
            this.customerPBtn.Iconimage_Selected = null;
            this.customerPBtn.IconMarginLeft = 0;
            this.customerPBtn.IconMarginRight = 0;
            this.customerPBtn.IconRightVisible = true;
            this.customerPBtn.IconRightZoom = 0D;
            this.customerPBtn.IconVisible = true;
            this.customerPBtn.IconZoom = 60D;
            this.customerPBtn.IsTab = false;
            this.customerPBtn.Location = new System.Drawing.Point(181, 0);
            this.customerPBtn.Name = "customerPBtn";
            this.customerPBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.customerPBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.customerPBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.customerPBtn.selected = false;
            this.customerPBtn.Size = new System.Drawing.Size(167, 43);
            this.customerPBtn.TabIndex = 1;
            this.customerPBtn.Text = " View Invoices";
            this.customerPBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerPBtn.Textcolor = System.Drawing.Color.White;
            this.customerPBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPBtn.Click += new System.EventHandler(this.customerPBtn_Click);
            // 
            // pDashBoardPanel
            // 
            this.pDashBoardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pDashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDashBoardPanel.Location = new System.Drawing.Point(0, 43);
            this.pDashBoardPanel.Name = "pDashBoardPanel";
            this.pDashBoardPanel.Size = new System.Drawing.Size(831, 516);
            this.pDashBoardPanel.TabIndex = 4;
            // 
            // InvoiceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pDashBoardPanel);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.Name = "InvoiceHome";
            this.Size = new System.Drawing.Size(831, 559);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel NavBar;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton invoiceCBtn;
        private Bunifu.Framework.UI.BunifuFlatButton customerPBtn;
        private System.Windows.Forms.Panel pDashBoardPanel;
        private Bunifu.Framework.UI.BunifuFlatButton ircBtn;
    }
}
