using BandB.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BandB
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        Models.DbContext db = new Models.DbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = db.DbConnection();
            string partName = txtPartName.Text;
            string hRNo = txtHRNo.Text;
            string partNo = txtPartNo.Text;


            if (partName == "" || hRNo == "" || partNo == "" || txtPurchaseRate.Text == "" || txtSellRate.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Empty text Box check again");
            }
            else
            {
                try
                {
                    decimal purchaseRate = decimal.Parse(txtPurchaseRate.Text);
                    decimal sellRate = decimal.Parse(txtSellRate.Text);
                    int stock = int.Parse(txtStock.Text);
                    cmd = new SqlCommand($"INSERT INTO Products(PartName, HRNo, PartNo, PurchaseRate, SellRate, Stock, dateAndTime)" +
                        $"VALUES('{partName}','{hRNo}','{partNo}','{purchaseRate}','{sellRate}','{stock}',GETDATE())", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    db.insertBuyOrSell(stock, 0, db.getId(partName), db.getStock(partName));
                    MessageBox.Show("Database Updated");
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database got into Problem " + ex.Message);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtPartName.Text = txtHRNo.Text = txtPartNo.Text = txtPurchaseRate.Text = txtSellRate.Text = txtStock.Text = "";
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            SearchProducts products = new SearchProducts();
            products.Show();
        }
    }
}