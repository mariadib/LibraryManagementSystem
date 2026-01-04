using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Borrow : Form
    {
        static string connString = "Data Source=DESKTOP-HRBJP2J\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);

        public Borrow()
        {
            InitializeComponent();
            SetupListView();
            Loadbook();
            LoadBorrowedBooks();
        }

        void SetupListView()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Book", 150);
            listView1.Columns.Add("Checkout Date", 100);
            listView1.Columns.Add("Due Date", 100);
            listView1.Columns.Add("Return Date", 100);
            listView1.Columns.Add("Total Amount", 100);
        }

        void borrowBook()
        {
            string query = "INSERT INTO Borrowed (email, bookId, CheckoutDate, dueDate) VALUES (@Email,@BookId,@CheckoutDate,@DueDate)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", txt_emails.Text);
            cmd.Parameters.AddWithValue("@BookId", cb_bookname.SelectedValue);
            cmd.Parameters.AddWithValue("@CheckoutDate", dtp_checkoutdate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@DueDate", dtp_duedate.Value.ToString("yyyy-MM-dd"));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The book has been borrowed");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); LoadBorrowedBooks(); }
        }

        private void btn_borrow_Click(object sender, EventArgs e) { borrowBook(); }

        void Loadbook()
        {
            string query = "SELECT bookId, title FROM Books";
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        void LoadBorrowedBooks()
        {
            string query = @"SELECT Borrowed.borrowId, Borrowed.email, Books.title, Borrowed.CheckoutDate, Borrowed.dueDate, Books.price 
                             FROM Borrowed INNER JOIN Books ON Borrowed.bookId = Books.bookId";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    string email = reader["email"].ToString();
                    string title = reader["title"].ToString();
                    DateTime checkout = Convert.ToDateTime(reader["CheckoutDate"]);
                    DateTime due = Convert.ToDateTime(reader["dueDate"]);
                    decimal price = Convert.ToDecimal(reader["price"]);
                    int daysLate = (DateTime.Now - due).Days;
                    decimal fine = daysLate > 0 ? daysLate * 1 : 0;
                    decimal totalAmount = price + fine;

                    ListViewItem item = new ListViewItem(email);
                    item.SubItems.Add(title);
                    item.SubItems.Add(checkout.ToShortDateString());
                    item.SubItems.Add(due.ToShortDateString());
                    item.SubItems.Add("-"); // Return date empty until returned
                    item.SubItems.Add($"${totalAmount}");
                    item.Tag = reader["borrowId"].ToString();
                    listView1.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void ReturnBook()
        {
            try
            {
                string query = "SELECT borrowId, bookId, dueDate FROM Borrowed WHERE email=@Email AND bookId=@BookId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", txt_emails.Text);
                cmd.Parameters.AddWithValue("@BookId", cb_bookname.SelectedValue);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string borrowId = reader["borrowId"].ToString();
                    string bookId = reader["bookId"].ToString();
                    DateTime dueDate = Convert.ToDateTime(reader["dueDate"]);
                    reader.Close();

                    DateTime returnDate = dtp_returndate.Value;
                    int daysLate = (returnDate - dueDate).Days;
                    decimal fine = daysLate > 0 ? daysLate * 1 : 0;

                    SqlCommand cmdPrice = new SqlCommand("SELECT price FROM Books WHERE bookId=@BookId", conn);
                    cmdPrice.Parameters.AddWithValue("@BookId", bookId);
                    decimal price = Convert.ToDecimal(cmdPrice.ExecuteScalar());
                    decimal totalAmount = price + fine;

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Borrowed WHERE borrowId=@BorrowId", conn);
                    cmdDelete.Parameters.AddWithValue("@BorrowId", borrowId);
                    cmdDelete.ExecuteNonQuery();

                    RemoveFromListView(txt_emails.Text, cb_bookname.Text);
                    MessageBox.Show(daysLate > 0 ? $"Book returned late! Total charge: ${totalAmount}" : $"Book returned successfully! Total charge: ${totalAmount}");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No matching borrowed book found!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); LoadBorrowedBooks(); }
        }

        private void btn_return_Click(object sender, EventArgs e) { ReturnBook(); }

        private void PayFine()
        {
            try
            {
                string query = "SELECT borrowId, dueDate, bookId FROM Borrowed WHERE email=@Email AND bookId=@BookId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", txt_emails.Text);
                cmd.Parameters.AddWithValue("@BookId", cb_bookname.SelectedValue);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string borrowId = reader["borrowId"].ToString();
                    string bookId = reader["bookId"].ToString();
                    DateTime dueDate = Convert.ToDateTime(reader["dueDate"]);
                    reader.Close();

                    DateTime returnDate = dtp_returndate.Value;
                    int daysLate = (returnDate - dueDate).Days;
                    decimal fine = daysLate > 0 ? daysLate * 1 : 0;

                    SqlCommand cmdPrice = new SqlCommand("SELECT price FROM Books WHERE bookId=@BookId", conn);
                    cmdPrice.Parameters.AddWithValue("@BookId", bookId);
                    decimal price = Convert.ToDecimal(cmdPrice.ExecuteScalar());
                    decimal totalAmount = price + fine;

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Borrowed WHERE borrowId=@BorrowId", conn);
                    cmdDelete.Parameters.AddWithValue("@BorrowId", borrowId);
                    cmdDelete.ExecuteNonQuery();

                    RemoveFromListView(txt_emails.Text, cb_bookname.Text);
                    MessageBox.Show($"Fine paid: ${totalAmount}");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No matching borrowed book found!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); LoadBorrowedBooks(); }
        }

        private void btn_payfine_Click(object sender, EventArgs e) { PayFine(); }

        private void RemoveFromListView(string email, string book)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Text == email && listView1.Items[i].SubItems[1].Text == book)
                    listView1.Items.RemoveAt(i);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void tabPage1_Click(object sender, EventArgs e) { }

        private void cb_bookname_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ManagenentSystem re = new ManagenentSystem();
                re.Show();
                this.Close();
            }
        }
    }
}
