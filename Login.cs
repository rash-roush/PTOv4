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
        private SqlConnection conn;
        public DBHandler()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=PTODB;Integrated Security=True;TrustServerCertificate=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=PTODB;Integrated Security=True;TrustServerCertificate=True");
        }
        


        private void DBHandler_Load(object sender, EventArgs e)
        {
            // Load logic if needed
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string EmpID = txt_username.Text;
            string Password = txt_password.Text;
            string selectedRole = "";

            // Assuming only one item can be checked and it corresponds to the role
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                selectedRole = checkedListBox1.Items[index].ToString(); // Get the selected role
                break; // Since only one role should be selected, we break after getting the first checked item
            }

            using (conn)
            {
                string query = "SELECT EmpPos FROM Employee WHERE EmpID = @EmpID AND Password = @Password";

                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", EmpID);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtable = new DataTable();
                            sda.Fill(dtable);

                            if (dtable.Rows.Count > 0)
                            {
                                string EmpPos = dtable.Rows[0]["EmpPos"].ToString();

                                // Check if the selected role from the CheckedListBox matches the EmpPos from the database
                                // Assuming that selectedRole and EmpPos have been properly assigned values from the UI and database respectively.
                                if (checkedListBox1.CheckedIndices.Count == 0)
                                {
                                    MessageBox.Show("Please select a role to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Stop the login process as no role is selected
                                }

                                // Continue with the rest of the login process...

                                if ((selectedRole.Equals("Employee") && EmpPos.Equals("Employee")) ||
                                    (selectedRole.Equals("Manager") && EmpPos.Equals("Manager")) ||
                                    (selectedRole.Equals("Human Resources") && EmpPos.Equals("HR"))) // Use "HR" if this is the value in the database
                                {
                                    // Open the corresponding form based on the selectedRole
                                    switch (selectedRole)
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
                                        case "Human Resources": // Text as shown in the CheckedListBox
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
                                    MessageBox.Show("Role selection does not match database records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    conn.Close(); // Always close the connection
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
