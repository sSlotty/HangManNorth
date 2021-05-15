using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmRule : Form
    {
        /*
         * แสดง form และทำการ set หน้าจอให้อยู่ตรงกลาง
         * 
         */
        public frmRule()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /*
        * ปุ่มกลับไปยัง homForm
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
    }
}
