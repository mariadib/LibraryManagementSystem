using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            SignUp s=new SignUp();  
            s.Show();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
        }
    }
}
