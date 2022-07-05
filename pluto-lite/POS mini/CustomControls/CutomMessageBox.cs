using System;
using System.Windows.Forms;

namespace POS_mini.CustomControls
{
    public partial class CustomMessageBox : Form
    {
        private CustomMessageBox(string text)
        {
            InitializeComponent();
            message.Text = text;
        }

        // This static method is the equivalent of MessageBox.Show
        public static DialogResult ShowDialog(IWin32Window owner, string text)
        {
            // Setting the DialogResult does not close the form, it just hides it. 
            // This is why I'm disposing it. see the link at the end of my answer for details.
            using (var customDialog = new CustomMessageBox(text))
            {
                return customDialog.ShowDialog(owner);
            }

        }

        //private constructor so you don't accidentally create an instance of this form
        //private CustomMessageBox(string text)
        //{
        //    InitializeComponent();
        //    this.Text = caption;
        //    this.message.Text = text;
        //}


        // Handle the click event of the `yes` button
        private void yesbtn_Click(object sender, EventArgs e)
        {
            // This will automatically close the form
            this.DialogResult = DialogResult.Yes;
        }
        // Handle the click event of the `no` button
        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void CutomMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Y)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.N)
            {
                this.DialogResult = DialogResult.No;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            if (e == Keys.Enter || e == Keys.Y)
            {
                this.DialogResult = DialogResult.Yes;
                return true;
            }
            else if (e == Keys.Escape || e == Keys.N)
            {
                this.DialogResult = DialogResult.No;
                return true;
            }
            return base.ProcessCmdKey(ref msg, e);
        }
    }
}
