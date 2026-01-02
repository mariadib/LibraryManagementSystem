using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace LibraryManagementSystem
{
    public partial class SignUp : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public SignUp()
        {
            InitializeComponent();
        }
        void AddUser()
        {

            string query = $"INSERT INTO [dbo].[Users] ([username] ,[email] ,[password]) VALUES ({txt_username.Text},{txt_emails.Text},{txt_password.Text})";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
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

        private void btn_signup_Click(object sender, EventArgs e)
        {
            AddUser();
            ManagenentSystem nextForm = new ManagenentSystem();
            nextForm.Show();
            this.Hide();

        }

        private void lb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login redirect = new Login();
            redirect.Show();
            this.Hide();
        }
    }
}
