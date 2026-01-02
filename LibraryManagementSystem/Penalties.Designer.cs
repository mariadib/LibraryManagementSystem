namespace LibraryManagementSystem
{
    partial class Penalties
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
            this.dgv_penalty = new System.Windows.Forms.DataGridView();
            this.Overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchborrowed = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_searchs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penalty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penalty Form:";
            // 
            // dgv_penalty
            // 
            this.dgv_penalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penalty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Overdue,
            this.Email,
            this.amount});
            this.dgv_penalty.Location = new System.Drawing.Point(5, 147);
            this.dgv_penalty.Name = "dgv_penalty";
            this.dgv_penalty.RowHeadersWidth = 51;
            this.dgv_penalty.RowTemplate.Height = 24;
            this.dgv_penalty.Size = new System.Drawing.Size(433, 150);
            this.dgv_penalty.TabIndex = 1;
            // 
            // Overdue
            // 
            this.Overdue.HeaderText = "Overdue books";
            this.Overdue.MinimumWidth = 6;
            this.Overdue.Name = "Overdue";
            this.Overdue.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Borrowed Book:";
            // 
            // txt_searchborrowed
            // 
            this.txt_searchborrowed.Location = new System.Drawing.Point(157, 97);
            this.txt_searchborrowed.Name = "txt_searchborrowed";
            this.txt_searchborrowed.Size = new System.Drawing.Size(100, 22);
            this.txt_searchborrowed.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(76, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 43);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Mark as Paid";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_searchs
            // 
            this.btn_searchs.Location = new System.Drawing.Point(287, 97);
            this.btn_searchs.Name = "btn_searchs";
            this.btn_searchs.Size = new System.Drawing.Size(75, 23);
            this.btn_searchs.TabIndex = 8;
            this.btn_searchs.Text = "Search";
            this.btn_searchs.UseVisualStyleBackColor = true;
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btn_searchs);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_searchborrowed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_penalty);
            this.Controls.Add(this.label1);
            this.Name = "Penalties";
            this.Text = "Penaltiescs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_penalty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searchborrowed;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button btn_searchs;
    }
}