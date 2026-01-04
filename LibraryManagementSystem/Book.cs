using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Book : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;" + "Initial Catalog=LibraryManagementSystem;" + "Integrated Security=True;" + "TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public Book()
        {
            InitializeComponent();
            loadCategory();
        }
        void AddBook()
        {
            string query = $"INSERT INTO [dbo].[Books] ([ISBN],[title] ,[author],[price] ,[CategoryId] ,[totalcopies],[availablecopies]) VALUES ('{txt_isbn.Text}','{txt_title.Text}','{txt_author.Text}','{txt_price.Text}','{cb_category.SelectedValue.ToString()}','{txt_total.Text}','{txt_available.Text}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
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
        void LoadBook()
        {
            string query = "SELECT Books.*, Categories.CategoryId AS categId FROM Books INNER JOIN Categories ON Books.CategoryId = Categories.CategoryId SELECT Books.*, Categories.CategoryName FROM     Books INNER JOIN Categories ON Books.CategoryId = Categories.CategoryId";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dt);
                dgv_display.DataSource = dt;
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
        void loadCategory()
        {
            string query = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(dt);
                cb_category.DisplayMember = "CategoryName";
                cb_category.ValueMember = "CategoryId";
                cb_category.DataSource = dt;
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
        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddBook();
            LoadBook();
        }
        void DeleteBook()
        {
            string query = $"DELETE FROM [dbo].[Books] WHERE ISBN = '{txt_isbn.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Deleted Successfully");
                Deleterow();
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
        void Deleterow()
        {
            foreach (DataGridViewRow row in dgv_display.Rows)
            {
                if (row.Cells["ISBN"].Value.ToString() == txt_isbn.Text)
                {
                    dgv_display.Rows.Remove(row);
                    break;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }
        void EditBook()
        {
            string query = $"UPDATE [dbo].[Books] SET [title] = '{txt_title.Text}', [author] = '{txt_author.Text}',[price] = '{txt_price.Text}' ,[CategoryId] = '{cb_category.SelectedValue.ToString()}', [totalcopies] = '{txt_total.Text}', [availablecopies] = '{txt_available.Text}' WHERE ISBN = '{txt_isbn.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Edited Successfully");
                Updaterow();
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
        void Updaterow()
        {
            foreach (DataGridViewRow row in dgv_display.Rows)
            {
                if (row.Cells["ISBN"].Value.ToString() == txt_isbn.Text)
                {
                    row.Cells["title"].Value = txt_title.Text;
                    row.Cells["author"].Value = txt_author.Text;
                    row.Cells["price"].Value = txt_price.Text;
                    row.Cells["CategoryId"].Value = cb_category.SelectedValue.ToString();
                    row.Cells["totalcopies"].Value = txt_total.Text;
                    row.Cells["availablecopies"].Value = txt_available.Text;
                    break;
                }
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        private void dgv_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT b.bookId, b.ISBN,b.title,b.author,c.CategoryName,b.price,b.totalcopies,b.totalcopies - ISNULL(t.borrowedCount, 0) AS availablecopies FROM Books b INNER JOIN Categories c ON b.CategoryId = c.CategoryId LEFT JOIN ( SELECT br.bookId, COUNT(*) AS borrowedCount FROM Borrowed br LEFT JOIN Penalty p ON br.borrowId = p.borrowId WHERE p.returnDate IS NULL GROUP BY br.bookId ) t ON b.bookId = t.bookId";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_display.DataSource = dt;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_display.Rows[e.RowIndex];

                txt_isbn.Text = row.Cells["ISBN"].Value.ToString();
                txt_title.Text = row.Cells["Title"].Value.ToString();
                txt_author.Text = row.Cells["Author"].Value.ToString();
                cb_category.Text = row.Cells["Category"].Value.ToString();
                txt_price.Text = row.Cells["Price"].Value.ToString();
                txt_total.Text = row.Cells["Total Copies"].Value.ToString();
                txt_available.Text = row.Cells["Available Copies"].Value.ToString();
            }
        }

        void RefreshBooks()
        {
            string query = "SELECT b.bookId, b.ISBN,b.title,b.author,c.CategoryName,b.price,b.totalcopies,b.totalcopies - ISNULL(t.borrowedCount, 0) AS availablecopies FROM Books b INNER JOIN Categories c ON b.CategoryId = c.CategoryId LEFT JOIN ( SELECT br.bookId, COUNT(*) AS borrowedCount FROM Borrowed br LEFT JOIN Penalties p ON br.borrowId = p.borrowId WHERE p.returnDate IS NULL GROUP BY br.bookId ) t ON b.bookId = t.bookId";
            SqlCommand cmdRefresh = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataAdapter daRefresh = new SqlDataAdapter(cmdRefresh);
                DataTable dtRefresh = new DataTable();
                int v = daRefresh.Fill(dtRefresh);
                dgv_display.DataSource = dtRefresh;

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

        private void Book_Load(object sender, EventArgs e)
        {
            RefreshBooks();
        }
    }
}