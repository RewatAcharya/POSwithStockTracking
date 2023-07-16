using BandB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing.Printing;

namespace BandB
{
    public partial class Sell : Form
    {
        DataTable dt;
        SqlDataAdapter adptr;

        DbContext dbContext = new DbContext();

        List<Sales> saleList = new List<Sales>();

        

        public Sell()
        {
            InitializeComponent();
        }


        public decimal TotalPrice()
        {  
            decimal totalPrice = 0;
            foreach (Sales sales in saleList)
            {
                totalPrice += sales.Price;
            }
            return totalPrice;
        }

        public void BtnClearSell()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPartNameSell.Text = string.Empty;
            txtSearchProduct.Text = string.Empty;
            txtStockSell.Text = string.Empty;
            txtPricePerPiece.Text = string.Empty;
            txtPrice.Text = string.Empty;
            dateTime.Text = DateTime.Today.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BtnClearSell();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            
            if ((txtPartNameSell.Text == string.Empty || txtStockSell.Text == string.Empty || txtPrice.Text == string.Empty) && saleList.Count <= 0)
            {
                MessageBox.Show("Add Something to checkout", "Error");
            }
            else
            {
                button1_Click(sender, e);
            }
            if (saleList.Count > 0)
            {
                panelSellNow.Visible = true;
                decimal totalPrice = 0;
                foreach (Sales sales in saleList)
                {
                    totalPrice += sales.Price;
                }
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            ListProducts();
            panelSellNow.Visible = false;
        }

        private void txtPartNameSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStockSell.Text = string.Empty;
            txtPricePerPiece.Text = string.Empty;
            txtPrice.Text = string.Empty;
            int id = dbContext.getId(txtPartNo.Text);
            decimal price = dbContext.getPrice(id);
            txtPricePerPiece.Text = price.ToString();

        }

        private void txtStockSell_TextChanged(object sender, EventArgs e)
        {

            if (txtStockSell.Text == string.Empty)
            {
                return;
            }
            if (!int.TryParse(txtStockSell.Text, out int result))
            {
                MessageBox.Show($"Only Number in this field.\nYou provided {txtStockSell.Text}");
                txtStockSell.Text = string.Empty;
            }
            else if (int.Parse(txtStockSell.Text) > dbContext.getStock(txtPartNo.Text))
            {
                MessageBox.Show($"You have {dbContext.getStock(txtPartNo.Text)} stock only.");
                txtStockSell.Text = string.Empty;
                txtPrice.Text = string.Empty;
            }
            else
            {
                int stock = int.Parse(txtStockSell.Text);
                decimal pricePerItem = decimal.Parse(txtPricePerPiece.Text);
                txtPrice.Text = (pricePerItem * stock).ToString();
            }
        }


        public void generateBill()
        {
            string query = "INSERT INTO Bills (CustomerName, Address, Discount, TotalPrice, Date) " +
              "VALUES (@Name, @Address, @discount, @totalPrice, @date)";
            decimal totalPrice = 0;
            foreach (Sales sales in saleList)
            {
                totalPrice += sales.Price;
            }
            if (txtDiscount.Text == string.Empty)
            {
                txtDiscount.Text = "0";
            }
            totalPrice -= decimal.Parse(txtDiscount.Text);
            using (SqlConnection connection = dbContext.DbConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@Name", SqlDbType.VarChar);
                command.Parameters.Add("@Address", SqlDbType.VarChar);
                command.Parameters.Add("@discount", SqlDbType.Decimal);
                command.Parameters.Add("@totalPrice", SqlDbType.Decimal);
                command.Parameters.Add("@date", SqlDbType.Date);

                command.Parameters["@Name"].Value = txtCustomerName.Text;
                command.Parameters["@Address"].Value = txtAddress.Text;
                command.Parameters["@discount"].Value = decimal.Parse(txtDiscount.Text);
                command.Parameters["@totalPrice"].Value = totalPrice;
                command.Parameters["@date"].Value = DateTime.Today;

                command.ExecuteNonQuery();
                connection.Close();
            }

        }


        private void BindSalesToGrid()
        {
            // Clear existing rows in the DataGridView
            sellPointGrid.Rows.Clear();

            // Iterate over the salesList and add rows to the DataGridView
            foreach (Sales sales in saleList)
            {
                sellPointGrid.Rows.Add(sales.Name, sales.Address, sales.PartName, sales.Stock.ToString(),
                                       sales.PricePerPiece.ToString(), sales.Price.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPartNameSell.Text == string.Empty || txtStockSell.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Fill the fields");
                return;
            }
            Sales sales = new Sales();
            sales.Name = txtCustomerName.Text;
            sales.Address = txtAddress.Text;
            sales.PartName = txtPartNameSell.Text;
            sales.PartNo = txtPartNo.Text;
            sales.Stock = int.Parse(txtStockSell.Text);
            sales.PricePerPiece = decimal.Parse(txtPricePerPiece.Text);
            sales.Price = decimal.Parse(txtPrice.Text);
            saleList.Add(sales);

            if (saleList.Count > 0)
            {
                BindSalesToGrid();
                txtPartNo.Text = string.Empty;
                txtSearchProduct.Text = string.Empty;
                txtPartNameSell.Text = string.Empty;
                txtStockSell.Text = string.Empty;
                txtPricePerPiece.Text = string.Empty;
                txtPrice.Text = string.Empty;
            }
            

        }

        private void clearList_Click(object sender, EventArgs e)
        {
            saleList.Clear();
            sellPointGrid.Rows.Clear();
        }
        public void StoreSell()
        {
            string query = "INSERT INTO Sales (Stock, Price, Productid, BillId) " +
               "VALUES (@Stock, @Price, @ProductId, @BillId)";

            using (SqlConnection connection = dbContext.DbConnection())
            {
                if (saleList.Count > 0)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@Stock", SqlDbType.Int);
                    command.Parameters.Add("@Price", SqlDbType.Decimal);
                    command.Parameters.Add("@ProductId", SqlDbType.Int);
                    command.Parameters.Add("@BillId", SqlDbType.Int);


                    foreach (Sales sales in saleList)
                    {
                        // Set parameter values for each sales object
                        command.Parameters["@Stock"].Value = sales.Stock;
                        command.Parameters["@Price"].Value = sales.Price;
                        command.Parameters["@ProductId"].Value = dbContext.getId(sales.PartNo);
                        command.Parameters["@BillId"].Value = dbContext.getBillMaxId();

                        dbContext.setStock(sales.PartNo, dbContext.getStock(sales.PartNo) - sales.Stock);
                        command.ExecuteNonQuery(); // Execute the insert query for each sales object
                        dbContext.insertBuyOrSell(0, sales.Stock, dbContext.getId(sales.PartNo), dbContext.getStock(sales.PartNo));


                    }
                    saleList.Clear();
                    connection.Close();


                    MessageBox.Show("Insert sucess");

                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Nothing to Sell", "Not Sold");
                }

            }

        }

        public void ListProducts()
        {
            SqlConnection con = dbContext.DbConnection();

            dt = new DataTable();

            adptr = new SqlDataAdapter($"select PartName, PartNo, Stock, SellRate from Products", con);
            adptr.Fill(dt);
            ProductListView.DataSource = dt;
        }


        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string partName = txtSearchProduct.Text;
            try
            {
                SqlConnection con = dbContext.DbConnection();
                dt = new DataTable();

                adptr = new SqlDataAdapter($"select PartName,PartNo, Stock, SellRate from Products " +
                    $"where PartName like '%{partName}%' OR PartNo LIKE '%{partName}%'", con);
                adptr.Fill(dt);
                ProductListView.DataSource = dt;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductListView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPartNameSell.Text = ProductListView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPartNo.Text = ProductListView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPricePerPiece.Text = ProductListView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void panelSellNow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSellNow.Visible = false;
        }

        private void btnActualSell_Click(object sender, EventArgs e)
        {
            generateBill();
            StoreSell();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            if (txtDiscount.Text == string.Empty)
            {
                txtTotalPrice.Text = TotalPrice().ToString();
                return;
            }
            if (!decimal.TryParse(txtDiscount.Text, out decimal result))
            {
                MessageBox.Show($"Only Number in this field.\nYou provided {txtDiscount.Text}");
                txtDiscount.Text = string.Empty;
            }
            else
            {
                decimal discount = decimal.Parse(txtDiscount.Text);
                txtTotalPrice.Text = (TotalPrice() - discount).ToString();
            }
        }

        private void sellPointGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            saleList.RemoveAt(e.RowIndex);
            BindSalesToGrid();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set the font style and size
            Font font = new Font("Arial", 16, FontStyle.Regular);

            // Set the position of the text
            int x = 50;
            int y = 50;

            // Draw the text on the page
            e.Graphics.DrawString("B&B Enterprises", font, Brushes.Black, x, y);
            e.Graphics.DrawString("Sundarharaincha Morang", font, Brushes.Black, x, y + 25);

            // Draw the invoice data
            y += 50;
            e.Graphics.DrawString($"Customer Name: {txtCustomerName.Text}", font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Order Date: {DateTime.Now}", font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Order Number: {dbContext.getBillMaxId()}", font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Product Name: ", font, Brushes.Black, x, y);
            x += 200;
            e.Graphics.DrawString("Quantity: ", font, Brushes.Black, x, y);
            x += 100;
            e.Graphics.DrawString("Price: ", font, Brushes.Black, x, y);
            foreach (Sales sales in saleList)
            {
                x = 50;
                y += 20;
                e.Graphics.DrawString($"{sales.PartName}", font, Brushes.Black, x, y);
                x += 200;
                e.Graphics.DrawString($"{sales.Stock}", font, Brushes.Black, x, y);
                x += 100;
                e.Graphics.DrawString($"{sales.Price}", font, Brushes.Black, x, y);
            }
            x = 50;
            y += 40;
            e.Graphics.DrawString($"Discount: {txtDiscount.Text}", font, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString($"Total: {txtTotalPrice.Text}", font, Brushes.Black, x, y);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            generateBill();
            // Set the printer settings
            printDocument1.PrinterSettings = new PrinterSettings();

            // Show the print preview dialog
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


            StoreSell();
            txtTotalPrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            sellPointGrid.Rows.Clear();
            ListProducts();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
