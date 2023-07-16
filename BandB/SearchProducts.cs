using BandB.Models;
using Microsoft.VisualBasic;
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
    public partial class SearchProducts : Form
    {
        DbContext db = new DbContext();
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adptr;
        int? Id;

        public SearchProducts()
        {
            InitializeComponent();
            updateDelete.Visible = false;
            display();
        }

        public void display()
        {
            try
            {

                SqlConnection con = db.DbConnection();
                dt = new DataTable();
                adptr = new SqlDataAdapter("select ProductId,PartName,HRNo,PartNo,SellRate,Stock from Products", con);
                adptr.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showPurchaseRate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db.DbConnection();
                dt = new DataTable();
                adptr = new SqlDataAdapter("select ProductId,PartName,HRNo,PartNo,PurchaseRate,SellRate,Stock from Products", con);
                adptr.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string partName = txtSearchProduct.Text;
            try
            {
                SqlConnection con = db.DbConnection();
                dt = new DataTable();

                adptr = new SqlDataAdapter($"select ProductId,PartName,HRNo,PartNo,PurchaseRate,SellRate,Stock from Products " +
                    $"where PartName like '%{partName}%' OR PartNo LIKE '%{partName}%'", con);
                adptr.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateAndDelete(object sender, DataGridViewCellEventArgs e)
        {
            showPurchaseRate_Click(sender, e);
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPartNameUD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHRNoUD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPartNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSellRateUD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPurchaseRateUD.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            updateDelete.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            updateDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db.DbConnection();
                cmd = new SqlCommand($"Delete from Products where ProductId = '{Id}'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successful.");
                updateDelete.Visible = false;
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db.DbConnection();
                cmd = new SqlCommand(($"UPDATE Products SET PartName='{txtPartNameUD.Text}', HRNo='{txtHRNoUD.Text}', " +
                    $"PartNo='{txtPartNo.Text}', PurchaseRate={txtPurchaseRateUD.Text}, " +
                    $"SellRate={txtSellRateUD.Text}, Stock={txtStock.Text} where ProductId={Id}"), con);
                cmd.ExecuteNonQuery();
                con.Close();
                db.insertBuyOrSell(int.Parse(txtStock.Text), 0, db.getId(txtPartNo.Text), db.getStock(txtPartNo.Text));
                MessageBox.Show("Update Successful.");
                updateDelete.Visible = false;
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
