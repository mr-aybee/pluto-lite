using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Reporting.WinForms;
using POS_mini.App_Code;

namespace POS_mini.Reports
{
    public partial class Report : Form
    {
        Models.DBEntities db = new Models.DBEntities();
        Models.PlutoSettings settings = new Models.PlutoSettings();


        public Report(object[] Data)
        {
            InitializeComponent();
            reportViewer1.RenderingComplete += (sender, args) =>
            {
                reportViewer1.PrintDialog();
            };


            settings = db.PlutoSettings.First();
            if (settings == null)
            {
                MessageBox.Show("Kindly Update Report Settings");
                return;
            }
            SetUpFirstSetupBarcode();

            switch ((Constants.ReportTypes)Data[0])
            {
                case Constants.ReportTypes.CustomerPaySlip:
                    this.Text = Constants.ReportTypes.CustomerPaySlip.ToString();
                    CustomerPaySlip((PayRpt)Data[1]);
                    break;
                case Constants.ReportTypes.VendorPaySlip:
                    this.Text = Constants.ReportTypes.VendorPaySlip.ToString();
                    VendorPaySlip((PayRpt)Data[1]);
                    break;
                case Constants.ReportTypes.CustomerReportFile:
                    this.Text = Constants.ReportTypes.CustomerReportFile.ToString();
                    CustomerPayRecord((object[])Data[1]);
                    break;
                case Constants.ReportTypes.InvoiceReportFile:
                    this.Text = Constants.ReportTypes.InvoiceReportFile.ToString();
                    InvoiceReport((List<AllInvoicesRpt>)Data[1], (InvoicesDetailsRpt)Data[2]);
                    break;
                case Constants.ReportTypes.InvoiceSlip:
                    this.Text = Constants.ReportTypes.InvoiceSlip.ToString();
                    InvoiceSlip((List<ItemsListRpt>)Data[1], (SInvoiceRpt)Data[2]);
                    break;
                case Constants.ReportTypes.SaleSheet:
                    this.Text = Constants.ReportTypes.SaleSheet.ToString();
                    SaleSheet(Data[1] as List<App_Code.MultiSaleRecord>, Data[2].ToString());
                    break;
                case Constants.ReportTypes.ProductReport:
                    this.Text = Constants.ReportTypes.ProductReport.ToString();
                    ProductReport(Data[1] as List<ProductsInventoryRpt>);
                    break;
                case Constants.ReportTypes.SaleSlip:
                    this.Text = Constants.ReportTypes.SaleSlip.ToString();
                    SaleSlip(Data[2] as List<ItemsListRpt>, Data[1] as SaleDetailRpt);
                    break;
                case Constants.ReportTypes.VendorReportFile:
                    this.Text = Constants.ReportTypes.VendorReportFile.ToString();
                    VendorPayRecord(Data[1] as List<PayRecord>, Data[2] as object[]);
                    break;
                case Constants.ReportTypes.BarcodeSlip:
                    this.Text = Constants.ReportTypes.BarcodeSlip.ToString();
                    BarcodeSlip(Data[1] as string, Data[2] as string);
                    break;

            }
            reportViewer1.LocalReport.EnableExternalImages = true;
            var gSettings = GetCurrentReportMargins();
            PageSettings pg = new PageSettings();
            pg.Margins.Top = gSettings.Top;
            pg.Margins.Bottom = gSettings.Bottom;
            pg.Margins.Left = gSettings.Left;
            pg.Margins.Right = gSettings.Right;
            this.reportViewer1.SetPageSettings(pg);
            this.reportViewer1.RefreshReport();


            ///////
            this.reportViewer1.Print += (sender, args) =>
            {
                //MessageBox.Show("Print Triggered");
                var pgUpdater = reportViewer1.GetPageSettings();
                CustomMargins CM = new CustomMargins
                {
                    Top = pgUpdater.Margins.Top,
                    Bottom = pgUpdater.Margins.Bottom,
                    Left = pgUpdater.Margins.Left,
                    Right = pgUpdater.Margins.Right
                };

                var pageMarginList = XML.DeserializeObject<List<ReportPageSettings>>(File.ReadAllText("PrintPage.Config.xml"));
                foreach (var pageMargin in pageMarginList)
                {
                    if (pageMargin.Name.ToString() == this.Text)
                    {
                        pageMargin.Margins = CM;
                    }
                }
                var XMLstring = XML.SerializeObjectIndented(pageMarginList);
                File.WriteAllText("PrintPage.Config.xml", XMLstring);
            };



        }


        public void SetUpFirstSetupBarcode()
        {
            if (File.Exists("PrintPage.Config.xml")) return;
            List<ReportPageSettings> ReportPages = new List<ReportPageSettings>();
            foreach (Constants.ReportTypes rT in Enum.GetValues(typeof(Constants.ReportTypes)))
            {
                ReportPages.Add(new ReportPageSettings
                {
                    Name = rT.ToString(),
                    Margins = new CustomMargins { Bottom = 0, Top = 0, Left = 0, Right = 0 }
                });
            }
            var XMLstring = XML.SerializeObjectIndented(ReportPages);
            File.WriteAllText("PrintPage.Config.xml", XMLstring);
        }


        public CustomMargins GetCurrentReportMargins()
        {
            var pageMarginList = XML.DeserializeObject<List<ReportPageSettings>>(File.ReadAllText("PrintPage.Config.xml"));
            foreach (var pageMargin in pageMarginList)
            {
                if (pageMargin.Name.ToString() == this.Text)
                {
                    return pageMargin.Margins;
                }
            }
            return new CustomMargins();
        }

        private void ReportFormMain_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }


        #region Report Methods

        /// <summary>
        /// Customer Slip Mothod
        /// </summary>
        /// <param name="PR"></param>
        private void CustomerPaySlip(PayRpt PR)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.CustomerPaySlip.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Name",PR.Name),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",PR.Date),
                new Microsoft.Reporting.WinForms.ReportParameter("AmountPaid",PR.AmountPaid),
                new Microsoft.Reporting.WinForms.ReportParameter("RemainingAmount",PR.RemainingAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName),
            };
            reportViewer1.LocalReport.SetParameters(p);
        }

        /// <summary>
        /// Vendor Slip Mothod
        /// </summary>
        /// <param name="PR"></param>
        private void VendorPaySlip(PayRpt PR)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.VendorPaySlip.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Name",PR.Name),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",PR.Date),
                new Microsoft.Reporting.WinForms.ReportParameter("AmountPaid",PR.AmountPaid),
                new Microsoft.Reporting.WinForms.ReportParameter("RemainingAmount",PR.RemainingAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName),
            };
            reportViewer1.LocalReport.SetParameters(p);
        }

        /// <summary>
        /// Customer Payment Record
        /// </summary>
        /// <param name="Data"></param>
        private void CustomerPayRecord(object[] Data)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.CustomerReportFile.rdlc";

            DataTable dt = new DataTable();
            dt = App_Code.Constants.ToDataTable((List<App_Code.PayRecord>)Data[0]);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("CustomerName",Data[1].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("rStatus",Data[2].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("RemainingBalance",Data[3].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName)

            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdt);
            reportViewer1.LocalReport.SetParameters(p);

        }

        /// <summary>
        /// Invoice Report
        /// </summary>
        /// <param name="AIR"></param>
        /// <param name="IDR"></param>
        private void InvoiceReport(List<AllInvoicesRpt> AIR, InvoicesDetailsRpt IDR)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.InvoiceReportFile.rdlc";
            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(AIR);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("VendorName",IDR.VendorName),
                new Microsoft.Reporting.WinForms.ReportParameter("DateFrom",IDR.FromDate),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalInvoices",IDR.TotalInvoice),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalProductsInvoiced",IDR.TotalProductsInvoice),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName)
            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Add(rdt);

        }

        /// <summary>
        /// Invoice Slip
        /// </summary>
        /// <param name="ItemsListRpts"></param>
        /// <param name="SIR"></param>
        private void InvoiceSlip(List<ItemsListRpt> ItemsListRpts, SInvoiceRpt SIR)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.InvoiceSlip.rdlc";
            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(ItemsListRpts);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("Table", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("VendorName",SIR.VendorName),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",SIR.Date),
                new Microsoft.Reporting.WinForms.ReportParameter("Time",SIR.Time),
                new Microsoft.Reporting.WinForms.ReportParameter("InvoiceID",SIR.InvoiceID),
                new Microsoft.Reporting.WinForms.ReportParameter("CashPaid",SIR.CashPaid),
                new Microsoft.Reporting.WinForms.ReportParameter("CashRemaining",SIR.CashRemaining),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalPayment",SIR.TotalPayment),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone1",settings.CompanyPhone),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone2",settings.CompanyPhone2),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress",settings.CompanyAddress)
            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Add(rdt);
        }

        /// <summary>
        /// Sale Sheet
        /// </summary>
        /// <param name="MSR"></param>
        /// <param name="Date"></param>
        private void SaleSheet(List<App_Code.MultiSaleRecord> MSR, string Date)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.SaleSheet.rdlc";
            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(MSR);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Date",Date),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName)

            };

            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdt);
        }

        /// <summary>
        /// Product Report With Sold and Invoiced Data
        /// </summary>
        /// <param name="PIR"></param>
        private void ProductReport(List<ProductsInventoryRpt> PIR)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.ProductReportFile.rdlc";

            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(PIR);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Date",DateTime.Now.ToShortDateString()),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName)
            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Add(rdt);
        }


        /// <summary>
        /// Sale Slip
        /// </summary>
        /// <param name="ItemsListRpts"></param>
        /// <param name="SaleDetailsRPT"></param>
        private void SaleSlip(List<ItemsListRpt> ItemsListRpts, SaleDetailRpt SaleDetailsRPT)
        {

            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image img = barcode.Draw(SaleDetailsRPT.SaleID, 50);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            var imageBytes = ms.ToArray();
            File.WriteAllBytes(Constants.barcodeImage, imageBytes);
            var barcodeImage = Constants.barcodeImage;
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.SaleSlip.rdlc";
            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(ItemsListRpts);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("Table", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("CustomerName",SaleDetailsRPT.CustomerName),
                new Microsoft.Reporting.WinForms.ReportParameter("CustomerPhone",SaleDetailsRPT.CustomerPhone),
                new Microsoft.Reporting.WinForms.ReportParameter("SaleID",SaleDetailsRPT.SaleID),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalPrice",SaleDetailsRPT.TotalPrice),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalDiscount",SaleDetailsRPT.TotalDiscount),
                new Microsoft.Reporting.WinForms.ReportParameter("NetAmount",SaleDetailsRPT.NetAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",SaleDetailsRPT.Date),
                new Microsoft.Reporting.WinForms.ReportParameter("Time",SaleDetailsRPT.Time),
                new Microsoft.Reporting.WinForms.ReportParameter("Cashier",DBCache.User.Find(x=>x.ID == Constants.UserID).Name),
                new Microsoft.Reporting.WinForms.ReportParameter("ReportLogo",new Uri( barcodeImage).AbsoluteUri),
                new Microsoft.Reporting.WinForms.ReportParameter("CashRecieved",SaleDetailsRPT.AmountReceived),
                new Microsoft.Reporting.WinForms.ReportParameter("CashReturn",SaleDetailsRPT.CashReturn),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone1",settings.CompanyPhone),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone2",settings.CompanyPhone2),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress",settings.CompanyAddress),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanySaleNote",settings.ComapnySaleNote),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyLogo",new Uri(Constants.cLogoImage).AbsoluteUri)

            };
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Add(rdt);
        }


        /// <summary>
        /// Vendor Pay Record
        /// </summary>
        /// <param name="PR"></param>
        /// <param name="Data"></param>
        private void VendorPayRecord(List<PayRecord> PR, object[] Data)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.VendorReportFile.rdlc";
            DataTable dt = new DataTable();
            dt = Constants.ToDataTable(PR);
            Microsoft.Reporting.WinForms.ReportDataSource rdt = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("VendorName",Data[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("RemainingBalance",Data[1].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("rStatus",Data[2].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("CompanyName",settings.CompanyName)
            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.DataSources.Add(rdt);
        }

        /// <summary>
        /// Customer Slip Mothod
        /// </summary>
        /// <param name="PR"></param>
        private void BarcodeSlip(string barcodeNum, string productName = "")
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image img = barcode.Draw(barcodeNum, 20);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            var imageBytes = ms.ToArray();
            File.WriteAllBytes(Constants.barcodeImage, imageBytes);
            var barcodeImage = Constants.barcodeImage;
            //reportViewer1.LocalReport.ReportPath = "Reports.Reportings.BarcodeSlip.rdlc";
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_mini.Reports.Reportings.BarcodeSlip.rdlc";
            ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("barcodeNumber",barcodeNum),
                new ReportParameter("ProductName",productName),
                new ReportParameter("barcodeImage",new Uri( barcodeImage).AbsoluteUri),
            };
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(p);
        }

        #endregion



    }


    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ReportPageSettings
    {
        public string Name { get; set; }
        public CustomMargins Margins { get; set; }

    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class CustomMargins
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Top { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Bottom { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Left { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Right { get; set; }

        public CustomMargins()
        {
            this.Top = 0;
            this.Bottom = 0;
            this.Left = 0;
            this.Right = 0;
        }
    }


}
