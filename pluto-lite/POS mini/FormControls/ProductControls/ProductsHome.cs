using POS_mini.Models;
using System;
using System.Windows.Forms;

namespace POS_mini.FormControls.ProductControls
{
    public partial class ProductsHome : UserControl
    {
        
        ProductReportControl PRC;
        

        public ProductsHome()
        {
            InitializeComponent();
            ProductControl PC = new ProductControl();
            menuPanel.Left = productCBtn.Left;
            menuPanel.Width = productCBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(PC);
            PC.Refresher();
            PC.Dock = DockStyle.Fill;
        }

        
        private void productCBtn_Click(object sender, EventArgs e)
        {
            ProductControl PC = new ProductControl();
            menuPanel.Left = productCBtn.Left;
            menuPanel.Width = productCBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(PC);
            PC.Refresher();
            PC.Dock = DockStyle.Fill;
        }

        private void productTBtn_Click(object sender, EventArgs e)
        {
            ProductTypeControl PTC = new ProductTypeControl();
            menuPanel.Left = productTBtn.Left;
            menuPanel.Width = productTBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(PTC);
            PTC.Refresher();
            PTC.Dock = DockStyle.Fill;
        }

        private void productRBtn_Click(object sender, EventArgs e)
        {
            PRC = new ProductReportControl();
            menuPanel.Left = productRBtn.Left;
            menuPanel.Width = productRBtn.Width;
            this.pDashBoardPanel.Controls.Clear();
            this.pDashBoardPanel.Controls.Add(PRC);
            PRC.Refresher();
            PRC.Dock = DockStyle.Fill;
        }


    }
}
