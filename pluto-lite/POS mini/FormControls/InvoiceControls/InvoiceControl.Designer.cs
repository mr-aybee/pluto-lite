namespace POS_mini.FormControls.InvoiceControls
{
    partial class InvoiceControl
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
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iPurchaseTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iQuantityTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cashPaidTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tPriceTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashReturnTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iSaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.vendorNameCombo = new System.Windows.Forms.ComboBox();
            this.productsCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.S,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(37, 170);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 10;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(645, 337);
            this.bunifuCustomDataGrid1.TabIndex = 9;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // S
            // 
            this.S.HeaderText = "Serial";
            this.S.Name = "S";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Purchase Price Unit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 20;
            // 
            // iPurchaseTxt
            // 
            this.iPurchaseTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iPurchaseTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iPurchaseTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iPurchaseTxt.BorderThickness = 3;
            this.iPurchaseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iPurchaseTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.iPurchaseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iPurchaseTxt.isPassword = false;
            this.iPurchaseTxt.Location = new System.Drawing.Point(404, 120);
            this.iPurchaseTxt.Margin = new System.Windows.Forms.Padding(4);
            this.iPurchaseTxt.Name = "iPurchaseTxt";
            this.iPurchaseTxt.Size = new System.Drawing.Size(162, 44);
            this.iPurchaseTxt.TabIndex = 7;
            this.iPurchaseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.iPurchaseTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iPurchaseTxt_KeyPress);
            // 
            // iQuantityTxt
            // 
            this.iQuantityTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iQuantityTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iQuantityTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iQuantityTxt.BorderThickness = 3;
            this.iQuantityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iQuantityTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.iQuantityTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iQuantityTxt.isPassword = false;
            this.iQuantityTxt.Location = new System.Drawing.Point(237, 119);
            this.iQuantityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.iQuantityTxt.Name = "iQuantityTxt";
            this.iQuantityTxt.Size = new System.Drawing.Size(157, 44);
            this.iQuantityTxt.TabIndex = 6;
            this.iQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.iQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iPurchaseTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Purchase Price Per Unit";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(573, 120);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(109, 44);
            this.addProductBtn.TabIndex = 8;
            this.addProductBtn.Text = "Add In List";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "Invoice";
            // 
            // cashPaidTxt
            // 
            this.cashPaidTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashPaidTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashPaidTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashPaidTxt.BorderThickness = 3;
            this.cashPaidTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cashPaidTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cashPaidTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashPaidTxt.isPassword = false;
            this.cashPaidTxt.Location = new System.Drawing.Point(739, 287);
            this.cashPaidTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cashPaidTxt.Name = "cashPaidTxt";
            this.cashPaidTxt.Size = new System.Drawing.Size(127, 50);
            this.cashPaidTxt.TabIndex = 12;
            this.cashPaidTxt.Text = "0";
            this.cashPaidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cashPaidTxt.OnValueChanged += new System.EventHandler(this.cashPaidTxt_OnValueChanged);
            this.cashPaidTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iPurchaseTxt_KeyPress);
            // 
            // tPriceTxt
            // 
            this.tPriceTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.tPriceTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.tPriceTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.tPriceTxt.BorderThickness = 3;
            this.tPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tPriceTxt.Enabled = false;
            this.tPriceTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tPriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tPriceTxt.isPassword = false;
            this.tPriceTxt.Location = new System.Drawing.Point(739, 203);
            this.tPriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.tPriceTxt.Name = "tPriceTxt";
            this.tPriceTxt.Size = new System.Drawing.Size(127, 50);
            this.tPriceTxt.TabIndex = 11;
            this.tPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tPriceTxt.OnValueChanged += new System.EventHandler(this.tPriceTxt_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Paid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Payment Return";
            // 
            // cashReturnTxt
            // 
            this.cashReturnTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashReturnTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashReturnTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cashReturnTxt.BorderThickness = 3;
            this.cashReturnTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cashReturnTxt.Enabled = false;
            this.cashReturnTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cashReturnTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashReturnTxt.isPassword = false;
            this.cashReturnTxt.Location = new System.Drawing.Point(739, 369);
            this.cashReturnTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cashReturnTxt.Name = "cashReturnTxt";
            this.cashReturnTxt.Size = new System.Drawing.Size(127, 50);
            this.cashReturnTxt.TabIndex = 13;
            this.cashReturnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // iSaveBtn
            // 
            this.iSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.iSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iSaveBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSaveBtn.ForeColor = System.Drawing.Color.White;
            this.iSaveBtn.Location = new System.Drawing.Point(739, 440);
            this.iSaveBtn.Name = "iSaveBtn";
            this.iSaveBtn.Size = new System.Drawing.Size(127, 49);
            this.iSaveBtn.TabIndex = 14;
            this.iSaveBtn.Text = "Save";
            this.iSaveBtn.UseVisualStyleBackColor = false;
            this.iSaveBtn.Click += new System.EventHandler(this.iSaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(720, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vendor Name";
            // 
            // vendorNameCombo
            // 
            this.vendorNameCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vendorNameCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vendorNameCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameCombo.ForeColor = System.Drawing.Color.White;
            this.vendorNameCombo.FormattingEnabled = true;
            this.vendorNameCombo.Location = new System.Drawing.Point(724, 131);
            this.vendorNameCombo.Name = "vendorNameCombo";
            this.vendorNameCombo.Size = new System.Drawing.Size(142, 33);
            this.vendorNameCombo.TabIndex = 20;
            // 
            // productsCombo
            // 
            this.productsCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.productsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsCombo.ForeColor = System.Drawing.Color.White;
            this.productsCombo.FormattingEnabled = true;
            this.productsCombo.Location = new System.Drawing.Point(37, 125);
            this.productsCombo.Name = "productsCombo";
            this.productsCombo.Size = new System.Drawing.Size(171, 33);
            this.productsCombo.TabIndex = 21;
            // 
            // InvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.productsCombo);
            this.Controls.Add(this.vendorNameCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iSaveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cashReturnTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tPriceTxt);
            this.Controls.Add(this.cashPaidTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iQuantityTxt);
            this.Controls.Add(this.iPurchaseTxt);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.DoubleBuffered = true;
            this.Name = "InvoiceControl";
            this.Size = new System.Drawing.Size(902, 593);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMetroTextbox iPurchaseTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox iQuantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox cashPaidTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox tPriceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox cashReturnTxt;
        private System.Windows.Forms.Button iSaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.ComboBox vendorNameCombo;
        private System.Windows.Forms.ComboBox productsCombo;
    }
}
