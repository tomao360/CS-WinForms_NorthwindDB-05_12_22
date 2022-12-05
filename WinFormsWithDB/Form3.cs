using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWithDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        const string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\SQLEXPRESS";

        Hashtable tbl = new Hashtable();
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection - creating a connection to connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";

                    // Adapter
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        // Reader - reading data from Products table in Northwind DB
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productId = reader.GetInt32(reader.GetOrdinal("ProductID"));
                                string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                                decimal unitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice"));
                                int unitsInStock = reader.GetInt16(reader.GetOrdinal("UnitsInStock"));

                                Product product = new Product(productId, productName, unitPrice, unitsInStock);

                                // Adding the Product class show to hash table
                                tbl.Add(productId, product);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retrieveAnItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(productNumTextBox.Text);

                if (tbl.ContainsKey(productId) && tbl[productId] is Product)
                {
                    Product product = (Product)tbl[productId];

                    productNameLabel.Text = product.ProductName;
                    priceLabel.Text = product.UnitPrice.ToString();
                    unitsInStockLabel.Text = product.UnitsInStock.ToString(); 
                }
                else
                {
                    MessageBox.Show("There is no product with this ProductID\n Please enter another ProductID");
                }
            }
            catch
            {
                MessageBox.Show("The Table is empty. Please enter the Refresh button");
            }
        }

        private void howManyProductsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal unitPrice = decimal.Parse(unitPriceTextBox.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string queryString = "select count(ProductId) from Products where UnitPrice >" + unitPrice;

                        using (SqlCommand command = new SqlCommand(queryString, connection))
                        {
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                reader.Read();
                                int productId = reader.GetInt32(0);
                                MessageBox.Show("The number of products that cost more than" + " " + unitPrice + " " + "are:" + " " + productId.ToString());
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("The Table is empty. Please enter the Refresh button");
            }
        }
    }
}
