namespace POS_mini.FormControls.SaleControls
{
    partial class SaleEditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleEditControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saleDetailPanel = new System.Windows.Forms.Panel();
            this.saleItemsGrid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.saleEditUpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.sdProductsCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpricewdTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sTypeTxt = new System.Windows.Forms.Label();
            this.sdCustomerTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.sdDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeleteSaleBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customersCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.saleDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsGrid)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saleDetailPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 494);
            this.panel2.TabIndex = 1;
            // 
            // saleDetailPanel
            // 
            this.saleDetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleDetailPanel.Controls.Add(this.saleItemsGrid);
            this.saleDetailPanel.Controls.Add(this.panel8);
            this.saleDetailPanel.Controls.Add(this.panel7);
            this.saleDetailPanel.Controls.Add(this.panel5);
            this.saleDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleDetailPanel.Location = new System.Drawing.Point(400, 0);
            this.saleDetailPanel.Name = "saleDetailPanel";
            this.saleDetailPanel.Size = new System.Drawing.Size(424, 494);
            this.saleDetailPanel.TabIndex = 1;
            this.saleDetailPanel.Visible = false;
            // 
            // saleItemsGrid
            // 
            this.saleItemsGrid.AllowUserToAddRows = false;
            this.saleItemsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.saleItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.saleItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleItemsGrid.Location = new System.Drawing.Point(0, 148);
            this.saleItemsGrid.Name = "saleItemsGrid";
            this.saleItemsGrid.RowHeadersVisible = false;
            this.saleItemsGrid.Size = new System.Drawing.Size(422, 194);
            this.saleItemsGrid.TabIndex = 6;
            this.saleItemsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleItemsGrid_CellContentClick);
            this.saleItemsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleItemsGrid_CellValueChanged);
            this.saleItemsGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SaleItemsGrid_EditingControlShowing);
            this.saleItemsGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaleItemsGrid_KeyPress);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Product";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Unit Price";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Discount";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Total";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 30F;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.saleEditUpdateBtn);
            this.panel8.Controls.Add(this.bunifuThinButton21);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.sdProductsCombo);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.tpricewdTxt);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 342);
            this.panel8.MaximumSize = new System.Drawing.Size(0, 150);
            this.panel8.MinimumSize = new System.Drawing.Size(0, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(422, 150);
            this.panel8.TabIndex = 8;
            // 
            // saleEditUpdateBtn
            // 
            this.saleEditUpdateBtn.ActiveBorderThickness = 1;
            this.saleEditUpdateBtn.ActiveCornerRadius = 20;
            this.saleEditUpdateBtn.ActiveFillColor = System.Drawing.Color.White;
            this.saleEditUpdateBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.saleEditUpdateBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.saleEditUpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saleEditUpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saleEditUpdateBtn.BackgroundImage")));
            this.saleEditUpdateBtn.ButtonText = "Update";
            this.saleEditUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleEditUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleEditUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.saleEditUpdateBtn.IdleBorderThickness = 1;
            this.saleEditUpdateBtn.IdleCornerRadius = 20;
            this.saleEditUpdateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.saleEditUpdateBtn.IdleForecolor = System.Drawing.Color.White;
            this.saleEditUpdateBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.saleEditUpdateBtn.Location = new System.Drawing.Point(278, 104);
            this.saleEditUpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saleEditUpdateBtn.Name = "saleEditUpdateBtn";
            this.saleEditUpdateBtn.Size = new System.Drawing.Size(127, 41);
            this.saleEditUpdateBtn.TabIndex = 19;
            this.saleEditUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saleEditUpdateBtn.Click += new System.EventHandler(this.SaleEditUpdateBtn_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(341, 11);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(63, 42);
            this.bunifuThinButton21.TabIndex = 17;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Product Name";
            // 
            // sdProductsCombo
            // 
            this.sdProductsCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.sdProductsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdProductsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sdProductsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdProductsCombo.ForeColor = System.Drawing.Color.White;
            this.sdProductsCombo.FormattingEnabled = true;
            this.sdProductsCombo.Location = new System.Drawing.Point(116, 17);
            this.sdProductsCombo.Name = "sdProductsCombo";
            this.sdProductsCombo.Size = new System.Drawing.Size(219, 33);
            this.sdProductsCombo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Price After Discount";
            // 
            // tpricewdTxt
            // 
            this.tpricewdTxt.BorderColorFocused = System.Drawing.Color.DimGray;
            this.tpricewdTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.tpricewdTxt.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.tpricewdTxt.BorderThickness = 3;
            this.tpricewdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tpricewdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tpricewdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpricewdTxt.isPassword = false;
            this.tpricewdTxt.Location = new System.Drawing.Point(225, 57);
            this.tpricewdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.tpricewdTxt.Name = "tpricewdTxt";
            this.tpricewdTxt.Size = new System.Drawing.Size(110, 38);
            this.tpricewdTxt.TabIndex = 5;
            this.tpricewdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.sTypeTxt);
            this.panel7.Controls.Add(this.sdCustomerTxt);
            this.panel7.Controls.Add(this.sdDate);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.sdTime);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.MaximumSize = new System.Drawing.Size(0, 104);
            this.panel7.MinimumSize = new System.Drawing.Size(0, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(422, 104);
            this.panel7.TabIndex = 5;
            // 
            // sTypeTxt
            // 
            this.sTypeTxt.AutoSize = true;
            this.sTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTypeTxt.Location = new System.Drawing.Point(47, 69);
            this.sTypeTxt.Name = "sTypeTxt";
            this.sTypeTxt.Size = new System.Drawing.Size(85, 18);
            this.sTypeTxt.TabIndex = 5;
            this.sTypeTxt.Text = "Sale Type : ";
            this.sTypeTxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sdCustomerTxt
            // 
            this.sdCustomerTxt.BorderColorFocused = System.Drawing.Color.DimGray;
            this.sdCustomerTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.sdCustomerTxt.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.sdCustomerTxt.BorderThickness = 3;
            this.sdCustomerTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sdCustomerTxt.Enabled = false;
            this.sdCustomerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sdCustomerTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sdCustomerTxt.isPassword = false;
            this.sdCustomerTxt.Location = new System.Drawing.Point(34, 26);
            this.sdCustomerTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sdCustomerTxt.Name = "sdCustomerTxt";
            this.sdCustomerTxt.Size = new System.Drawing.Size(357, 38);
            this.sdCustomerTxt.TabIndex = 1;
            this.sdCustomerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sdDate
            // 
            this.sdDate.AutoSize = true;
            this.sdDate.Location = new System.Drawing.Point(222, 87);
            this.sdDate.Name = "sdDate";
            this.sdDate.Size = new System.Drawing.Size(28, 13);
            this.sdDate.TabIndex = 4;
            this.sdDate.Text = "date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Customer Name";
            // 
            // sdTime
            // 
            this.sdTime.AutoSize = true;
            this.sdTime.Location = new System.Drawing.Point(222, 68);
            this.sdTime.Name = "sdTime";
            this.sdTime.Size = new System.Drawing.Size(26, 13);
            this.sdTime.TabIndex = 3;
            this.sdTime.Text = "time";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DeleteSaleBtn);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(422, 44);
            this.panel5.TabIndex = 0;
            // 
            // DeleteSaleBtn
            // 
            this.DeleteSaleBtn.ActiveBorderThickness = 1;
            this.DeleteSaleBtn.ActiveCornerRadius = 20;
            this.DeleteSaleBtn.ActiveFillColor = System.Drawing.Color.White;
            this.DeleteSaleBtn.ActiveForecolor = System.Drawing.Color.Crimson;
            this.DeleteSaleBtn.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DeleteSaleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteSaleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteSaleBtn.BackgroundImage")));
            this.DeleteSaleBtn.ButtonText = "Delete";
            this.DeleteSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSaleBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSaleBtn.IdleBorderThickness = 1;
            this.DeleteSaleBtn.IdleCornerRadius = 20;
            this.DeleteSaleBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.DeleteSaleBtn.IdleForecolor = System.Drawing.Color.White;
            this.DeleteSaleBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.DeleteSaleBtn.Location = new System.Drawing.Point(5, 3);
            this.DeleteSaleBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteSaleBtn.Name = "DeleteSaleBtn";
            this.DeleteSaleBtn.Size = new System.Drawing.Size(80, 36);
            this.DeleteSaleBtn.TabIndex = 17;
            this.DeleteSaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteSaleBtn.Click += new System.EventHandler(this.DeleteSaleBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sale Details";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(382, 0);
            this.panel6.MaximumSize = new System.Drawing.Size(40, 0);
            this.panel6.MinimumSize = new System.Drawing.Size(40, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 44);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(400, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 494);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(400, 394);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuThinButton22);
            this.panel4.Controls.Add(this.saleDateTimePicker);
            this.panel4.Controls.Add(this.customersCombo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 100);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 100);
            this.panel4.TabIndex = 0;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "WIC";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(331, 22);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(63, 42);
            this.bunifuThinButton22.TabIndex = 20;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.saleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saleDateTimePicker.Location = new System.Drawing.Point(134, 68);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(190, 26);
            this.saleDateTimePicker.TabIndex = 14;
            this.saleDateTimePicker.ValueChanged += new System.EventHandler(this.SaleDateTimePicker_ValueChanged);
            // 
            // customersCombo
            // 
            this.customersCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.customersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customersCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersCombo.ForeColor = System.Drawing.Color.White;
            this.customersCombo.FormattingEnabled = true;
            this.customersCombo.Location = new System.Drawing.Point(133, 26);
            this.customersCombo.Name = "customersCombo";
            this.customersCombo.Size = new System.Drawing.Size(191, 33);
            this.customersCombo.TabIndex = 13;
            this.customersCombo.SelectedIndexChanged += new System.EventHandler(this.CustomersCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By";
            // 
            // SaleEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SaleEditControl";
            this.Size = new System.Drawing.Size(824, 544);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.saleDetailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsGrid)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox customersCombo;
        private System.Windows.Forms.DateTimePicker saleDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Panel saleDetailPanel;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox sdCustomerTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sdDate;
        private System.Windows.Forms.Label sdTime;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteSaleBtn;
        private System.Windows.Forms.DataGridView saleItemsGrid;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sdProductsCombo;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox tpricewdTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 saleEditUpdateBtn;
        private System.Windows.Forms.Label sTypeTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}
