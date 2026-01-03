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
    public partial class ManagenentSystem : Form
    {

        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public ManagenentSystem()
        {
            InitializeComponent();
        }

        private void ManagenentSystem_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book bookmanagement = new Book();
            bookmanagement.Show();                      
            this.Hide();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrowedbook = new Borrow();
            borrowedbook.Show();
            this.Hide();
        }

        private void penaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void SearchBooks()
        {
            string query = $"SELECT * FROM [dbo].[Books] WHERE title LIKE '%{txt_search.Text}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    lv_displayresult.Items.Clear();

                    while (reader.Read())
                    {
                        string bookInfo = $"{reader["title"]} by {reader["author"]} costs {(decimal)reader["price"]:C2}";
                        lv_displayresult.Items.Add(bookInfo);
                    }
                }
                else
                {
                    MessageBox.Show("No books found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close(); 
                conn.Close();       
            }
        }
        private void btn_searchb_Click(object sender, EventArgs e)
        {
           SearchBooks();
        }

        private void btn_exitapp_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
         }
    }
}
