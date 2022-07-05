namespace POS_mini.CustomControls
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.yesbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.noBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // yesbtn
            // 
            this.yesbtn.ActiveBorderThickness = 1;
            this.yesbtn.ActiveCornerRadius = 20;
            this.yesbtn.ActiveFillColor = System.Drawing.Color.White;
            this.yesbtn.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.yesbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.yesbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yesbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesbtn.BackgroundImage")));
            this.yesbtn.ButtonText = "Yes, Proceed Please  ";
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.yesbtn.IdleBorderThickness = 1;
            this.yesbtn.IdleCornerRadius = 20;
            this.yesbtn.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.yesbtn.IdleForecolor = System.Drawing.Color.White;
            this.yesbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.yesbtn.Location = new System.Drawing.Point(64, 189);
            this.yesbtn.Margin = new System.Windows.Forms.Padding(5);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(239, 45);
            this.yesbtn.TabIndex = 0;
            this.yesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.ActiveBorderThickness = 1;
            this.noBtn.ActiveCornerRadius = 20;
            this.noBtn.ActiveFillColor = System.Drawing.Color.White;
            this.noBtn.ActiveForecolor = System.Drawing.Color.Crimson;
            this.noBtn.ActiveLineColor = System.Drawing.Color.Crimson;
            this.noBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.noBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noBtn.BackgroundImage")));
            this.noBtn.ButtonText = "No, Stop";
            this.noBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.White;
            this.noBtn.IdleBorderThickness = 1;
            this.noBtn.IdleCornerRadius = 20;
            this.noBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.noBtn.IdleForecolor = System.Drawing.Color.White;
            this.noBtn.IdleLineColor = System.Drawing.Color.Crimson;
            this.noBtn.Location = new System.Drawing.Point(313, 189);
            this.noBtn.Margin = new System.Windows.Forms.Padding(5);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(120, 45);
            this.noBtn.TabIndex = 1;
            this.noBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.message.Location = new System.Drawing.Point(64, 89);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(369, 95);
            this.message.TabIndex = 3;
            this.message.Text = "n adj ahl l al as ld hs hdalshdlhas da djahd kasd kja s dash dka hdl a";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pictureBox1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.message;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // CutomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(509, 248);
            this.Controls.Add(this.message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CutomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CutomMessageBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CutomMessageBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 noBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 yesbtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
    }
}