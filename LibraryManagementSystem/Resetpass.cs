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
    public partial class Resetpass : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public Resetpass()
        {
            InitializeComponent();
        }
        void Resettingpass()
        {
            string query = "UPDATE [dbo].[Users] SET password = @password WHERE email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@password", txt_newpass.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Password has been reset successfully!");
                else
                    MessageBox.Show("No user found with this email.");
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

        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Resettingpass();
            Login login = new Login(); 
            login.Show();                      
            this.Close();
        }
    }
}
