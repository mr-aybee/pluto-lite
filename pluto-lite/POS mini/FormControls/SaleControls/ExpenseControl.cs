using POS_mini.App_Code;
using POS_mini.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_mini.FormControls.SaleControls
{
    public partial class ExpenseControl : UserControl
    {
        Models.DBEntities db = new DBEntities();
        public ExpenseControl()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            amountTxt.Text = "0";
        }

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RefreshGridBtn_Click(object sender, EventArgs e)
        {
            var allExp = db.Expenses.ToList();
            FillGrid(allExp);
        }

        void FillGrid(List<Expense> exp)
        {
            ExpenseGrid.Rows.Clear();
            exp.ForEach(X =>
            {
                Application.DoEvents();
                ExpenseGrid.Rows.Add(X.id, X.Description, X.amount, X.DateTime, "Delete");
            });
        }

        private void cSearchTxt_OnTextChange(object sender, EventArgs e)
        {
            if (cSearchTxt.text == "") return;
            var filteredExp = db.Expenses.ToList().FindAll(X => X.Description.ToLower().Contains(cSearchTxt.text.ToLower()) || X.amount.ToString().Contains(cSearchTxt.text) || X.DateTime.ToString().Contains(cSearchTxt.text) );
            FillGrid(filteredExp);

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptionTxt.Text) && string.IsNullOrEmpty(amountTxt.Text))
            {
                Alert.Show("Kindly Fill Full Form", Alert.alertType.warning);
                return;
            }

            db.Expenses.Add(new Expense
            {
                amount = Convert.ToDouble(amountTxt.Text),
                DateTime = dateTimePicker1.Value,
                Description = descriptionTxt.Text,
                UserID = Constants.UserID
            });
            db.SaveChanges();
            Alert.Show("Expense Saved", Alert.alertType.success);
            var allExp = db.Expenses.ToList();
            FillGrid(allExp);
            descriptionTxt.Text = "";
            amountTxt.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ExpenseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var eID = int.Parse(ExpenseGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                db.Expenses.Remove(db.Expenses.FirstOrDefault(X => X.id == eID));
                db.SaveChanges();
                var allExp = db.Expenses.ToList();
                FillGrid(allExp);
                descriptionTxt.Text = "";
                amountTxt.Text = "0";
                dateTimePicker1.Value = DateTime.Now;
                Alert.Show("Removed", Alert.alertType.success); ;
            }
        }
    }
}
