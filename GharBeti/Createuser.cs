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
    public partial class Createuser : Form
    {
        public Createuser()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCreateuser_MouseHover(object sender, EventArgs e)
        {
            lblCreateuser.BackColor = Color.Red;
        }

        private void lblCreateuser_MouseLeave(object sender, EventArgs e)
        {
            lblCreateuser.BackColor = Color.Yellow;
        }
    }
}
