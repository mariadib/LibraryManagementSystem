using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public Login()
        {
            InitializeComponent();
        }
        void loginform()
        {
            string query = $"SELECT * FROM [dbo].[Users] WHERE username='{txt_users.Text}' AND password='{txt_passwords.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful");
                    ManagenentSystem nextForm = new ManagenentSystem();
                    nextForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            loginform();

        }

        private void txt_users_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp nextForm = new SignUp();
            nextForm.Show();
            this.Close();
        }

        private void lb_forgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Resetpass r=new Resetpass();
            r.Show();
            this.Close();
        }
    }
}
