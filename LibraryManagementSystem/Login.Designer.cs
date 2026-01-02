namespace LibraryManagementSystem
{
    partial class Login
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
            this.txt_users = new System.Windows.Forms.TextBox();
            this.txt_passwords = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_signup = new System.Windows.Forms.LinkLabel();
            this.lb_forgetpass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_users
            // 
            this.txt_users.Location = new System.Drawing.Point(93, 140);
            this.txt_users.Multiline = true;
            this.txt_users.Name = "txt_users";
            this.txt_users.Size = new System.Drawing.Size(432, 34);
            this.txt_users.TabIndex = 3;
            // 
            // txt_passwords
            // 
            this.txt_passwords.Location = new System.Drawing.Point(93, 254);
            this.txt_passwords.Multiline = true;
            this.txt_passwords.Name = "txt_passwords";
            this.txt_passwords.Size = new System.Drawing.Size(432, 36);
            this.txt_passwords.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(317, 341);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 38);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login:";
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Location = new System.Drawing.Point(568, 426);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(191, 16);
            this.lb_signup.TabIndex = 11;
            this.lb_signup.TabStop = true;
            this.lb_signup.Text = "Don\'t have an account?SignUp";
            // 
            // lb_forgetpass
            // 
            this.lb_forgetpass.AutoSize = true;
            this.lb_forgetpass.Location = new System.Drawing.Point(568, 465);
            this.lb_forgetpass.Name = "lb_forgetpass";
            this.lb_forgetpass.Size = new System.Drawing.Size(116, 16);
            this.lb_forgetpass.TabIndex = 12;
            this.lb_forgetpass.TabStop = true;
            this.lb_forgetpass.Text = "Forget Password?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.lb_forgetpass);
            this.Controls.Add(this.lb_signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_passwords);
            this.Controls.Add(this.txt_users);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_users;
        private System.Windows.Forms.TextBox txt_passwords;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lb_signup;
        private System.Windows.Forms.LinkLabel lb_forgetpass;
    }
}

