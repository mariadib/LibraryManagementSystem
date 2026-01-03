namespace LibraryManagementSystem
{
    partial class Borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_duedate = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkoutdate = new System.Windows.Forms.DateTimePicker();
            this.txt_emails = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_bookname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_returndate = new System.Windows.Forms.DateTimePicker();
            this.btn_payfine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow Form:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Due Date:";
            // 
            // dtp_duedate
            // 
            this.dtp_duedate.Location = new System.Drawing.Point(374, 131);
            this.dtp_duedate.Name = "dtp_duedate";
            this.dtp_duedate.Size = new System.Drawing.Size(226, 22);
            this.dtp_duedate.TabIndex = 5;
            // 
            // dtp_checkoutdate
            // 
            this.dtp_checkoutdate.Location = new System.Drawing.Point(374, 88);
            this.dtp_checkoutdate.Name = "dtp_checkoutdate";
            this.dtp_checkoutdate.Size = new System.Drawing.Size(226, 22);
            this.dtp_checkoutdate.TabIndex = 6;
            // 
            // txt_emails
            // 
            this.txt_emails.Location = new System.Drawing.Point(131, 94);
            this.txt_emails.Name = "txt_emails";
            this.txt_emails.Size = new System.Drawing.Size(100, 22);
            this.txt_emails.TabIndex = 8;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(177, 545);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = "return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(67, 545);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(75, 23);
            this.btn_borrow.TabIndex = 11;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.Book,
            this.Date,
            this.DueDate,
            this.Return,
            this.amount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 256);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 257);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 125;
            // 
            // Book
            // 
            this.Book.Text = "Book";
            this.Book.Width = 108;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 99;
            // 
            // DueDate
            // 
            this.DueDate.Text = "DueDate";
            this.DueDate.Width = 115;
            // 
            // Return
            // 
            this.Return.Text = "Return Date";
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            // 
            // cb_bookname
            // 
            this.cb_bookname.FormattingEnabled = true;
            this.cb_bookname.Location = new System.Drawing.Point(131, 135);
            this.cb_bookname.Name = "cb_bookname";
            this.cb_bookname.Size = new System.Drawing.Size(121, 24);
            this.cb_bookname.TabIndex = 13;
            this.cb_bookname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(131, 174);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 22);
            this.txt_amount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Return Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtp_returndate
            // 
            this.dtp_returndate.Location = new System.Drawing.Point(377, 180);
            this.dtp_returndate.Name = "dtp_returndate";
            this.dtp_returndate.Size = new System.Drawing.Size(223, 22);
            this.dtp_returndate.TabIndex = 17;
            // 
            // btn_payfine
            // 
            this.btn_payfine.Location = new System.Drawing.Point(282, 545);
            this.btn_payfine.Name = "btn_payfine";
            this.btn_payfine.Size = new System.Drawing.Size(75, 23);
            this.btn_payfine.TabIndex = 18;
            this.btn_payfine.Text = "Pay Fine";
            this.btn_payfine.UseVisualStyleBackColor = true;
            this.btn_payfine.Click += new System.EventHandler(this.btn_payfine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(377, 545);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_payfine);
            this.Controls.Add(this.dtp_returndate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_bookname);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.txt_emails);
            this.Controls.Add(this.dtp_checkoutdate);
            this.Controls.Add(this.dtp_duedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_duedate;
        private System.Windows.Forms.DateTimePicker dtp_checkoutdate;
        private System.Windows.Forms.TextBox txt_emails;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Book;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ComboBox cb_bookname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_returndate;
        private System.Windows.Forms.ColumnHeader Return;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Button btn_payfine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
    }
}