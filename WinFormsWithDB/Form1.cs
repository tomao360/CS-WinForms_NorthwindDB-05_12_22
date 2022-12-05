using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\SQLEXPRESS";
        private void orderNum_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection - creating a connection to connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "select count(*) as 'OrderNum' from Orders";

                    // Adapter
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        // Reader - reading data from Orders table in Northwind DB
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int orderNum = reader.GetInt32(reader.GetOrdinal("OrderNum"));
                                orderNumTextBox.Text = orderNum.ToString();
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

        private void customerNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "select count(*) as 'CustomersNum' from Customers";

                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int customersNum = reader.GetInt32(reader.GetOrdinal("CustomersNum"));
                                MessageBox.Show(customersNum.ToString(), "Number of Customers");
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
    }
}
