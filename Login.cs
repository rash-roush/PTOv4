using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PTOv4
{
    public partial class DBHandler : Form
    {
        public DBHandler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=PTODB;Integrated Security=True;Encrypt=True");

        private void DBHandler_Load(object sender, EventArgs e)
        {
            // Load logic if needed
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String EmpID, Password;

            EmpID = txt_username.Text;
            Password = txt_password.Text;

            // Use 'using' blocks for automatic disposal of resources
            using (conn)
            {
                // Adjust the query to match the columns in your "Employee" table
                String query = "SELECT EmpPos FROM Employee WHERE EmpID = @EmpID AND Password = @Password";

                try
                {
                    conn.Open(); // Open the connection

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", EmpID); // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtable = new DataTable();
                            sda.Fill(dtable); // Fill the table with the results

                            if (dtable.Rows.Count > 0)
                            {
                                string EmpPos = dtable.Rows[0]["EmpPos"].ToString(); // Assuming 'EmpPos' is a column in your 'Employee' table

                                switch (EmpPos)
                                {
                                    case "Employee":
                                        MenuPageEmployee menuPageEmployee = new MenuPageEmployee();
                                        menuPageEmployee.Show();
                                        this.Hide();
                                        break;
                                    case "Manager":
                                        MenuPageManager menuPageManager = new MenuPageManager();
                                        menuPageManager.Show();
                                        this.Hide();
                                        break;
                                    case "Human Resource":
                                        MenuPageHumanResource menuPageHumanResource = new MenuPageHumanResource();
                                        menuPageHumanResource.Show();
                                        this.Hide();
                                        break;
                                    default:
                                        MessageBox.Show("Unknown position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_username.Clear();
                                txt_username.Focus();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred accessing the database: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Ensure the connection is always closed
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selected index change if necessary
        }
    }
}
