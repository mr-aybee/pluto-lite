namespace POS_mini.FormControls.CustomerControls
{
    partial class CustomerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            this.label1 = new System.Windows.Forms.Label();
            this.cPhoneTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cEmailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomersGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addCustomerBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cSearchTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RefreshGridBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // cPhoneTxt
            // 
            this.cPhoneTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cPhoneTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPhoneTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cPhoneTxt.BorderThickness = 3;
            this.cPhoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cPhoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPhoneTxt.isPassword = false;
            this.cPhoneTxt.Location = new System.Drawing.Point(82, 249);
            this.cPhoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cPhoneTxt.Name = "cPhoneTxt";
            this.cPhoneTxt.Size = new System.Drawing.Size(214, 40);
            this.cPhoneTxt.TabIndex = 3;
            this.cPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cNameTxt
            // 
            this.cNameTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cNameTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cNameTxt.BorderThickness = 3;
            this.cNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cNameTxt.isPassword = false;
            this.cNameTxt.Location = new System.Drawing.Point(80, 175);
            this.cNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cNameTxt.Name = "cNameTxt";
            this.cNameTxt.Size = new System.Drawing.Size(214, 40);
            this.cNameTxt.TabIndex = 2;
            this.cNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // cEmailTxt
            // 
            this.cEmailTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cEmailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cEmailTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.cEmailTxt.BorderThickness = 3;
            this.cEmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cEmailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cEmailTxt.isPassword = false;
            this.cEmailTxt.Location = new System.Drawing.Point(82, 324);
            this.cEmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cEmailTxt.Name = "cEmailTxt";
            this.cEmailTxt.Size = new System.Drawing.Size(214, 40);
            this.cEmailTxt.TabIndex = 4;
            this.cEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // CustomersGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CustomersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Type,
            this.AlertLevel,
            this.Column2});
            this.CustomersGrid.DoubleBuffered = true;
            this.CustomersGrid.EnableHeadersVisualStyles = false;
            this.CustomersGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.CustomersGrid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.CustomersGrid.Location = new System.Drawing.Point(384, 115);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersGrid.RowHeadersWidth = 5;
            this.CustomersGrid.Size = new System.Drawing.Size(547, 351);
            this.CustomersGrid.TabIndex = 20;
            this.CustomersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGrid_CellContentClick);
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
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.White;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            this.UpdateBtn.Location = new System.Drawing.Point(447, 474);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 50);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
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
            this.addCustomerBtn.Location = new System.Drawing.Point(260, 474);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(167, 50);
            this.addCustomerBtn.TabIndex = 5;
            this.addCustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // cSearchTxt
            // 
            this.cSearchTxt.BackColor = System.Drawing.SystemColors.Control;
            this.cSearchTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cSearchTxt.BackgroundImage")));
            this.cSearchTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cSearchTxt.ForeColor = System.Drawing.Color.Black;
            this.cSearchTxt.Icon = ((System.Drawing.Image)(resources.GetObject("cSearchTxt.Icon")));
            this.cSearchTxt.Location = new System.Drawing.Point(744, 75);
            this.cSearchTxt.Name = "cSearchTxt";
            this.cSearchTxt.Size = new System.Drawing.Size(187, 34);
            this.cSearchTxt.TabIndex = 8;
            this.cSearchTxt.text = "";
            this.cSearchTxt.OnTextChange += new System.EventHandler(this.cSearchTxt_OnTextChange);
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
            this.DeleteBtn.Location = new System.Drawing.Point(589, 474);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 50);
            this.DeleteBtn.TabIndex = 9;
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
            this.RefreshGridBtn.Location = new System.Drawing.Point(384, 67);
            this.RefreshGridBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshGridBtn.Name = "RefreshGridBtn";
            this.RefreshGridBtn.Size = new System.Drawing.Size(106, 42);
            this.RefreshGridBtn.TabIndex = 7;
            this.RefreshGridBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshGridBtn.Click += new System.EventHandler(this.RefreshGridBtn_Click);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.RefreshGridBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.cSearchTxt);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.cEmailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cPhoneTxt);
            this.Controls.Add(this.cNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(960, 564);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox cPhoneTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox cNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox cEmailTxt;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addCustomerBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid CustomersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertLevel;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private Bunifu.Framework.UI.BunifuTextbox cSearchTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshGridBtn;
    }
}
