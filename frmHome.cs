using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.CenterToScreen();
            backBtn.BackColor = Color.FromArgb(53, 36, 2);
            exitBtn.BackColor = Color.FromArgb(53, 36, 2);
            playGameBtn.BackColor = Color.FromArgb(53, 36, 2);
            scoreBtn.BackColor = Color.FromArgb(53, 36, 2);
            rultBtn.BackColor = Color.FromArgb(255,246,224);
            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void rultBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRule().Show();
        }

        private void playGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSelectType().Show();
        }
    }
}
