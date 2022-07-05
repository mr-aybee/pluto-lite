using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using POS_mini.App_Code;
using System.Drawing.Imaging;

namespace POS_mini.FormControls.SettingsControls
{
    public partial class SettingsBillControl : UserControl
    {
        Models.PlutoSettings PS = new Models.PlutoSettings();
        Models.DBEntities db = new Models.DBEntities();
        byte[] ImageBytes { get; set; }
        public SettingsBillControl()
        {
            InitializeComponent();

        }

        public void Refresher()
        {
            try
            {
                PS = db.PlutoSettings.First();
                if (PS != null)
                {
                    cNameTxt.Text = PS.CompanyName;
                    cPhone1txt.Text = PS.CompanyPhone;
                    cPhone2txt.Text = PS.CompanyPhone2;
                    cAddressTxt.Text = PS.CompanyAddress;
                    cSaleNoteTxt.Text = PS.ComapnySaleNote;
                }
                if (File.Exists(Constants.cLogoImage))
                {
                    var iByte = File.ReadAllBytes(Constants.cLogoImage);
                    Bitmap bmp;
                    using (var ms = new MemoryStream(iByte))
                    {
                        bmp = new Bitmap(ms);
                    }
                    cLogoImage.Image = bmp;
                }
            }
            catch(Exception t) { Alert.Show(t.Message, Alert.alertType.success); }
        }

        byte[] CompanyLogo { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog SFD = new OpenFileDialog();
            SFD.Filter = "Image files (*.jpg, *.jpeg, *.bmp  *.png) | *.jpg; *.jpeg; *.bmp;  *.png";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                CompanyLogo = File.ReadAllBytes(SFD.FileName);
                ImageBytes = CompanyLogo;
                if (CompanyLogo.Length > 1000000) { MessageBox.Show("File is Greater then 10 MB, Please Select A File Which is between 1KB to 1MB Thankyou");return; }
                Bitmap bmp;
                using (var ms = new MemoryStream(CompanyLogo))
                {
                    bmp = new Bitmap(ms);
                }
                cLogoImage.Image = bmp;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(ImageBytes.Length>0)
                File.WriteAllBytes(Constants.cLogoImage, ImageBytes);
            PS = db.PlutoSettings.First();
            if (PS != null)
            {
                var ps = new Models.PlutoSettings { 
                    ComapnySaleNote = cSaleNoteTxt.Text,
                    CompanyAddress = cAddressTxt.Text,
                    CompanyName = cNameTxt.Text,
                    CompanyPhone = cPhone1txt.Text,
                    CompanyPhone2 = cPhone2txt.Text,
                };
                db.PlutoSettings.RemoveRange(db.PlutoSettings.AsEnumerable());
                db.PlutoSettings.Add(ps);
                db.SaveChanges();
                MessageBox.Show("Saved");
            }
        }

        public byte[] ImageToByteArray(Bitmap imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
