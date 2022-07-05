using POS_mini.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POS_mini.FormControls.ProductControls
{
    public partial class ProductControl : UserControl
    {
        Models.Product Prod = new Models.Product();
        List<Thread> BGGridFiller = new List<Thread>();
        Models.DBEntities db = new Models.DBEntities();
        public ProductControl()
        {
            InitializeComponent();
            BGGridFiller = new List<Thread>();
            Refresher();
        }

        public void Refresher()
        {
            try
            {
                bunifuCustomDataGrid1.Rows.Clear();
                pTypeCombo.DataSource = db.ProductTypes.OrderBy(X => X.Type).Select(X => X.Type).ToList();
                descriptionTxt.Text = "";
                pAlertLevelTxt.Text = "0";
                pBarcodeTxt.Text = "";
                pSalePriceTxt.Text = "0";
                pNameTxt.Text = "";
                RefreshGridBtn_Click(null, null);
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void pBarcodeTxt_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            addProduct();
        }

        private void addProduct()
        {
            try
            {
                if (pNameTxt.Text == "" || pTypeCombo.Text == "" || pSalePriceTxt.Text == "" || pAlertLevelTxt.Text == "")
                {
                    Alert.Show("Kindly Fill All Starred Values", Alert.alertType.warning); return;
                }
                try { var d = int.Parse(pAlertLevelTxt.Text); }
                catch { Alert.Show("Alert Quantity Can Only Be integer", Alert.alertType.warning); return; }
                try { var d = Double.Parse(pSalePriceTxt.Text); }
                catch { Alert.Show("Sale Price Can Only Be Numeric With Single Decimal Point", Alert.alertType.warning); return; }
                var pNameCheck = db.Products.FirstOrDefault(X => X.Name == pNameTxt.Text);

                if (pNameCheck != null) { Alert.Show("Product Already Saved", Alert.alertType.warning); return; }
                Prod = new Models.Product
                {
                    AlertLevel = int.Parse(pAlertLevelTxt.Text),
                    Barcode = pBarcodeTxt.Text,
                    Name = pNameTxt.Text,
                    SalePrice = double.Parse(pSalePriceTxt.Text),
                    Description = descriptionTxt.Text,
                    TypeID = db.ProductTypes.FirstOrDefault(X => X.Type == pTypeCombo.Text).ID,
                };
                db.Products.Add(Prod);
                db.SaveChanges();
                Alert.Show("Product Saved", Alert.alertType.success);
                Refresher();
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void pAlertLevelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
                    e.Handled = true;
                //if ((e.KeyChar == '.') && ((sender as Bunifu.Framework.UI.BunifuMaterialTextbox).Text.IndexOf('.') > -1))
                //    e.Handled = true;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }

        }

        private void pSalePriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    e.Handled = true;
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    e.Handled = true;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }
        Models.Product productModel = new Models.Product();

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    var rowID = int.Parse(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Prod = db.Products.FirstOrDefault(X => X.ID == rowID);
                    filFormOnShow();
                }
                if (e.ColumnIndex == 7)
                {
                    var rowID = int.Parse(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var p = db.Products.FirstOrDefault(X => X.ID == rowID);
                    var obj = new object[3];
                    obj[0] = Constants.ReportTypes.BarcodeSlip;
                    obj[1] = p.Barcode;
                    obj[2] = p.Name;
                    new Reports.Report(obj).Show();

                    //productModel = p;
                    //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("50 x 30 mm", 300, 150);
                    //PrintPreviewDialog ppvw = new PrintPreviewDialog();
                    //ppvw.Document = printDocument1;
                    //ppvw.ShowDialog();



                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            e.Graphics.DrawImage(barcode.Draw(productModel.Barcode, 100), 20, 20, 250, 100);
            e.Graphics.DrawString(productModel.Name + " (" + productModel.Barcode + ")", new Font("Arial", Convert.ToSingle(7.1), FontStyle.Bold), Brushes.Black, new Point(130, 135));
        }

        private void filFormOnShow()
        {
            try
            {
                if (Prod == null) return;
                pNameTxt.Text = Prod.Name;
                pTypeCombo.Text = DBCache.ProductTypes.Find(X => X.ID == Prod.TypeID).Type;
                pAlertLevelTxt.Text = Prod.AlertLevel.ToString();
                pBarcodeTxt.Text = Prod.Barcode;
                pSalePriceTxt.Text = Prod.SalePrice.ToString();
                descriptionTxt.Text = Prod.Description;
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Prod == null)
                {
                    Alert.Show("Kindly Select Any Product From Table", Alert.alertType.warning);
                    return;
                }
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure Update This Product") == DialogResult.Yes)
                {
                    Prod.Name = pNameTxt.Text;
                    try { var d = Int32.Parse(pAlertLevelTxt.Text); }
                    catch { Alert.Show("Alert Quantity Can Only Be Integer", Alert.alertType.warning); return; }
                    try { var d = Double.Parse(pSalePriceTxt.Text); }
                    catch { Alert.Show("Sale Price Can Only Be Numeric With Single Decimal Point", Alert.alertType.warning); return; }
                    Prod.SalePrice = Double.Parse(pSalePriceTxt.Text);
                    Prod.AlertLevel = Int32.Parse(pAlertLevelTxt.Text);
                    Prod.Barcode = pBarcodeTxt.Text;
                    Prod.TypeID = db.ProductTypes.FirstOrDefault(X => X.Type == pTypeCombo.Text).ID;
                    Prod.Description = descriptionTxt.Text;
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.Products.Attach(Prod);
                        db.Entry(Prod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        Alert.Show("Product Updates", Alert.alertType.success);
                        Prod = new Models.Product();
                        Refresher();
                    }
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Prod == null)
                {
                    Alert.Show("Kindly Select Any Product From Table", Alert.alertType.warning);
                    return;
                }
                if (CustomControls.CustomMessageBox.ShowDialog(this, "Are You Sure You Want To Delete This Product. This Will also effect Sales Record.") == DialogResult.Yes)
                {
                    db.Products.Remove(db.Products.FirstOrDefault(X => X.ID == Prod.ID));
                    db.SaleItems.Where(X => X.ProductID == Prod.ID).ToList().ForEach(X =>
                    {
                        db.SaleItems.Remove(X);
                    });
                    db.SaveChanges();
                    Alert.Show("Product Removed and all its sales", Alert.alertType.success);
                    Refresher();
                }
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void pSearchBox_OnTextChange(object sender, EventArgs e)
        {
            try
            {

                var psearch = pSearchBox.text.ToLower();
                bunifuCustomDataGrid1.Rows.Clear();
                BGGridFiller.ForEach(X => X.Abort());
                BGGridFiller.Clear();
                BGGridFiller.Add(new Thread(new ThreadStart(delegate
                {
                    var products = db.Products
                    .Where(X => X.Name.ToLower().Contains(psearch) || X.Barcode.ToLower().Contains(psearch)).ToList();
                    var pTypes = DBCache.ProductTypes;
                    products.ForEach(X =>
                    {
                        Invoke(new Action(delegate
                        {
                            try
                            {
                                bunifuCustomDataGrid1.Rows.Add(X.ID, X.Name, pTypes.Find(C => C.ID == X.TypeID).Type, X.AlertLevel, X.SalePrice, X.Barcode, "show");
                            }
                            catch { }
                        }));
                    });

                })));
                BGGridFiller.ForEach(X => X.Start());
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            try
            {
                switch (keys)
                {
                    case Keys.Alt | Keys.A:
                        {
                            addProduct();
                            Refresher();
                            return true;
                        }
                    case Keys.Alt | Keys.S:
                        {
                            pSearchBox.Focus();
                            Refresher();
                            return true;
                        }
                }
                return base.ProcessCmdKey(ref message, keys);
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); return false; }
        }



        private void RefreshGridBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomDataGrid1.Rows.Clear();
                fillGridProgress.Show();
                BGGridFiller.ForEach(X => X.Abort());
                BGGridFiller.Clear();
                BGGridFiller.Add(
                new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        var nonDeletedProducts = db.Products.ToList();
                        var pTypes = db.ProductTypes.ToList();
                        var productCountForP = nonDeletedProducts.Count;
                        Invoke(new Action(delegate { fillGridProgress.Maximum = productCountForP; fillGridProgress.Value = 0; }));
                        nonDeletedProducts.ForEach(X =>
                        {
                            Invoke(new Action(delegate { fillGridProgress.Value += 1; }));
                            if (pTypes.Exists(C => C.ID == X.TypeID))
                                Invoke(new Action(delegate
                                {
                                    bunifuCustomDataGrid1.Rows.Add(X.ID, X.Name, pTypes.Find(C => C.ID == X.TypeID).Type, X.AlertLevel, X.SalePrice, X.Barcode, "Edit", "Print Barcode");
                                }));
                        });
                        Invoke(new Action(delegate { fillGridProgress.Hide(); }));
                    }
                    catch { }
                })));
                BGGridFiller.ForEach(X => X.Start());
            }
            catch { }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                pBarcodeTxt.Text = App_Code.Constants.GetRandomString(10);
                pBarcodeTxt_KeyDown(null, null);
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
        }

        private void pBarcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (pBarcodeTxt.Text == "") { Alert.Show("Kindly Generate any Barcode By Clicking on NEW button", Alert.alertType.warning); return; }
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barcodeImage.Image = barcode.Draw(pBarcodeTxt.Text, 50);
            }
            catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }

        }

        private void btnUPCustomBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pSalePriceTxt.Text))
            {
                Alert.Show("Please enter sale amount", Alert.alertType.warning);
                return;
            }
            string val = "";
            foreach (char c in pSalePriceTxt.Text.ToCharArray())
            {
                val += c + Constants.GetRandomString(1);
            }
            pBarcodeTxt.Text = val;
            pBarcodeTxt_KeyDown(null, null);
        }

    }
}
