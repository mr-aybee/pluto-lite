using System;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class SaleHome : UserControl
    {
        SaleCreateControl SCC;
        SaleEditControl SEC;
        SaleReport SR;
        public SaleHome()
        {
            InitializeComponent();
            menuPanel.Left = saleCBtn.Left;
            menuPanel.Width = saleCBtn.Width;
            this.pBackWorker.Controls.Clear();
            SCC = new SaleCreateControl();
            this.pBackWorker.Controls.Add(SCC);
            SCC.Refresher();
            SCC.Dock = DockStyle.Fill;
        }

        private void customerCBtn_Click(object sender, EventArgs e)
        {
            SCC = new SaleCreateControl();
            menuPanel.Left = saleCBtn.Left;
            menuPanel.Width = saleCBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SCC);
            SCC.Refresher();
            SCC.Dock = DockStyle.Fill;
        }

        private void customerPBtn_Click(object sender, EventArgs e)
        {
            SEC = new SaleEditControl();
            menuPanel.Left = customerPBtn.Left;
            menuPanel.Width = customerPBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SEC);
            SEC.Refresher();
            SEC.Dock = DockStyle.Fill;
        }

        private void sReportBtn_Click(object sender, EventArgs e)
        {
            SR = new SaleReport();
            menuPanel.Left = sReportBtn.Left;
            menuPanel.Width = sReportBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SR);
            SR.Dock = DockStyle.Fill;
        }

        private void saleSearchMainBtn_Click(object sender, EventArgs e)
        {
            var EC = new ExpenseControl();
            menuPanel.Left = saleSearchMainBtn.Left;
            menuPanel.Width = saleSearchMainBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(EC);
            EC.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var SMSC = new SaleSMSControl();
            menuPanel.Left = saleSearchMainBtn.Left;
            menuPanel.Width = saleSearchMainBtn.Width;
            this.pBackWorker.Controls.Clear();
            this.pBackWorker.Controls.Add(SMSC);
            SMSC.Dock = DockStyle.Fill;
        }
    }
}
