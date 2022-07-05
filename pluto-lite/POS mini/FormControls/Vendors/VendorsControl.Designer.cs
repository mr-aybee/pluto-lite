namespace POS_mini.FormControls.Vendors
{
    partial class VendorsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsControl));
            this.VendorsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.vEmailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.vPhoneTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.vNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vComapnyNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.vSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RefreshGridBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorsGrid
            // 
            this.VendorsGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VendorsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VendorsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VendorsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VendorsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendorsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VendorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Type,
            this.AlertLevel,
            this.Column4,
            this.Column2});
            this.VendorsGrid.DoubleBuffered = true;
            this.VendorsGrid.EnableHeadersVisualStyles = false;
            this.VendorsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.VendorsGrid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.VendorsGrid.Location = new System.Drawing.Point(298, 118);
            this.VendorsGrid.Name = "VendorsGrid";
            this.VendorsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendorsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VendorsGrid.RowHeadersWidth = 5;
            this.VendorsGrid.Size = new System.Drawing.Size(662, 351);
            this.VendorsGrid.TabIndex = 30;
            this.VendorsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendorsGrid_CellContentClick);
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
            this.Type.HeaderText = "Email";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // AlertLevel
            // 
            this.AlertLevel.HeaderText = "Phone";
            this.AlertLevel.Name = "AlertLevel";
            this.AlertLevel.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Company Name";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ActiveBorderThickness = 1;
            this.UpdateBtn.ActiveCornerRadius = 20;
            this.UpdateBtn.ActiveFillColor = System.Drawing.Color.White;
            this.UpdateBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.ButtonText = "Update";
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.White;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.Location = new System.Drawing.Point(411, 494);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 50);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.ActiveBorderThickness = 1;
            this.addBtn.ActiveCornerRadius = 20;
            this.addBtn.ActiveFillColor = System.Drawing.Color.White;
            this.addBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.ButtonText = "Add";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleCornerRadius = 20;
            this.addBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addBtn.IdleForecolor = System.Drawing.Color.White;
            this.addBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addBtn.Location = new System.Drawing.Point(222, 494);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 50);
            this.addBtn.TabIndex = 6;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // vEmailTxt
            // 
            this.vEmailTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vEmailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vEmailTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vEmailTxt.BorderThickness = 3;
            this.vEmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vEmailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vEmailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vEmailTxt.isPassword = false;
            this.vEmailTxt.Location = new System.Drawing.Point(43, 315);
            this.vEmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.vEmailTxt.Name = "vEmailTxt";
            this.vEmailTxt.Size = new System.Drawing.Size(214, 40);
            this.vEmailTxt.TabIndex = 4;
            this.vEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // vPhoneTxt
            // 
            this.vPhoneTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vPhoneTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vPhoneTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vPhoneTxt.BorderThickness = 3;
            this.vPhoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vPhoneTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vPhoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vPhoneTxt.isPassword = false;
            this.vPhoneTxt.Location = new System.Drawing.Point(43, 240);
            this.vPhoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.vPhoneTxt.Name = "vPhoneTxt";
            this.vPhoneTxt.Size = new System.Drawing.Size(214, 40);
            this.vPhoneTxt.TabIndex = 3;
            this.vPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // vNameTxt
            // 
            this.vNameTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vNameTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vNameTxt.BorderThickness = 3;
            this.vNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vNameTxt.isPassword = false;
            this.vNameTxt.Location = new System.Drawing.Point(41, 166);
            this.vNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.vNameTxt.Name = "vNameTxt";
            this.vNameTxt.Size = new System.Drawing.Size(214, 40);
            this.vNameTxt.TabIndex = 2;
            this.vNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vendor";
            // 
            // vComapnyNameTxt
            // 
            this.vComapnyNameTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vComapnyNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vComapnyNameTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.vComapnyNameTxt.BorderThickness = 3;
            this.vComapnyNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vComapnyNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vComapnyNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vComapnyNameTxt.isPassword = false;
            this.vComapnyNameTxt.Location = new System.Drawing.Point(43, 390);
            this.vComapnyNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.vComapnyNameTxt.Name = "vComapnyNameTxt";
            this.vComapnyNameTxt.Size = new System.Drawing.Size(214, 40);
            this.vComapnyNameTxt.TabIndex = 5;
            this.vComapnyNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Comapny Name";
            // 
            // vSearchTxt
            // 
            this.vSearchTxt.BackColor = System.Drawing.SystemColors.Control;
            this.vSearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vSearchTxt.BackgroundImage")));
            this.vSearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vSearchTxt.ForeColor = System.Drawing.Color.Black;
            this.vSearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("vSearchTxt.Icon")));
            this.vSearchTxt.Location = new System.Drawing.Point(784, 82);
            this.vSearchTxt.Name = "vSearchTxt";
            this.vSearchTxt.Size = new System.Drawing.Size(176, 30);
            this.vSearchTxt.TabIndex = 9;
            this.vSearchTxt.text = "";
            this.vSearchTxt.OnTextChange += new System.EventHandler(this.vSearchTxt_OnTextChange);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.Crimson;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Location = new System.Drawing.Point(547, 494);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 50);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.RefreshGridBtn.Location = new System.Drawing.Point(298, 70);
            this.RefreshGridBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshGridBtn.Name = "RefreshGridBtn";
            this.RefreshGridBtn.Size = new System.Drawing.Size(106, 42);
            this.RefreshGridBtn.TabIndex = 8;
            this.RefreshGridBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshGridBtn.Click += new System.EventHandler(this.RefreshGridBtn_Click);
            // 
            // VendorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.RefreshGridBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.vSearchTxt);
            this.Controls.Add(this.vComapnyNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VendorsGrid);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.vEmailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vPhoneTxt);
            this.Controls.Add(this.vNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "VendorsControl";
            this.Size = new System.Drawing.Size(1056, 580);
            ((System.ComponentModel.ISupportInitialize)(this.VendorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid VendorsGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox vEmailTxt;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox vPhoneTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox vNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox vComapnyNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private Bunifu.Framework.UI.BunifuTextbox vSearchTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshGridBtn;
    }
}
