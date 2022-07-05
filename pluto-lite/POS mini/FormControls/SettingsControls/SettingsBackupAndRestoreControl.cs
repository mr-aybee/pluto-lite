using POS_mini.App_Code;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;
namespace POS_mini.FormControls.SettingsControls
{
    public partial class SettingsBackupAndRestoreControl : UserControl
    {
        // string FilePath { get; set; }
        string RestoreText { get; set; }

        public SettingsBackupAndRestoreControl()
        {
            InitializeComponent();
        }
        DBStorage DSB;

        public void Refresher()
        {
            DSB = new DBStorage();
            DSB.CustomerAccounts = DBCache.CustomerAccounts;
            DSB.Customers = DBCache.Customers;
            DSB.Invoices = DBCache.Invoices;
            DSB.Products = DBCache.Products;
            DSB.ProductTypes = DBCache.ProductTypes;
            DSB.SaleItems = DBCache.SaleItems;
            DSB.Sales = DBCache.Sales;
            DSB.Users = DBCache.User;
            DSB.VendorAccounts = DBCache.VendorAccounts;
            DSB.Vendors = DBCache.Vendors;
            DSB.DataUpto = System.DateTime.Now;

        }


        private void backupBTn_Click(object sender, System.EventArgs e)
        {
            var StorageFile = Newtonsoft.Json.JsonConvert.SerializeObject(DSB);
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = "backup";
            SFD.Filter = "(*.sdf)|*.sdf";
            SFD.RestoreDirectory = true;
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy("PlutoDB.sdf",SFD.FileName);
                Alert.Show("Backup Saved", Alert.alertType.success);
            }


        }

     
        private void restoreBtn_Click(object sender, System.EventArgs e)
        {
            
            DBStorage DS = new DBStorage();
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    Alert.Show("Checking Validity", Alert.alertType.success);
                    try
                    {
                        var conn = new SqlCeConnection(@"Data Source= "+OFD.FileName+";Password=malik@1234;");
                        if (conn.State != ConnectionState.Open)
                            conn.Open();
                        var table = new DataTable();
                        var cmd = conn.CreateCommand();
                        cmd.CommandText = "select * from Users";
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        table.Load(cmd.ExecuteReader());
                        
                        if (File.Exists("DBBackup.sdf")) 
                            File.Delete("DBBackup.sdf");
                        File.Copy("PlutoDB.sdf", "DBBackup.sdf"); 
                        File.Delete("PlutoDB.sdf");
                        File.Copy(OFD.FileName, "PlutoDB.sdf");
                        Alert.Show("Backup Restored", Alert.alertType.success);
                    }
                    catch(Exception r) { MessageBox.Show(r.Message); return; }

                }
            }
            catch { Alert.Show("Kindly Select The valid File", Alert.alertType.warning); }


        }
    }
}
