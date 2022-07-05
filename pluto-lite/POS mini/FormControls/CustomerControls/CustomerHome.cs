using System;
using System.Windows.Forms;

namespace POS_mini.FormControls.CustomerControls
{
    public partial class CustomerHome : UserControl
    {
        CustomerControl CC;
        cPayBtn CPC;
        CPayRecord CPR;
        public CustomerHome()
        {
            InitializeComponent();
            // = cc;
            //CPC = cpc;
            //CPR = cpr;
            CC = new CustomerControl();
            menuPanel.Left = customerCBtn.Left;
            menuPanel.Width = customerCBtn.Width;
            this.cPanelWorker.Controls.Clear();
            this.cPanelWorker.Controls.Add(CC);
            //CC.Refresher();
            CC.Dock = DockStyle.Fill;
        }

        private void customerCBtn_Click(object sender, EventArgs e)
        {
            CC = new CustomerControl();
            menuPanel.Left = customerCBtn.Left;
            menuPanel.Width = customerCBtn.Width;
            this.cPanelWorker.Controls.Clear();
            this.cPanelWorker.Controls.Add(CC);
            CC.Refresher();
            CC.Dock = DockStyle.Fill;
        }

        private void customerPBtn_Click(object sender, EventArgs e)
        {
            CPC = new cPayBtn();
            menuPanel.Left = customerPBtn.Left;
            menuPanel.Width = customerPBtn.Width;
            this.cPanelWorker.Controls.Clear();
            this.cPanelWorker.Controls.Add(CPC);
            CPC.Refresher();
            CPC.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            CPR = new CPayRecord();
            menuPanel.Left = bunifuFlatButton1.Left;
            menuPanel.Width = bunifuFlatButton1.Width;
            this.cPanelWorker.Controls.Clear();
            this.cPanelWorker.Controls.Add(CPR);
            CPR.Refresher();
            CPR.Dock = DockStyle.Fill;
        }
    }
}
