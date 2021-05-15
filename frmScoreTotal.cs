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
        //create varible _userService by IUserService
        private readonly IUserService _userService;

        /**
         * create constructor frmScoreTotal
         * ทำการ set หน้าจอ ตรงกลาง
         * ทำการดึงข้อมูลจาก score จาก service และทำการ set text หน้า score ให้ตรงกับ score ที่อยู่ภายใน class IUserService
         * 
         **/
        public frmScoreTotal()
        {
            InitializeComponent();
            this.CenterToScreen();
            _userService = (IUserService)Program.ServiceProvider.GetService(typeof(IUserService));
            //TextScore.Text = frmLogin.point.ToString();
            TextScore.Text = _userService.GetUserScore().ToString();
         
        }

        /*
         * ปุ่มกลับไปยัง formLogin
        */
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHome().Show(); // new formHome และทำการ ใช้ method show เพื่อแสดง
        }

        /*
         * ปุ่มออกจากแอพ
         */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Terminate application
        }

        private void TextScore_Click(object sender, EventArgs e)
        {

        }
    }
}
