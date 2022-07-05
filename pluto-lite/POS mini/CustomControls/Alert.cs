using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_mini
{
    public partial class Alert : Form
    {
        public Alert(string _message, alertType type)
        {
            InitializeComponent();
            label2.Text = _message;
            if (_message.Length > 160)
                label2.Font = new Font("Nirmala UI", 6, FontStyle.Regular);
            switch (type)
            {
                case alertType.error:
                    this.ColorPanel.GradientTopLeft = Color.FromArgb(241, 9, 48);
                    this.ColorPanel.GradientTopRight = Color.FromArgb(177, 103, 6);
                    this.ColorPanel.GradientBottomLeft = Color.FromArgb(177, 103, 6);
                    this.ColorPanel.GradientBottomRight = Color.FromArgb(241, 9, 48);
                    this.alerImage.Image = Properties.Resources.errorImage;
                    break;
                case alertType.warning:
                    this.ColorPanel.GradientTopLeft = Color.FromArgb(255, 128, 0);
                    this.ColorPanel.GradientTopRight = Color.FromArgb(192, 64, 0);
                    this.ColorPanel.GradientBottomLeft = Color.FromArgb(128, 64, 0);
                    this.ColorPanel.GradientBottomRight = Color.FromArgb(192, 64, 0);
                    this.alerImage.Image = Properties.Resources.warningIcon;
                    break;
                case alertType.success:
                    this.ColorPanel.GradientTopLeft = Color.FromArgb(52, 121, 94);
                    this.ColorPanel.GradientTopRight = Color.FromArgb(3, 76, 70);
                    this.ColorPanel.GradientBottomLeft = Color.FromArgb(52, 121, 94);
                    this.ColorPanel.GradientBottomRight = Color.FromArgb(3, 76, 70);
                    this.alerImage.Image = Properties.Resources.successIcon;
                    break;

            }
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 10;
            this.Height = label2.Height;
        }

        public enum alertType { success, warning, error }

        public static void Show(string message, alertType type)
        {
            new Alert(message, type).Show();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            this.Close();

        }

        int interval = 0;

        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;

            }
            else
            {
                showT.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            close.Start();
        }


    }
}
