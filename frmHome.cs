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
        /**
         * create constructor formHome
         * ทำการ set หน้าจอ ตรงกลาง
         * และทำการ set backGround color ให้กับปุ่ม ที่มีสีไม่ตรงกับ background
         * 
         **/
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

        /*
         * ปุ่มออกจากแอพ
         */
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Terminate application
        }

        /*
        * ปุ่มกลับไปยัง login form
        */
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show(); // new formLogin และทำการ ใช้ method show เพื่อแสดง
        }

        /*
        * ปุ่ม show formRule
        */
        private void rultBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRule().Show(); // new formRule และทำการ ใช้ method show เพื่อแสดง
        }

        /*
        * ปุ่มเลือกชนิดของคำถาม
        */
        private void playGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSelectType().Show(); // new selectType และทำการ ใช้ method show เพื่อแสดง
        }

        /*
        * ปุ่มดู score ทั้งหมดที่มี
        */
        private void scoreBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new frmScoreTotal().Show(); // new formScoretoal และทำการ ใช้ method show เพื่อแสดง
        }
    }
}
