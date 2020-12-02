using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbemail.Text ;
            string password = tbpassword.Text;

            lblmassege.Text = "";

            if (email.Trim() == "")
            {
                lblmassege.Text = "please enter your email";
                lblmassege.ForeColor = Color.Red;
                tbemail.Focus();
                return;
            }
            
            if (password.Trim() == "")
            {
                lblmassege.Text = "please enter your password";
                lblmassege.ForeColor = Color.Red; 
                tbpassword.Focus();
                return;   
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblmassege.Text = "";
            tbemail.Text = "";
            tbpassword.Text = "";
            cbremember.Checked = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblmassege_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
