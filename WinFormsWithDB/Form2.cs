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
    public partial class Form2 : Form
    {
        public Form2()
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
                    tbl.Clear();
                    string queryString = "select EmployeeID, (FirstName + ' ' + LastName) as empName from Employees";

                    // Adapter
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        // Reader - reading data from Employees table in Northwind DB
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int empID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                                string empName = reader.GetString(reader.GetOrdinal("empName"));

                                // Adding the Employee details to hash table
                                tbl.Add(empID, empName);
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

        private void showEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeID = int.Parse(empIdTextBox.Text);

                if (tbl.ContainsKey(employeeID))
                {
                    string empName = tbl[employeeID].ToString();
                    MessageBox.Show(empName, "Employee Name");
                }
                else
                {
                    MessageBox.Show("There is no emplyee with this EmployeeID\n Please enter another EmployeeID");
                }
            }
            catch
            {
                MessageBox.Show("The Table is empty. Please enter the Refresh button");
            }
        }
    }
}
