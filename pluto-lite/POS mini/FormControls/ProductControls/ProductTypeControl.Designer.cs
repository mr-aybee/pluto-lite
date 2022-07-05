namespace POS_mini.FormControls.ProductControls
{
    partial class ProductTypeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypeControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pTypeTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productAddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.typeEditTxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.typeDescriptionText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeSearchBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Type";
            // 
            // pTypeTxt
            // 
            this.pTypeTxt.BackColor = System.Drawing.SystemColors.Control;
            this.pTypeTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTypeTxt.BackgroundImage")));
            this.pTypeTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTypeTxt.ForeColor = System.Drawing.Color.Black;
            this.pTypeTxt.Icon = ((System.Drawing.Image)(resources.GetObject("pTypeTxt.Icon")));
            this.pTypeTxt.Location = new System.Drawing.Point(134, 204);
            this.pTypeTxt.Name = "pTypeTxt";
            this.pTypeTxt.Size = new System.Drawing.Size(216, 38);
            this.pTypeTxt.TabIndex = 13;
            this.pTypeTxt.text = "";
            this.pTypeTxt.OnTextChange += new System.EventHandler(this.pTypeTxt_OnTextChange);
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
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Location = new System.Drawing.Point(965, 331);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 50);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.UpdateBtn.Location = new System.Drawing.Point(838, 331);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 50);
            this.UpdateBtn.TabIndex = 19;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // productAddBtn
            // 
            this.productAddBtn.ActiveBorderThickness = 1;
            this.productAddBtn.ActiveCornerRadius = 20;
            this.productAddBtn.ActiveFillColor = System.Drawing.Color.White;
            this.productAddBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.productAddBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.productAddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.productAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productAddBtn.BackgroundImage")));
            this.productAddBtn.ButtonText = "Add";
            this.productAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productAddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddBtn.ForeColor = System.Drawing.Color.White;
            this.productAddBtn.IdleBorderThickness = 1;
            this.productAddBtn.IdleCornerRadius = 20;
            this.productAddBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.productAddBtn.IdleForecolor = System.Drawing.Color.White;
            this.productAddBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.productAddBtn.Location = new System.Drawing.Point(152, 259);
            this.productAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(167, 50);
            this.productAddBtn.TabIndex = 18;
            this.productAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productAddBtn.Click += new System.EventHandler(this.productAddBtn_Click);
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
            this.Column1,
            this.Type,
            this.Column2});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(395, 121);
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
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(351, 363);
            this.bunifuCustomDataGrid1.TabIndex = 17;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(836, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Type";
            // 
            // typeEditTxt
            // 
            this.typeEditTxt.BackColor = System.Drawing.SystemColors.Control;
            this.typeEditTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("typeEditTxt.BackgroundImage")));
            this.typeEditTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typeEditTxt.ForeColor = System.Drawing.Color.Black;
            this.typeEditTxt.Icon = ((System.Drawing.Image)(resources.GetObject("typeEditTxt.Icon")));
            this.typeEditTxt.Location = new System.Drawing.Point(833, 190);
            this.typeEditTxt.Name = "typeEditTxt";
            this.typeEditTxt.Size = new System.Drawing.Size(216, 38);
            this.typeEditTxt.TabIndex = 21;
            this.typeEditTxt.text = "";
            // 
            // typeDescriptionText
            // 
            this.typeDescriptionText.Location = new System.Drawing.Point(837, 259);
            this.typeDescriptionText.Name = "typeDescriptionText";
            this.typeDescriptionText.Size = new System.Drawing.Size(233, 67);
            this.typeDescriptionText.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Existing Product Type";
            // 
            // typeSearchBox
            // 
            this.typeSearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.typeSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("typeSearchBox.BackgroundImage")));
            this.typeSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typeSearchBox.ForeColor = System.Drawing.Color.Black;
            this.typeSearchBox.Icon = ((System.Drawing.Image)(resources.GetObject("typeSearchBox.Icon")));
            this.typeSearchBox.Location = new System.Drawing.Point(591, 87);
            this.typeSearchBox.Name = "typeSearchBox";
            this.typeSearchBox.Size = new System.Drawing.Size(155, 29);
            this.typeSearchBox.TabIndex = 26;
            this.typeSearchBox.text = "";
            this.typeSearchBox.OnTextChange += new System.EventHandler(this.typeSearchBox_OnTextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(836, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description";
            // 
            // ProductTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeSearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeDescriptionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeEditTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.productAddBtn);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pTypeTxt);
            this.Controls.Add(this.label1);
            this.Name = "ProductTypeControl";
            this.Size = new System.Drawing.Size(1141, 534);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox pTypeTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 productAddBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox typeEditTxt;
        private System.Windows.Forms.Label typeDescriptionText;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuTextbox typeSearchBox;
        private System.Windows.Forms.Label label6;
    }
}
