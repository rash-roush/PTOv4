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

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String EmpID, Password;

            EmpID = txt_username.Text;
            Password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE Employee ID = ' "
                    + txt_username + "' AND password = '" + txt_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    EmpID = txt_username.Text;
                    Password = txt_password.Text;

                    //next page
                    MainPage MainPage = new MainPage();
                    MainPage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();

                    //to focus username
                    txt_username.Focus();
                }
            }
                catch
                 {
                     MessageBox.Show("Enter a valid Employee ID or Password.");
                  }
            finally 
            { 
            
                conn.Close();
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }
    }
}
