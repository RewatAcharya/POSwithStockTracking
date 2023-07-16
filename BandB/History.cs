using BandB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandB
{
    public partial class History : Form
    {
        DbContext db = new DbContext();
        DataTable dt;
        SqlDataAdapter adptr;

        public History()
        {
            InitializeComponent();
            display();
        }

        public void display()
        {
            try
            {
                SqlConnection con = db.DbConnection();
                dt = new DataTable();
                adptr = new SqlDataAdapter("SELECT D.Date, P.PartName, D.BuyNumber, D.SellNumber, D.UpdatedStock " +
                    "FROM Products P JOIN BuyOrSellProduct D ON P.ProductId = D.ProductId ORDER BY D.Date ASC", con);
                adptr.Fill(dt);
                dataHistroy.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Hiiii");
            }

        }

        private void History_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataHistroy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db.DbConnection();
                dt = new DataTable();
                adptr = new SqlDataAdapter($"SELECT D.Date, P.PartName, D.BuyNumber, D.SellNumber, D.UpdatedStock " +
                    $"FROM Products P JOIN BuyOrSellProduct D ON P.ProductId = D.ProductId where P.PartName like '%{txtSearchProduct.Text}%'", con);
                adptr.Fill(dt);
                dataHistroy.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Hiiii");
            }
        }
    }
}
