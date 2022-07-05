using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace POS_mini.FormControls.SettingsControls
{
    public partial class SettingsUpdateControl : UserControl
    {
        public SettingsUpdateControl()
        {
            InitializeComponent();
        }


        Models.DBEntities db = new Models.DBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlCeConnection(Models.DBEntities.conString + "; File mode = Read Only;SSCE:Temp File Directory=\"c:\\users\\\";");
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var table = new DataTable();
                var cmd = conn.CreateCommand();
                cmd.CommandText = richTextBox1.Text;
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                table.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = table;
            }
            catch (Exception t) { MessageBox.Show(t.Message); }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog svd = new SaveFileDialog();
                svd.Filter = "CSV file (*.csv)|*.csv";
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    string csv = string.Empty;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }
                    csv += "\r\n";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            csv += cell.Value.ToString().Replace(",", ";") + ',';
                        }
                        csv += "\r\n";
                    }
                    File.WriteAllText(svd.FileName, csv);
                    MessageBox.Show("File Exported");
                }
            }
            catch (Exception t) { MessageBox.Show(t.Message); }
        }
    }
}
