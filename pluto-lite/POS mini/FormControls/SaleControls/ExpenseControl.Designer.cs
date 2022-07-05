namespace POS_mini.FormControls.SaleControls
{
    partial class ExpenseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseControl));
            this.ExpenseGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RefreshGridBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.addCustomerBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.amountTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExpenseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpenseGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ExpenseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpenseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Amount,
            this.AlertLevel,
            this.Column2});
            this.ExpenseGrid.DoubleBuffered = true;
            this.ExpenseGrid.EnableHeadersVisualStyles = false;
            this.ExpenseGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.ExpenseGrid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.ExpenseGrid.Location = new System.Drawing.Point(332, 112);
            this.ExpenseGrid.Name = "ExpenseGrid";
            this.ExpenseGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ExpenseGrid.RowHeadersWidth = 5;
            this.ExpenseGrid.Size = new System.Drawing.Size(547, 351);
            this.ExpenseGrid.TabIndex = 33;
            this.ExpenseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseGrid_CellContentClick);
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
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // AlertLevel
            // 
            this.AlertLevel.HeaderText = "Date Time";
            this.AlertLevel.Name = "AlertLevel";
            this.AlertLevel.Width = 120;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date Time";
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
            this.descriptionTxt.Location = new System.Drawing.Point(28, 172);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(214, 92);
            this.descriptionTxt.TabIndex = 22;
            this.descriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "Expense";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 26);
            this.dateTimePicker1.TabIndex = 34;
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
            this.RefreshGridBtn.Location = new System.Drawing.Point(332, 64);
            this.RefreshGridBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshGridBtn.Name = "RefreshGridBtn";
            this.RefreshGridBtn.Size = new System.Drawing.Size(106, 42);
            this.RefreshGridBtn.TabIndex = 27;
            this.RefreshGridBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshGridBtn.Click += new System.EventHandler(this.RefreshGridBtn_Click);
            // 
            // cSearchTxt
            // 
            this.cSearchTxt.BackColor = System.Drawing.SystemColors.Control;
            this.cSearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cSearchTxt.BackgroundImage")));
            this.cSearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cSearchTxt.ForeColor = System.Drawing.Color.Black;
            this.cSearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("cSearchTxt.Icon")));
            this.cSearchTxt.Location = new System.Drawing.Point(692, 72);
            this.cSearchTxt.Name = "cSearchTxt";
            this.cSearchTxt.Size = new System.Drawing.Size(187, 34);
            this.cSearchTxt.TabIndex = 28;
            this.cSearchTxt.text = "";
            this.cSearchTxt.OnTextChange += new System.EventHandler(this.cSearchTxt_OnTextChange);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.ActiveBorderThickness = 1;
            this.addCustomerBtn.ActiveCornerRadius = 20;
            this.addCustomerBtn.ActiveFillColor = System.Drawing.Color.White;
            this.addCustomerBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addCustomerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCustomerBtn.BackgroundImage")));
            this.addCustomerBtn.ButtonText = "Add";
            this.addCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.addCustomerBtn.IdleBorderThickness = 1;
            this.addCustomerBtn.IdleCornerRadius = 20;
            this.addCustomerBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.IdleForecolor = System.Drawing.Color.White;
            this.addCustomerBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.Location = new System.Drawing.Point(298, 480);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(167, 50);
            this.addCustomerBtn.TabIndex = 25;
            this.addCustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // amountTxt
            // 
            this.amountTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.amountTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amountTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.amountTxt.BorderThickness = 3;
            this.amountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.amountTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amountTxt.isPassword = false;
            this.amountTxt.Location = new System.Drawing.Point(28, 296);
            this.amountTxt.Margin = new System.Windows.Forms.Padding(4);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(214, 34);
            this.amountTxt.TabIndex = 35;
            this.amountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox1_KeyPress);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Location = new System.Drawing.Point(30, 272);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(62, 20);
            this.labl.TabIndex = 36;
            this.labl.Text = "Amount";
            // 
            // ExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RefreshGridBtn);
            this.Controls.Add(this.cSearchTxt);
            this.Controls.Add(this.ExpenseGrid);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseControl";
            this.Size = new System.Drawing.Size(934, 588);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 RefreshGridBtn;
        private Bunifu.Framework.UI.BunifuTextbox cSearchTxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ExpenseGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 addCustomerBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox descriptionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertLevel;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private Bunifu.Framework.UI.BunifuMetroTextbox amountTxt;
        private System.Windows.Forms.Label labl;
    }
}
