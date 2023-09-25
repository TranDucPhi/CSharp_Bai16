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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkvisible.Checked;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBig_Click_1(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }
    }
}
