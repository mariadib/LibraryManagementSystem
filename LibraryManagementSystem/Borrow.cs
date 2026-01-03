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
    public partial class Borrow : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public Borrow()
        {
            InitializeComponent();
        }
        void borrowBook()
        {
            string query = $"INSERT INTO [dbo].[Borrowed] ([email],[bookId],[CheckoutDate],[dueDate]) VALUES ('{txt_emails.Text}','{cb_bookname.SelectedValue.ToString()}','{dtp_checkoutdate.Value.ToString("yyyy-MM-dd")}','{dtp_duedate.Value.ToString("yyyy-MM-dd")}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The book has been borrowed ");
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            borrowBook();   
        }

        void Loadbook()
        {
            string query = "SELECT [bookId],[title] FROM [dbo].[Books]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(dt);
                cb_bookname.DisplayMember = "title";
                cb_bookname.ValueMember = "bookId";
                cb_bookname.DataSource = dt;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadbook();
        }
        void ReturnBook()
        {
            string query = $"DELETE FROM [dbo].[Borrowed] WHERE email='{txt_emails.Text}' AND bookId='{cb_bookname.SelectedValue.ToString()}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The book has been returned ");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
         ReturnBook();
        }
        void PayFine()
        {
            string queryBorrowId = $"SELECT borrowId FROM [dbo].[Borrowed] WHERE email='{txt_emails.Text}' AND bookId='{cb_bookname.SelectedValue.ToString()}'";
            SqlCommand cmdBorrowId = new SqlCommand(queryBorrowId, conn);
            SqlDataReader readerBorrowId = cmdBorrowId.ExecuteReader();

            string borrowId = "";
            if (readerBorrowId.Read())
            {
                borrowId = readerBorrowId["borrowId"].ToString();
            }
            readerBorrowId.Close();
            DateTime dueDate = dtp_duedate.Value;
            DateTime returnDate = dtp_returndate.Value;
            int daysLate = (returnDate - dueDate).Days;
            decimal fineAmount = 0;
            if (daysLate > 0)
                fineAmount = daysLate * 1;

            string updateQuery = $"UPDATE [dbo].[Penalty] SET amount={fineAmount} WHERE borrowId='{borrowId}'";
            SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn);
            cmdUpdate.ExecuteNonQuery();
            string deleteQuery = $"DELETE FROM [dbo].[Borrowed] WHERE borrowId='{borrowId}'";
            SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn);
            cmdDelete.ExecuteNonQuery();
            txt_amount.Text = fineAmount.ToString();
            MessageBox.Show($"Fine of ${fineAmount} paid successfully!");

        }
        private void btn_payfine_Click(object sender, EventArgs e)
        {
            PayFine();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lquery = "SELECT Borrowed.email, Books.title, Borrowed.CheckoutDate, Borrowed.dueDate, Penalties.returnDate, Penalties.amount FROM  Books INNER JOIN Borrowed ON Books.bookId = Borrowed.bookId INNER JOIN Penalties ON Borrowed.borrowId = Penalties.borrowId";
            SqlCommand cmd = new SqlCommand(lquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string line = reader["email"].ToString() + "\t" +
                              reader["title"].ToString() + "\t" +
                              Convert.ToDateTime(reader["CheckOutDate"]).ToShortDateString() + "\t" +
                              Convert.ToDateTime(reader["dueDate"]).ToShortDateString() + "\t" +
                              (reader["returnDate"] == DBNull.Value ? "-" : Convert.ToDateTime(reader["returnDate"]).ToShortDateString()) + "\t" +
                              (reader["amount"] == DBNull.Value ? "0" : reader["amount"].ToString());

                listView1.Items.Add(line);
            }

            reader.Close();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to exit?",
             "Confirm Exit",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );
            if (result == DialogResult.Yes)
            {
                ManagenentSystem re = new ManagenentSystem();
                re.Show();
                this.Close();
            }
        }
    }
}
