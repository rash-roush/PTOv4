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
        SqlConnection conn = new SqlConnection(@"Data Source=LUUNA;Initial Catalog=PTOv4;Integrated Security=True;Encrypt=False");
        //Data Source=LUUNA;Initial Catalog=PTOv4;Integrated Security=True;Encrypt=False;Trust Server Certificate=True
        //C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PTOv4.mdf
        //C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PTOv4.mdf
        //Data Source=LUUNA;Initial Catalog=PTOv4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        private void DBHandler_Load(object sender, EventArgs e)
        {
            // Load logic if needed
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //login/enter button
            //login/enter button
            string username = txt_username.Text.Trim(); // Trim to remove any leading or trailing white spaces
            string user_password = txt_password.Text; // Assuming you will implement hashing later

            try
            {
                // Using parameterized queries to prevent SQL Injection
                string query = "SELECT * FROM Login_new WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", user_password); // Ideally, compare hashed passwords

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    //page that need to load next
                   /* Menu1 MenuPageEmployee = new Menu1();
                    MenuPageEmployee.Show();
                    this.Hide();*/
                }
                else
                {
                    MessageBox.Show("Username or password not correct.");//improve message here
                }
                    txt_username.Clear();
                    txt_password.Clear();

                    //to focus username
                    txt_username.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex.Message);
            }

            finally
            {
                conn.Close();
            }

        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selected index change if necessary
            //string EmpPos = dtable.Rows[0]["EmpPos"].ToString();
           /* switch 
            {
                case "Employee":
                    Menu1 menuPageEmployee = new Menu1();
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
            }*/

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
