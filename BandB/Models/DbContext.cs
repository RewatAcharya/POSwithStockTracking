using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BandB.Models
{
    public class DbContext
    {
        public SqlConnection DbConnection()
        {
            string path = @"Data Source=DESKTOP-2TPLGS3\SQLEXPRESS;Initial Catalog=BandBEnterprises;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } 
            return con;
        }

        public int getId(string nameofpart)
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"SELECT ProductId FROM Products WHERE PartNo = '{nameofpart}'", con);
            int productId = (int)cmd.ExecuteScalar();
            return productId;
        }

        public int getBillMaxId()
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"SELECT MAX(id) FROM Bills;", con);
            int id = (int)cmd.ExecuteScalar();
            return id;
        }

        public List<string> getName()
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"SELECT PartName FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> productIds = new List<string>();
            while (reader.Read())
            {
                string? partName = reader["PartName"].ToString();
                productIds.Add(partName);
            }
            reader.Close();
            return productIds;
        }

        public decimal getPrice(int id)
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"SELECT SellRate FROM Products WHERE ProductId = '{id}'", con);
            decimal price = (decimal)cmd.ExecuteScalar();
            return price;
        }
        public int getStock(string name)
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"SELECT Stock FROM Products WHERE PartNo = '{name}'", con);
            int stock = (int)cmd.ExecuteScalar();
            return stock;
        }

        public void setStock(string name, int stock) 
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"UPDATE Products SET Stock = '{stock}' WHERE PartNo = '{name}'", con);
            cmd.ExecuteNonQuery(); 
            con.Close();
        }
        public void insertBuyOrSell(int BuyNumber, int SellNumber, int ProductId, int UpdatedStock)
        {
            SqlConnection con = DbConnection();
            SqlCommand cmd = new SqlCommand($"Insert into BuyOrSellProduct(BuyNumber, SellNumber, ProductId, UpdatedStock) values ({BuyNumber},{SellNumber},{ProductId}, {UpdatedStock})", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
