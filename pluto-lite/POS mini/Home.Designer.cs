namespace POS_mini
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.sideOption = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.InvoicesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.titleImage2 = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.titleImage1 = new System.Windows.Forms.PictureBox();
            this.vendorsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.makeSaleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.meuBtn = new System.Windows.Forms.PictureBox();
            this.TitleBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.MaxMinBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.workSpacePanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meuBtn)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.LogoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation2;
            this.LogoAnimator.MaxAnimationTime = 1000;
            this.LogoAnimator.TimeStep = 0.05F;
            // 
            // SideBar
            // 
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.sideOption);
            this.SideBar.Controls.Add(this.InvoicesBtn);
            this.SideBar.Controls.Add(this.titleImage2);
            this.SideBar.Controls.Add(this.dashboardBtn);
            this.SideBar.Controls.Add(this.settingBtn);
            this.SideBar.Controls.Add(this.titleImage1);
            this.SideBar.Controls.Add(this.vendorsBtn);
            this.SideBar.Controls.Add(this.customersBtn);
            this.SideBar.Controls.Add(this.productsBtn);
            this.SideBar.Controls.Add(this.makeSaleBtn);
            this.SideBar.Controls.Add(this.meuBtn);
            this.LogoAnimator.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(113)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.SideBar.Location = new System.Drawing.Point(0, 27);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(201, 598);
            this.SideBar.TabIndex = 1;
            // 
            // sideOption
            // 
            this.sideOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sideOption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideOption.BackgroundImage")));
            this.sideOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoAnimator.SetDecoration(this.sideOption, BunifuAnimatorNS.DecorationType.None);
            this.sideOption.GradientBottomLeft = System.Drawing.Color.White;
            this.sideOption.GradientBottomRight = System.Drawing.Color.White;
            this.sideOption.GradientTopLeft = System.Drawing.Color.White;
            this.sideOption.GradientTopRight = System.Drawing.Color.White;
            this.sideOption.Location = new System.Drawing.Point(192, 158);
            this.sideOption.Name = "sideOption";
            this.sideOption.Quality = 10;
            this.sideOption.Size = new System.Drawing.Size(8, 48);
            this.sideOption.TabIndex = 2;
            // 
            // InvoicesBtn
            // 
            this.InvoicesBtn.Activecolor = System.Drawing.Color.Transparent;
            this.InvoicesBtn.BackColor = System.Drawing.Color.Transparent;
            this.InvoicesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InvoicesBtn.BorderRadius = 0;
            this.InvoicesBtn.ButtonText = "Invoices";
            this.InvoicesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.InvoicesBtn, BunifuAnimatorNS.DecorationType.None);
            this.InvoicesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.InvoicesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.InvoicesBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("InvoicesBtn.Iconimage")));
            this.InvoicesBtn.Iconimage_right = null;
            this.InvoicesBtn.Iconimage_right_Selected = null;
            this.InvoicesBtn.Iconimage_Selected = null;
            this.InvoicesBtn.IconMarginLeft = 0;
            this.InvoicesBtn.IconMarginRight = 0;
            this.InvoicesBtn.IconRightVisible = true;
            this.InvoicesBtn.IconRightZoom = 0D;
            this.InvoicesBtn.IconVisible = true;
            this.InvoicesBtn.IconZoom = 60D;
            this.InvoicesBtn.IsTab = false;
            this.InvoicesBtn.Location = new System.Drawing.Point(0, 404);
            this.InvoicesBtn.Name = "InvoicesBtn";
            this.InvoicesBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.InvoicesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.InvoicesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.InvoicesBtn.selected = false;
            this.InvoicesBtn.Size = new System.Drawing.Size(200, 48);
            this.InvoicesBtn.TabIndex = 16;
            this.InvoicesBtn.Text = "Invoices";
            this.InvoicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvoicesBtn.Textcolor = System.Drawing.Color.White;
            this.InvoicesBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicesBtn.Click += new System.EventHandler(this.InvoicesBtn_Click);
            // 
            // titleImage2
            // 
            this.titleImage2.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.titleImage2, BunifuAnimatorNS.DecorationType.None);
            this.titleImage2.Image = global::POS_mini.Properties.Resources.plutoWhiteLogo;
            this.titleImage2.Location = new System.Drawing.Point(1, 54);
            this.titleImage2.Name = "titleImage2";
            this.titleImage2.Size = new System.Drawing.Size(46, 51);
            this.titleImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleImage2.TabIndex = 13;
            this.titleImage2.TabStop = false;
            this.titleImage2.Visible = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Activecolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.ButtonText = "Dashboard";
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.dashboardBtn, BunifuAnimatorNS.DecorationType.None);
            this.dashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Iconimage")));
            this.dashboardBtn.Iconimage_right = null;
            this.dashboardBtn.Iconimage_right_Selected = null;
            this.dashboardBtn.Iconimage_Selected = null;
            this.dashboardBtn.IconMarginLeft = 0;
            this.dashboardBtn.IconMarginRight = 0;
            this.dashboardBtn.IconRightVisible = true;
            this.dashboardBtn.IconRightZoom = 0D;
            this.dashboardBtn.IconVisible = true;
            this.dashboardBtn.IconZoom = 60D;
            this.dashboardBtn.IsTab = false;
            this.dashboardBtn.Location = new System.Drawing.Point(1, 158);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.dashboardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboardBtn.selected = false;
            this.dashboardBtn.Size = new System.Drawing.Size(200, 48);
            this.dashboardBtn.TabIndex = 15;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardBtn.Textcolor = System.Drawing.Color.White;
            this.dashboardBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Activecolor = System.Drawing.Color.Transparent;
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.BorderRadius = 0;
            this.settingBtn.ButtonText = "Settings";
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.settingBtn, BunifuAnimatorNS.DecorationType.None);
            this.settingBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingBtn.Iconimage")));
            this.settingBtn.Iconimage_right = null;
            this.settingBtn.Iconimage_right_Selected = null;
            this.settingBtn.Iconimage_Selected = null;
            this.settingBtn.IconMarginLeft = 0;
            this.settingBtn.IconMarginRight = 0;
            this.settingBtn.IconRightVisible = true;
            this.settingBtn.IconRightZoom = 0D;
            this.settingBtn.IconVisible = true;
            this.settingBtn.IconZoom = 60D;
            this.settingBtn.IsTab = false;
            this.settingBtn.Location = new System.Drawing.Point(0, 455);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.settingBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.settingBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingBtn.selected = false;
            this.settingBtn.Size = new System.Drawing.Size(200, 48);
            this.settingBtn.TabIndex = 14;
            this.settingBtn.Text = "Settings";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingBtn.Textcolor = System.Drawing.Color.White;
            this.settingBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // titleImage1
            // 
            this.titleImage1.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.titleImage1, BunifuAnimatorNS.DecorationType.None);
            this.titleImage1.Image = global::POS_mini.Properties.Resources.plutoWhiteLogo;
            this.titleImage1.Location = new System.Drawing.Point(41, 37);
            this.titleImage1.Name = "titleImage1";
            this.titleImage1.Size = new System.Drawing.Size(115, 101);
            this.titleImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleImage1.TabIndex = 5;
            this.titleImage1.TabStop = false;
            // 
            // vendorsBtn
            // 
            this.vendorsBtn.Activecolor = System.Drawing.Color.Transparent;
            this.vendorsBtn.BackColor = System.Drawing.Color.Transparent;
            this.vendorsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vendorsBtn.BorderRadius = 0;
            this.vendorsBtn.ButtonText = "Vendors";
            this.vendorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.vendorsBtn, BunifuAnimatorNS.DecorationType.None);
            this.vendorsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.vendorsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vendorsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("vendorsBtn.Iconimage")));
            this.vendorsBtn.Iconimage_right = null;
            this.vendorsBtn.Iconimage_right_Selected = null;
            this.vendorsBtn.Iconimage_Selected = null;
            this.vendorsBtn.IconMarginLeft = 0;
            this.vendorsBtn.IconMarginRight = 0;
            this.vendorsBtn.IconRightVisible = true;
            this.vendorsBtn.IconRightZoom = 0D;
            this.vendorsBtn.IconVisible = true;
            this.vendorsBtn.IconZoom = 60D;
            this.vendorsBtn.IsTab = false;
            this.vendorsBtn.Location = new System.Drawing.Point(0, 354);
            this.vendorsBtn.Name = "vendorsBtn";
            this.vendorsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.vendorsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.vendorsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vendorsBtn.selected = false;
            this.vendorsBtn.Size = new System.Drawing.Size(200, 48);
            this.vendorsBtn.TabIndex = 11;
            this.vendorsBtn.Text = "Vendors";
            this.vendorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vendorsBtn.Textcolor = System.Drawing.Color.White;
            this.vendorsBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsBtn.Click += new System.EventHandler(this.vendorsBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Activecolor = System.Drawing.Color.Transparent;
            this.customersBtn.BackColor = System.Drawing.Color.Transparent;
            this.customersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customersBtn.BorderRadius = 0;
            this.customersBtn.ButtonText = "Customers";
            this.customersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.customersBtn, BunifuAnimatorNS.DecorationType.None);
            this.customersBtn.DisabledColor = System.Drawing.Color.Gray;
            this.customersBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.customersBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("customersBtn.Iconimage")));
            this.customersBtn.Iconimage_right = null;
            this.customersBtn.Iconimage_right_Selected = null;
            this.customersBtn.Iconimage_Selected = null;
            this.customersBtn.IconMarginLeft = 0;
            this.customersBtn.IconMarginRight = 0;
            this.customersBtn.IconRightVisible = true;
            this.customersBtn.IconRightZoom = 0D;
            this.customersBtn.IconVisible = true;
            this.customersBtn.IconZoom = 60D;
            this.customersBtn.IsTab = false;
            this.customersBtn.Location = new System.Drawing.Point(0, 305);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.customersBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.customersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.customersBtn.selected = false;
            this.customersBtn.Size = new System.Drawing.Size(200, 48);
            this.customersBtn.TabIndex = 10;
            this.customersBtn.Text = "Customers";
            this.customersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customersBtn.Textcolor = System.Drawing.Color.White;
            this.customersBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Activecolor = System.Drawing.Color.Transparent;
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productsBtn.BorderRadius = 0;
            this.productsBtn.ButtonText = "Products";
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.productsBtn, BunifuAnimatorNS.DecorationType.None);
            this.productsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.productsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.productsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("productsBtn.Iconimage")));
            this.productsBtn.Iconimage_right = null;
            this.productsBtn.Iconimage_right_Selected = null;
            this.productsBtn.Iconimage_Selected = null;
            this.productsBtn.IconMarginLeft = 0;
            this.productsBtn.IconMarginRight = 0;
            this.productsBtn.IconRightVisible = true;
            this.productsBtn.IconRightZoom = 0D;
            this.productsBtn.IconVisible = true;
            this.productsBtn.IconZoom = 60D;
            this.productsBtn.IsTab = false;
            this.productsBtn.Location = new System.Drawing.Point(-1, 253);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.productsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.productsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.productsBtn.selected = false;
            this.productsBtn.Size = new System.Drawing.Size(200, 48);
            this.productsBtn.TabIndex = 9;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productsBtn.Textcolor = System.Drawing.Color.White;
            this.productsBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // makeSaleBtn
            // 
            this.makeSaleBtn.Activecolor = System.Drawing.Color.Transparent;
            this.makeSaleBtn.BackColor = System.Drawing.Color.Transparent;
            this.makeSaleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeSaleBtn.BorderRadius = 0;
            this.makeSaleBtn.ButtonText = "Make Sale";
            this.makeSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.makeSaleBtn, BunifuAnimatorNS.DecorationType.None);
            this.makeSaleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.makeSaleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.makeSaleBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("makeSaleBtn.Iconimage")));
            this.makeSaleBtn.Iconimage_right = null;
            this.makeSaleBtn.Iconimage_right_Selected = null;
            this.makeSaleBtn.Iconimage_Selected = null;
            this.makeSaleBtn.IconMarginLeft = 0;
            this.makeSaleBtn.IconMarginRight = 0;
            this.makeSaleBtn.IconRightVisible = true;
            this.makeSaleBtn.IconRightZoom = 0D;
            this.makeSaleBtn.IconVisible = true;
            this.makeSaleBtn.IconZoom = 60D;
            this.makeSaleBtn.IsTab = false;
            this.makeSaleBtn.Location = new System.Drawing.Point(0, 206);
            this.makeSaleBtn.Name = "makeSaleBtn";
            this.makeSaleBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.makeSaleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.makeSaleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.makeSaleBtn.selected = false;
            this.makeSaleBtn.Size = new System.Drawing.Size(200, 48);
            this.makeSaleBtn.TabIndex = 8;
            this.makeSaleBtn.Text = "Make Sale";
            this.makeSaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makeSaleBtn.Textcolor = System.Drawing.Color.White;
            this.makeSaleBtn.TextFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeSaleBtn.Click += new System.EventHandler(this.makeSaleBtn_Click);
            // 
            // meuBtn
            // 
            this.meuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meuBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.meuBtn, BunifuAnimatorNS.DecorationType.None);
            this.meuBtn.Image = ((System.Drawing.Image)(resources.GetObject("meuBtn.Image")));
            this.meuBtn.Location = new System.Drawing.Point(155, 6);
            this.meuBtn.Name = "meuBtn";
            this.meuBtn.Size = new System.Drawing.Size(42, 32);
            this.meuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meuBtn.TabIndex = 6;
            this.meuBtn.TabStop = false;
            this.meuBtn.Click += new System.EventHandler(this.meuBtn_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar.Controls.Add(this.pictureBox4);
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Controls.Add(this.minimizeBtn);
            this.TitleBar.Controls.Add(this.MaxMinBtn);
            this.TitleBar.Controls.Add(this.ExitBtn);
            this.LogoAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.TitleBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.TitleBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.TitleBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Quality = 10;
            this.TitleBar.Size = new System.Drawing.Size(1044, 27);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::POS_mini.Properties.Resources.plutoWhiteLogo;
            this.pictureBox4.Location = new System.Drawing.Point(4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pluto Lite";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizeBtn.Image = global::POS_mini.Properties.Resources.minScreen;
            this.minimizeBtn.Location = new System.Drawing.Point(956, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(26, 24);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // MaxMinBtn
            // 
            this.MaxMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.MaxMinBtn, BunifuAnimatorNS.DecorationType.None);
            this.MaxMinBtn.Image = global::POS_mini.Properties.Resources.maxScreen;
            this.MaxMinBtn.Location = new System.Drawing.Point(984, 2);
            this.MaxMinBtn.Name = "MaxMinBtn";
            this.MaxMinBtn.Size = new System.Drawing.Size(25, 21);
            this.MaxMinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxMinBtn.TabIndex = 2;
            this.MaxMinBtn.TabStop = false;
            this.MaxMinBtn.Click += new System.EventHandler(this.MaxMinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1013, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(27, 20);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // workSpacePanel
            // 
            this.LogoAnimator.SetDecoration(this.workSpacePanel, BunifuAnimatorNS.DecorationType.None);
            this.workSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workSpacePanel.Location = new System.Drawing.Point(201, 27);
            this.workSpacePanel.Name = "workSpacePanel";
            this.workSpacePanel.Size = new System.Drawing.Size(843, 598);
            this.workSpacePanel.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 625);
            this.Controls.Add(this.workSpacePanel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBar);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meuBtn)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel TitleBar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox MaxMinBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private System.Windows.Forms.PictureBox meuBtn;
        private System.Windows.Forms.PictureBox titleImage1;
        private Bunifu.Framework.UI.BunifuFlatButton makeSaleBtn;
        private Bunifu.Framework.UI.BunifuFlatButton vendorsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton customersBtn;
        private Bunifu.Framework.UI.BunifuFlatButton productsBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel sideOption;
        private System.Windows.Forms.PictureBox titleImage2;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton settingBtn;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardBtn;
        private System.Windows.Forms.Panel workSpacePanel;
        private Bunifu.Framework.UI.BunifuFlatButton InvoicesBtn;
    }
}