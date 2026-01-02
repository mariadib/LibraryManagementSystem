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
            this.txt_booksborrowed = new System.Windows.Forms.TextBox();
            this.txt_emails = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
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
            // txt_booksborrowed
            // 
            this.txt_booksborrowed.Location = new System.Drawing.Point(131, 137);
            this.txt_booksborrowed.Multiline = true;
            this.txt_booksborrowed.Name = "txt_booksborrowed";
            this.txt_booksborrowed.Size = new System.Drawing.Size(100, 22);
            this.txt_booksborrowed.TabIndex = 7;
            // 
            // txt_emails
            // 
            this.txt_emails.Location = new System.Drawing.Point(131, 94);
            this.txt_emails.Name = "txt_emails";
            this.txt_emails.Size = new System.Drawing.Size(100, 22);
            this.txt_emails.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Name,
            this.Checkout,
            this.Due});
            this.dataGridView1.Location = new System.Drawing.Point(46, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 199);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(318, 399);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = "return";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(208, 399);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(75, 23);
            this.btn_borrow.TabIndex = 11;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "BookName";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Checkout
            // 
            this.Checkout.HeaderText = "CheckoutDate";
            this.Checkout.MinimumWidth = 6;
            this.Checkout.Name = "Checkout";
            this.Checkout.Width = 125;
            // 
            // Due
            // 
            this.Due.HeaderText = "DueDate";
            this.Due.MinimumWidth = 6;
            this.Due.Name = "Due";
            this.Due.Width = 125;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_emails);
            this.Controls.Add(this.txt_booksborrowed);
            this.Controls.Add(this.dtp_checkoutdate);
            this.Controls.Add(this.dtp_duedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Borrow";
            this.Text = "Borrow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_booksborrowed;
        private System.Windows.Forms.TextBox txt_emails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due;
    }
}