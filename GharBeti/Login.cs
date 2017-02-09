using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GharBeti
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                
                MainForm frm = new MainForm();
                Program.username = txtUsername.Text;
                // frm.lblUsername.Text = "welcome" + txtUsername.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("not valid user"); 
            }

        }
    }
}
