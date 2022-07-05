namespace POS_mini.FormControls.ProductControls
{
    partial class ProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodeImage = new System.Windows.Forms.PictureBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pSearchBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.pNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pAlertLevelTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pSalePriceTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pBarcodeTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pTypeCombo = new System.Windows.Forms.ComboBox();
            this.RefreshGridBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.fillGridProgress = new System.Windows.Forms.ProgressBar();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bunifuThinButton21 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descriptionTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUPCustomBarcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alert Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sale Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Barcode";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // barcodeImage
            // 
            this.barcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeImage.Location = new System.Drawing.Point(47, 455);
            this.barcodeImage.Name = "barcodeImage";
            this.barcodeImage.Size = new System.Drawing.Size(210, 39);
            this.barcodeImage.TabIndex = 11;
            this.barcodeImage.TabStop = false;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Type,
            this.AlertLevel,
            this.SalePrice,
            this.BarCode,
            this.Column2,
            this.Column4});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(293, 140);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(774, 420);
            this.bunifuCustomDataGrid1.TabIndex = 13;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.Width = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // AlertLevel
            // 
            this.AlertLevel.HeaderText = "Alert Level";
            this.AlertLevel.Name = "AlertLevel";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Sale Price";
            this.SalePrice.Name = "SalePrice";
            // 
            // BarCode
            // 
            this.BarCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BarCode.HeaderText = "Barcode";
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 89;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pSearchBox
            // 
            this.pSearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.pSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pSearchBox.BackgroundImage")));
            this.pSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSearchBox.ForeColor = System.Drawing.Color.Black;
            this.pSearchBox.Icon = ((System.Drawing.Image)(resources.GetObject("pSearchBox.Icon")));
            this.pSearchBox.Location = new System.Drawing.Point(875, 102);
            this.pSearchBox.Name = "pSearchBox";
            this.pSearchBox.Size = new System.Drawing.Size(192, 32);
            this.pSearchBox.TabIndex = 12;
            this.pSearchBox.text = "";
            this.pSearchBox.OnTextChange += new System.EventHandler(this.pSearchBox_OnTextChange);
            // 
            // pNameTxt
            // 
            this.pNameTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pNameTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pNameTxt.BorderThickness = 3;
            this.pNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pNameTxt.isPassword = false;
            this.pNameTxt.Location = new System.Drawing.Point(47, 153);
            this.pNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(214, 40);
            this.pNameTxt.TabIndex = 1;
            this.pNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pAlertLevelTxt
            // 
            this.pAlertLevelTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pAlertLevelTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pAlertLevelTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pAlertLevelTxt.BorderThickness = 3;
            this.pAlertLevelTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pAlertLevelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pAlertLevelTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pAlertLevelTxt.isPassword = false;
            this.pAlertLevelTxt.Location = new System.Drawing.Point(44, 280);
            this.pAlertLevelTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pAlertLevelTxt.Name = "pAlertLevelTxt";
            this.pAlertLevelTxt.Size = new System.Drawing.Size(214, 40);
            this.pAlertLevelTxt.TabIndex = 3;
            this.pAlertLevelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pAlertLevelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pAlertLevelTxt_KeyPress);
            // 
            // pSalePriceTxt
            // 
            this.pSalePriceTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pSalePriceTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pSalePriceTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pSalePriceTxt.BorderThickness = 3;
            this.pSalePriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pSalePriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pSalePriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pSalePriceTxt.isPassword = false;
            this.pSalePriceTxt.Location = new System.Drawing.Point(44, 344);
            this.pSalePriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pSalePriceTxt.Name = "pSalePriceTxt";
            this.pSalePriceTxt.Size = new System.Drawing.Size(214, 40);
            this.pSalePriceTxt.TabIndex = 4;
            this.pSalePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pSalePriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pSalePriceTxt_KeyPress);
            // 
            // pBarcodeTxt
            // 
            this.pBarcodeTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pBarcodeTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pBarcodeTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.pBarcodeTxt.BorderThickness = 3;
            this.pBarcodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pBarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pBarcodeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pBarcodeTxt.isPassword = false;
            this.pBarcodeTxt.Location = new System.Drawing.Point(45, 409);
            this.pBarcodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pBarcodeTxt.Name = "pBarcodeTxt";
            this.pBarcodeTxt.Size = new System.Drawing.Size(174, 43);
            this.pBarcodeTxt.TabIndex = 9;
            this.pBarcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pBarcodeTxt.OnValueChanged += new System.EventHandler(this.pBarcodeTxt_OnValueChanged);
            this.pBarcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pBarcodeTxt_KeyDown);
            // 
            // pTypeCombo
            // 
            this.pTypeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.pTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTypeCombo.ForeColor = System.Drawing.Color.White;
            this.pTypeCombo.FormattingEnabled = true;
            this.pTypeCombo.Location = new System.Drawing.Point(48, 220);
            this.pTypeCombo.Name = "pTypeCombo";
            this.pTypeCombo.Size = new System.Drawing.Size(210, 33);
            this.pTypeCombo.TabIndex = 2;
            // 
            // RefreshGridBtn
            // 
            this.RefreshGridBtn.ActiveBorderThickness = 1;
            this.RefreshGridBtn.ActiveCornerRadius = 20;
            this.RefreshGridBtn.ActiveFillColor = System.Drawing.Color.White;
            this.RefreshGridBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.RefreshGridBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.RefreshGridBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshGridBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshGridBtn.BackgroundImage")));
            this.RefreshGridBtn.ButtonText = "Refresh";
            this.RefreshGridBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshGridBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshGridBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshGridBtn.IdleBorderThickness = 1;
            this.RefreshGridBtn.IdleCornerRadius = 20;
            this.RefreshGridBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.RefreshGridBtn.IdleForecolor = System.Drawing.Color.White;
            this.RefreshGridBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.RefreshGridBtn.Location = new System.Drawing.Point(293, 92);
            this.RefreshGridBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshGridBtn.Name = "RefreshGridBtn";
            this.RefreshGridBtn.Size = new System.Drawing.Size(152, 42);
            this.RefreshGridBtn.TabIndex = 19;
            this.RefreshGridBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshGridBtn.Click += new System.EventHandler(this.RefreshGridBtn_Click);
            // 
            // fillGridProgress
            // 
            this.fillGridProgress.Location = new System.Drawing.Point(453, 102);
            this.fillGridProgress.Name = "fillGridProgress";
            this.fillGridProgress.Size = new System.Drawing.Size(160, 23);
            this.fillGridProgress.TabIndex = 20;
            this.fillGridProgress.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.FlatAppearance.BorderSize = 0;
            this.bunifuThinButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(431, 583);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(156, 42);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.Text = "Add";
            this.bunifuThinButton21.UseVisualStyleBackColor = false;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(607, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(732, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.descriptionTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.descriptionTxt.BorderThickness = 3;
            this.descriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.descriptionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTxt.isPassword = false;
            this.descriptionTxt.Location = new System.Drawing.Point(47, 521);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(210, 68);
            this.descriptionTxt.TabIndex = 7;
            this.descriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(217, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnUPCustomBarcode
            // 
            this.btnUPCustomBarcode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUPCustomBarcode.FlatAppearance.BorderSize = 0;
            this.btnUPCustomBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPCustomBarcode.ForeColor = System.Drawing.Color.White;
            this.btnUPCustomBarcode.Location = new System.Drawing.Point(217, 432);
            this.btnUPCustomBarcode.Name = "btnUPCustomBarcode";
            this.btnUPCustomBarcode.Size = new System.Drawing.Size(40, 20);
            this.btnUPCustomBarcode.TabIndex = 26;
            this.btnUPCustomBarcode.Text = "U P";
            this.btnUPCustomBarcode.UseVisualStyleBackColor = false;
            this.btnUPCustomBarcode.Click += new System.EventHandler(this.btnUPCustomBarcode_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnUPCustomBarcode);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.fillGridProgress);
            this.Controls.Add(this.RefreshGridBtn);
            this.Controls.Add(this.pTypeCombo);
            this.Controls.Add(this.pBarcodeTxt);
            this.Controls.Add(this.pSalePriceTxt);
            this.Controls.Add(this.pAlertLevelTxt);
            this.Controls.Add(this.pNameTxt);
            this.Controls.Add(this.pSearchBox);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.barcodeImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1093, 641);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox barcodeImage;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuTextbox pSearchBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox pNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox pAlertLevelTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox pSalePriceTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox pBarcodeTxt;
        private System.Windows.Forms.ComboBox pTypeCombo;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshGridBtn;
        private System.Windows.Forms.ProgressBar fillGridProgress;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button bunifuThinButton21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMetroTextbox descriptionTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUPCustomBarcode;
    }
}
