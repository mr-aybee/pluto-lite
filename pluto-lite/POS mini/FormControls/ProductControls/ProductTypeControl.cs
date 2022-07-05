using POS_mini.App_Code;
using System;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.ProductControls
{
    public partial class ProductTypeControl : UserControl
    {
        Models.ProductType PT = new Models.ProductType();
        public ProductTypeControl()
        {
            InitializeComponent();

            bunifuCustomDataGrid1.Rows.Clear();
            DBCache.ProductTypes.ForEach(X =>
            {
                bunifuCustomDataGrid1.Rows.Add(X.ID, X.Type, "show");
            });
            pTypeTxt.text = "";
            typeEditTxt.text = "";
        }

        public void Refresher()
        {
            bunifuCustomDataGrid1.Rows.Clear();
            DBCache.ProductTypes.ForEach(X =>
            {
                bunifuCustomDataGrid1.Rows.Add(X.ID, X.Type, "show");
            });
            pTypeTxt.text = "";
            typeEditTxt.text = "";

        }

    protected override bool ProcessCmdKey(ref Message message, Keys keys)
    {
        switch (keys)
        {
            case Keys.Control | Keys.S:
                {
                    var beta = pTypeTxt.text;
                    var alpha = beta.Replace("\r", "").Replace("\n", "");
                    if (string.IsNullOrEmpty(alpha) || alpha == "")
                    {
                        Alert.Show("Kindly Enter Any Type First", Alert.alertType.warning);
                        return true;
                    }
                    using (Models.DBEntities db = new Models.DBEntities())
                    {
                        db.ProductTypes.Add(new Models.ProductType
                        {
                            Type = alpha
                        });
                        db.SaveChanges();
                        Alert.Show(alpha + " Saved", Alert.alertType.success);
                    }
                    Refresher();
                    return true;
                }
        }
        return base.ProcessCmdKey(ref message, keys);
    }

    private void productAddBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(pTypeTxt.text))
            {
                Alert.Show("Kindly Enter Any Type First", Alert.alertType.warning);
                return;
            }
            using (Models.DBEntities db = new Models.DBEntities())
            {
                var alreadyType = db.ProductTypes.FirstOrDefault(X => X.Type == pTypeTxt.text);
                if (alreadyType != null) { Alert.Show("Product Type already Exists With Same Name", Alert.alertType.warning); }
                db.ProductTypes.Add(new Models.ProductType
                {
                    Type = pTypeTxt.text
                });
                db.SaveChanges();
                Alert.Show(pTypeTxt.text + " Saved", Alert.alertType.success);
                Refresher();
            }
        }
        catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
    }



    private void pTypeTxt_OnTextChange(object sender, EventArgs e)
    {
        try
        {
            if (pTypeTxt.text.EndsWith("\n"))
            {
                var beta = pTypeTxt.text;
                var alpha = beta.Replace("\r", "").Replace("\n", "");
                if (string.IsNullOrEmpty(alpha) || alpha == "")
                {
                    Alert.Show("Kindly Enter Any Type First", Alert.alertType.warning);
                    return;
                }
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    db.ProductTypes.Add(new Models.ProductType
                    {
                        Type = alpha
                    });
                    db.SaveChanges();
                    Alert.Show(alpha + " Saved", Alert.alertType.success);
                }
                Refresher();
            }
        }
        catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
    }


    private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (e.ColumnIndex == 2)
            {
                if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString() != null || bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    PT = DBCache.ProductTypes.Find(X => X.ID == int.Parse(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    typeEditTxt.text = PT.Type;
                    typeDescriptionText.Text = "Type ID: " + PT.ID + "\n" +
                                                "Products Registered: " + DBCache.Products.FindAll(X => X.TypeID == PT.ID).Count;

                }
            }
        }
        catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
    }

    private void typeSearchBox_OnTextChange(object sender, EventArgs e)
    {
        try
        {
            bunifuCustomDataGrid1.Rows.Clear();
            DBCache.ProductTypes.FindAll(X => X.Type.ToLower().Contains(typeSearchBox.text.ToLower())).ForEach(X =>
            {
                bunifuCustomDataGrid1.Rows.Add(X.ID, X.Type, "show");
            });
        }
        catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
    }

    private void UpdateBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (CustomControls.CustomMessageBox.ShowDialog(this, "Are yout Sure you want to update this type") == DialogResult.Yes)
            {
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    PT.Type = typeEditTxt.text;
                    db.ProductTypes.Attach(PT);
                    db.Entry(PT).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Alert.Show("Product Type Updated", Alert.alertType.success);
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
            if (CustomControls.CustomMessageBox.ShowDialog(this, "Are yout Sure You Want to Delete this type. All Products Registered With It Will Be Set To Rand Type") == DialogResult.Yes)
            {
                using (Models.DBEntities db = new Models.DBEntities())
                {
                    PT.Type = typeEditTxt.text;
                    db.ProductTypes.Remove(db.ProductTypes.FirstOrDefault(X => X.ID == PT.ID));
                    db.SaveChanges();
                    Alert.Show("Product Type Deleted", Alert.alertType.success);
                    Refresher();
                }
            }
        }
        catch (Exception t) { Alert.Show(t.Message, Alert.alertType.warning); }
    }
}
}
