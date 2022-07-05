using System;
using System.Windows.Forms;

namespace POS_mini.FormControls.InvoiceControls
{
    public partial class InvoiceHome : UserControl
    {
        InvoiceControl IC;
        InvoiceView IV;
        InvoicesReportControl IRC;
        public InvoiceHome()
        {
            InitializeComponent();
            IC = new InvoiceControl();
            menuPanel.Left = invoiceCBtn.Left;
            menuPanel.Width = invoiceCBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(IC);
            IC.Refresher();
            IC.Dock = DockStyle.Fill;
        }

        private void customerCBtn_Click(object sender, EventArgs e)
        {
            IC = new InvoiceControl();
            menuPanel.Left = invoiceCBtn.Left;
            menuPanel.Width = invoiceCBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(IC);
            IC.Refresher();
            IC.Dock = DockStyle.Fill;

        }

        private void customerPBtn_Click(object sender, EventArgs e)
        {
            IV = new InvoiceView();
            menuPanel.Left = customerPBtn.Left;
            menuPanel.Width = customerPBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(IV);
            IV.Refresher();
            IV.Dock = DockStyle.Fill;
        }

        private void ircBtn_Click(object sender, EventArgs e)
        {
            IRC = new InvoicesReportControl();
            menuPanel.Left = ircBtn.Left;
            menuPanel.Width = customerPBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(IRC);
            IRC.Refresher();
            IRC.Dock = DockStyle.Fill;
        }
    }
}
