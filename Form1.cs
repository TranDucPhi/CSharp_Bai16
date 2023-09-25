using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBig_Click(object sender, EventArgs e)
        {
        
        }

        private void picBig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBig, "Click me");
        }

        private void picSmall_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSmall, "Click me");
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }
    }
}
