namespace LibraryManagementSystem
{
    partial class ManagenentSystem
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lv_displayresult = new System.Windows.Forms.ListView();
            this.btn_searchb = new System.Windows.Forms.Button();
            this.btn_exitapp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.borrowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.borrowToolStripMenuItem.Text = "Borrow/Return";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search book:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(135, 51);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(214, 22);
            this.txt_search.TabIndex = 4;
            // 
            // lv_displayresult
            // 
            this.lv_displayresult.HideSelection = false;
            this.lv_displayresult.Location = new System.Drawing.Point(45, 79);
            this.lv_displayresult.Name = "lv_displayresult";
            this.lv_displayresult.Size = new System.Drawing.Size(647, 308);
            this.lv_displayresult.TabIndex = 5;
            this.lv_displayresult.UseCompatibleStateImageBehavior = false;
            // 
            // btn_searchb
            // 
            this.btn_searchb.Location = new System.Drawing.Point(378, 50);
            this.btn_searchb.Name = "btn_searchb";
            this.btn_searchb.Size = new System.Drawing.Size(75, 23);
            this.btn_searchb.TabIndex = 6;
            this.btn_searchb.Text = "search";
            this.btn_searchb.UseVisualStyleBackColor = true;
            this.btn_searchb.Click += new System.EventHandler(this.btn_searchb_Click);
            // 
            // btn_exitapp
            // 
            this.btn_exitapp.Location = new System.Drawing.Point(475, 50);
            this.btn_exitapp.Name = "btn_exitapp";
            this.btn_exitapp.Size = new System.Drawing.Size(75, 23);
            this.btn_exitapp.TabIndex = 7;
            this.btn_exitapp.Text = "Exit App";
            this.btn_exitapp.UseVisualStyleBackColor = true;
            this.btn_exitapp.Click += new System.EventHandler(this.btn_exitapp_Click);
            // 
            // ManagenentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exitapp);
            this.Controls.Add(this.btn_searchb);
            this.Controls.Add(this.lv_displayresult);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagenentSystem";
            this.Text = "ManagenentSystem";
            this.Load += new System.EventHandler(this.ManagenentSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ListView lv_displayresult;
        private System.Windows.Forms.Button btn_searchb;
        private System.Windows.Forms.Button btn_exitapp;
    }
}