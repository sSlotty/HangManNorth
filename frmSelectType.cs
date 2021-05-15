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
        public static string type;

        /**
         * create constructor formHome
         * ทำการ set หน้าจอ ตรงกลาง
         * และทำการ set backGround color ให้กับปุ่ม ที่มีสีไม่ตรงกับ background
         * 
         **/
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
            type = "";
        }

        /*
         * 
         * Button travel
         * type = travel
         * 
         */
        private void travel_Click(object sender, EventArgs e)
        {
            type = "travel";
            this.Hide();
            new playGame().Show();
        }

        /*
         * 
         * Button language
         * type = language
         * 
         */
        private void language_Click(object sender, EventArgs e)
        {
            type = "language";
            this.Hide();
            new playGame().Show();

        }

        /*
         * 
         * Button food
         * type = food
         * 
         */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            type = "food";
            this.Hide();
            new playGame().Show();

        }

        /*
         * 
         * Button culture
         * type = culture
         * 
         */
        private void culture_Click(object sender, EventArgs e)
        {
            type = "culture";
            this.Hide();
            new playGame().Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmSelectType_Load(object sender, EventArgs e)
        {

        }

        /*
         * ปุ่มออกจากแอพ
         */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); //terninate application
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHome().Show();
            
        }
    }
}
