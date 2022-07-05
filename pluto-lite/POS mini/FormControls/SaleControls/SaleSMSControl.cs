using POS_mini.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class SaleSMSControl : UserControl
    {
        Sale S = new Sale();
        Models.DBEntities db = new Models.DBEntities();
        public SaleSMSControl()
        {
            InitializeComponent();
            S = new Sale();
            db = new Models.DBEntities();
        }
        private void saleIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            long SaleID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (long.TryParse(saleIDTxt.Text, out SaleID))
                {
                    S = db.Sales.Where(X => X.ID == SaleID).FirstOrDefault();
                    netAmountLbl.Text = S.TotalCash.ToString();
                    saleIDlbl.Text = S.ID.ToString();
                }
            }
        }

        private void printAndSaveBtn_Click(object sender, EventArgs e)
        {


            ///////// SMS
            if (!string.IsNullOrEmpty(CustomerPhoneTxt.Text))
            {
                if (MessageBox.Show("Do you Want to send SMS?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        var sms = File.ReadAllText("SMS.txt");
                        sms = sms.Replace("{SALE-ID}", S.ID.ToString()).Replace("{TOTAL-AMOUNT}", netAmountLbl.Text.ToString()).Replace("{CUSTOMER-NAME}", customerNameTxt.Text).Replace("{TRACKING-ID}", trackingIDTxt.Text);
                        WebClient wc = new WebClient();
                        var api = "https://sendpk.com/api/sms.php?"
                            + "username="
                            + Properties.Settings.Default.smsUserName
                            + "&password="
                            + Properties.Settings.Default.smsPassword
                            + "&sender="
                            + Properties.Settings.Default.smsBrandName
                            + "&mobile="
                            + CustomerPhoneTxt.Text
                            + "&message="
                            + sms;
                        var smsResp = wc.DownloadString(api);
                        if (smsResp.Replace(" ", "").StartsWith("OK"))
                        {
                            try
                            {
                                db.Couriers.Add(new Courier
                                {
                                    CustomerName = customerNameTxt.Text,
                                    CustomerPhone = CustomerPhoneTxt.Text,
                                    TrackingID = trackingIDTxt.Text,
                                    SaleID = S.ID
                                });
                                db.SaveChanges();
                                MessageBox.Show("Sent");
                            }
                            catch (Exception t)
                            {
                                MessageBox.Show(t.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show(smsResp);
                        }
                        if (File.Exists("sms_Logs.txt"))
                        {
                            FileInfo fi = new FileInfo("sms_Logs.txt");
                            if (fi.Length > (10 * 1024 * 1024))
                            {
                                File.Move("sms_Logs.txt", "sms_Logs" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                            }
                        }
                        File.AppendAllText("sms_Logs.txt", "\n---------------------------------");
                        File.AppendAllText("sms_Logs.txt", "\n---------------------------------");
                        File.AppendAllText("sms_Logs.txt", "\n[TIME]\t" + DateTime.Now);
                        File.AppendAllText("sms_Logs.txt", "\n---------------------------------");
                        File.AppendAllText("sms_Logs.txt", "\n[API]\t" + api + "");
                        File.AppendAllText("sms_Logs.txt", "\n---------------------------------");
                        //File.AppendAllText("sms_Logs.txt", "\n[SMS]\t" + sms + "\n");
                        File.AppendAllText("sms_Logs.txt", "\n[RESPONSE]\t" + smsResp);
                        File.AppendAllText("sms_Logs.txt", "\n---------------------------------");

                    }
                    catch (Exception t)
                    {
                        MessageBox.Show(t.Message);
                        File.AppendAllText("sms_Error.txt", "\n[]" + DateTime.Now);
                        File.AppendAllText("sms_Error.txt", "\n[]" + t.Message);
                    }
                }
            }
            //////// 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Couriers.ToList();
        }
    }
}
