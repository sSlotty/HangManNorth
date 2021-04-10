using Hangman.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmScoreTotal : Form
    {
        private readonly IUserService _userService;
        public frmScoreTotal()
        {
            InitializeComponent();
            this.CenterToScreen();
            _userService = (IUserService)Program.ServiceProvider.GetService(typeof(IUserService));
            //TextScore.Text = frmLogin.point.ToString();
            TextScore.Text = _userService.GetUserScore().ToString();
         
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHome().Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextScore_Click(object sender, EventArgs e)
        {

        }
    }
}
