namespace POS_mini.FormControls.InvoiceControls
{
    partial class InvoicesReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesReportControl));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allTimeCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.printInvoicesBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.vendorNameDropDown = new System.Windows.Forms.ComboBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 47);
            this.label4.TabIndex = 13;
            this.label4.Text = "Invoices Reports";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vendors Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "For  Date";
            // 
            // allTimeCheck
            // 
            this.allTimeCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allTimeCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.allTimeCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.allTimeCheck.Checked = false;
            this.allTimeCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(94)))));
            this.allTimeCheck.ForeColor = System.Drawing.Color.White;
            this.allTimeCheck.Location = new System.Drawing.Point(352, 234);
            this.allTimeCheck.Name = "allTimeCheck";
            this.allTimeCheck.Size = new System.Drawing.Size(20, 20);
            this.allTimeCheck.TabIndex = 17;
            this.allTimeCheck.OnChange += new System.EventHandler(this.allTimeCheck_OnChange);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "All Time";
            // 
            // printInvoicesBtn
            // 
            this.printInvoicesBtn.ActiveBorderThickness = 1;
            this.printInvoicesBtn.ActiveCornerRadius = 20;
            this.printInvoicesBtn.ActiveFillColor = System.Drawing.Color.White;
            this.printInvoicesBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.printInvoicesBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.printInvoicesBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printInvoicesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.printInvoicesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printInvoicesBtn.BackgroundImage")));
            this.printInvoicesBtn.ButtonText = "Print";
            this.printInvoicesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printInvoicesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoicesBtn.ForeColor = System.Drawing.Color.White;
            this.printInvoicesBtn.IdleBorderThickness = 1;
            this.printInvoicesBtn.IdleCornerRadius = 20;
            this.printInvoicesBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.printInvoicesBtn.IdleForecolor = System.Drawing.Color.White;
            this.printInvoicesBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.printInvoicesBtn.Location = new System.Drawing.Point(325, 368);
            this.printInvoicesBtn.Margin = new System.Windows.Forms.Padding(5);
            this.printInvoicesBtn.Name = "printInvoicesBtn";
            this.printInvoicesBtn.Size = new System.Drawing.Size(167, 50);
            this.printInvoicesBtn.TabIndex = 20;
            this.printInvoicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printInvoicesBtn.Click += new System.EventHandler(this.printInvoicesBtn_Click);
            // 
            // vendorNameDropDown
            // 
            this.vendorNameDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vendorNameDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.vendorNameDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vendorNameDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameDropDown.ForeColor = System.Drawing.Color.White;
            this.vendorNameDropDown.FormattingEnabled = true;
            this.vendorNameDropDown.Location = new System.Drawing.Point(280, 185);
            this.vendorNameDropDown.Name = "vendorNameDropDown";
            this.vendorNameDropDown.Size = new System.Drawing.Size(247, 33);
            this.vendorNameDropDown.TabIndex = 22;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Location = new System.Drawing.Point(280, 301);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(247, 20);
            this.fromDatePicker.TabIndex = 23;
            // 
            // InvoicesReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.vendorNameDropDown);
            this.Controls.Add(this.printInvoicesBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allTimeCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "InvoicesReportControl";
            this.Size = new System.Drawing.Size(766, 556);
            this.Load += new System.EventHandler(this.InvoicesReportControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox allTimeCheck;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 printInvoicesBtn;
        private System.Windows.Forms.ComboBox vendorNameDropDown;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
    }
}
