using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmLogin : Form
    {
        public static frmRegister frmRegister = new frmRegister();
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           // Function Login
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister.Show();
        }
    }
}
