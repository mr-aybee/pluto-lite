using System;
using System.Windows.Forms;

namespace POS_mini.FormControls.Vendors
{
    public partial class VendorsHome : UserControl
    {
        VendorsControl VC;
        VendorPayControl VPC;
        VPayRecord VPR;
        public VendorsHome()
        {
            InitializeComponent();
            VC = new VendorsControl();
            menuPanel.Left = vendorCBtn.Left;
            menuPanel.Width = vendorCBtn.Width;
            this.vPanelBack.Controls.Clear();
            this.vPanelBack.Controls.Add(VC);
            VC.Refresher();
            VC.Dock = DockStyle.Fill;
        }

        private void vendorCBtn_Click(object sender, EventArgs e)
        {
            VC = new VendorsControl();
            menuPanel.Left = vendorCBtn.Left;
            menuPanel.Width = vendorCBtn.Width;
            this.vPanelBack.Controls.Clear();
            this.vPanelBack.Controls.Add(VC);
            VC.Refresher();
            VC.Dock = DockStyle.Fill;

        }

        private void vPayBtn_Click(object sender, EventArgs e)
        {
            VPC = new VendorPayControl();
            menuPanel.Left = vPayBtn.Left;
            menuPanel.Width = vPayBtn.Width;
            this.vPanelBack.Controls.Clear();
            this.vPanelBack.Controls.Add(VPC);
            VPC.Refresher();
            VPC.Dock = DockStyle.Fill;
        }

        private void VpayRecordBtn_Click(object sender, EventArgs e)
        {
            VPR = new VPayRecord();
            menuPanel.Left = vpayRecordBtn.Left;
            menuPanel.Width = vPayBtn.Width;
            this.vPanelBack.Controls.Clear();
            this.vPanelBack.Controls.Add(VPR);
            VPR.Refresher();
            VPR.Dock = DockStyle.Fill;
        }
    }
}
