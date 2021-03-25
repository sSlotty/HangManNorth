using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmSelectType : Form
    {
        public static frmLogin frmLogin = new frmLogin();
        public frmSelectType()
        {
            InitializeComponent();
            this.CenterToScreen();
            travel.BackColor = Color.FromArgb(157, 210, 255);
            language.BackColor = Color.FromArgb(157, 210, 255);
            food.BackColor = Color.FromArgb(157, 210, 255);
            culture.BackColor = Color.FromArgb(157, 210, 255);
            exitBtn.BackColor = Color.FromArgb(157, 210, 255);
            backBtn.BackColor = Color.FromArgb(157, 210, 255);

        }

        private void travel_Click(object sender, EventArgs e)
        {

        }

        private void language_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void culture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmSelectType_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
            
        }
    }
}
