namespace POS_mini.FormControls.Vendors
{
    partial class VendorPayControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorPayControl));
            this.addCustomerBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.labl91 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.debitCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.creditCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rOrPTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CashPaymenttxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cPayTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vendorDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.addCustomerBtn.ButtonText = "Proceed";
            this.addCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.addCustomerBtn.IdleBorderThickness = 1;
            this.addCustomerBtn.IdleCornerRadius = 20;
            this.addCustomerBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.IdleForecolor = System.Drawing.Color.White;
            this.addCustomerBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.addCustomerBtn.Location = new System.Drawing.Point(384, 526);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(167, 50);
            this.addCustomerBtn.TabIndex = 8;
            this.addCustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 47);
            this.label6.TabIndex = 31;
            this.label6.Text = "Vendor Pay";
            // 
            // labl91
            // 
            this.labl91.AutoSize = true;
            this.labl91.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl91.Location = new System.Drawing.Point(271, 145);
            this.labl91.Name = "labl91";
            this.labl91.Size = new System.Drawing.Size(81, 25);
            this.labl91.TabIndex = 30;
            this.labl91.Text = "Vendors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Debit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Credit";
            // 
            // debitCheck
            // 
            this.debitCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.debitCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.debitCheck.Checked = true;
            this.debitCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.debitCheck.ForeColor = System.Drawing.Color.White;
            this.debitCheck.Location = new System.Drawing.Point(325, 488);
            this.debitCheck.Name = "debitCheck";
            this.debitCheck.Size = new System.Drawing.Size(20, 20);
            this.debitCheck.TabIndex = 7;
            this.debitCheck.OnChange += new System.EventHandler(this.debitCheck_OnChange);
            // 
            // creditCheck
            // 
            this.creditCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.creditCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.creditCheck.Checked = true;
            this.creditCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.creditCheck.ForeColor = System.Drawing.Color.White;
            this.creditCheck.Location = new System.Drawing.Point(325, 465);
            this.creditCheck.Name = "creditCheck";
            this.creditCheck.Size = new System.Drawing.Size(20, 20);
            this.creditCheck.TabIndex = 6;
            this.creditCheck.OnChange += new System.EventHandler(this.creditCheck_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(280, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Payment";
            // 
            // rOrPTxt
            // 
            this.rOrPTxt.AutoSize = true;
            this.rOrPTxt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rOrPTxt.Location = new System.Drawing.Point(641, 271);
            this.rOrPTxt.Name = "rOrPTxt";
            this.rOrPTxt.Size = new System.Drawing.Size(84, 17);
            this.rOrPTxt.TabIndex = 23;
            this.rOrPTxt.Text = "Last Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Payment";
            // 
            // CashPaymenttxt
            // 
            this.CashPaymenttxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(113)))));
            this.CashPaymenttxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.CashPaymenttxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(113)))));
            this.CashPaymenttxt.BorderThickness = 3;
            this.CashPaymenttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CashPaymenttxt.Enabled = false;
            this.CashPaymenttxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CashPaymenttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CashPaymenttxt.isPassword = false;
            this.CashPaymenttxt.Location = new System.Drawing.Point(263, 257);
            this.CashPaymenttxt.Margin = new System.Windows.Forms.Padding(4);
            this.CashPaymenttxt.Name = "CashPaymenttxt";
            this.CashPaymenttxt.Size = new System.Drawing.Size(371, 44);
            this.CashPaymenttxt.TabIndex = 3;
            this.CashPaymenttxt.Text = "0";
            this.CashPaymenttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cPayTxt
            // 
            this.cPayTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(113)))));
            this.cPayTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.cPayTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(113)))));
            this.cPayTxt.BorderThickness = 3;
            this.cPayTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cPayTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cPayTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPayTxt.isPassword = false;
            this.cPayTxt.Location = new System.Drawing.Point(263, 344);
            this.cPayTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cPayTxt.Name = "cPayTxt";
            this.cPayTxt.Size = new System.Drawing.Size(370, 44);
            this.cPayTxt.TabIndex = 4;
            this.cPayTxt.Text = "0";
            this.cPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuThinButton21.ButtonText = "Get Record";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(644, 167);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(167, 50);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // vendorDropdown
            // 
            this.vendorDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vendorDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vendorDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorDropdown.ForeColor = System.Drawing.Color.White;
            this.vendorDropdown.FormattingEnabled = true;
            this.vendorDropdown.Location = new System.Drawing.Point(264, 173);
            this.vendorDropdown.Name = "vendorDropdown";
            this.vendorDropdown.Size = new System.Drawing.Size(369, 39);
            this.vendorDropdown.TabIndex = 2;
            this.vendorDropdown.SelectedIndexChanged += new System.EventHandler(this.VendorDropdown_SelectedIndexChanged);
            // 
            // VendorPayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.vendorDropdown);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labl91);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.debitCheck);
            this.Controls.Add(this.creditCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rOrPTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashPaymenttxt);
            this.Controls.Add(this.cPayTxt);
            this.Name = "VendorPayControl";
            this.Size = new System.Drawing.Size(893, 644);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 addCustomerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labl91;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox debitCheck;
        private Bunifu.Framework.UI.BunifuCheckbox creditCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rOrPTxt;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox CashPaymenttxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox cPayTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox vendorDropdown;
    }
}
