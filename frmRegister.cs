using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmRegister : Form
    {
        public static frmLogin frmLogin = new frmLogin();
        public frmRegister()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
