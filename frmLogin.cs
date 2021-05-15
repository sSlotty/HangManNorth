using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Hangman.Extension;
using Hangman.Services;
using System.IO;
using Hangman.Constants;

namespace Hangman
{
    public partial class frmLogin : Form
    {
        //create static varible user
        public static string user = "";
        //create static varible point
        public static int point;


        //create static contance formLogin
        public static frmRegister frmRegister = new frmRegister();

        private readonly IUserService _userService;
        private static System.Timers.Timer aTimer;

        /**
         * create constructor formLogin and set Screen to center
         **/
        public frmLogin() 
        {
            _userService = (IUserService)Program.ServiceProvider.GetService(typeof(IUserService));
            InitializeComponent();
            this.CenterToScreen();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        /**
        * ตั้งค่า ปั่ม loginและทำการ ส่ง ข้อมูลไปยัง function login และนำ result กลัยมาเช๋็ค condition หากสำเร็จจะสามารถเข้า formHome ได้
        **/
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Function Login
            var password = txtPassword.Text.GetSHA256HashString();
            var result = login(txtUsername.Text, password);

            if (result)
            {
                MessageBox.Show("login !!");
                this.Hide();
                new frmHome().Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
                txtPassword.Text = "";
                txtUsername.Text = "";

            }
        }

        /**
        * function Login หากทำการ Login สำเร็จ จะ return ค่า ออกไปเป็น boolean 
        **/
        private bool login(string username, string password)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString)) //create new OleDBConnect โดย ได้ดึง viriable.ConnectionString มาใช้งาน
                {
                    con.Open(); //open connection
                    var sql = $"SELECT [ID], [username],[password],[point] FROM [tbl_users] WHERE username=?"; //sql command
                    var cmd = new OleDbCommand(sql, con); // new Obj OleDbCommand โดยได้ส่ง  string sql และ connection
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = username; //ใส่ parameter โดย ใช้ string "?" = username หา ข้อมูล ใน database ที่ชื่อตรงกัน 

                    var reader = cmd.ExecuteReader();  //ทำการ excute command
                    while (reader.Read()) // ทำการอ่าน ข้อมูลที่  response กลับมา
                    {
                        var usernameRes = reader.GetString(1); //ดึงข้อมูลภายใน obj ตัวที่  1 คือ username
                        var passwordRes = reader.GetString(2); //ดึงข้อมูลภายใน obj ตัวที่  2 คือ password
                        var point = reader.GetInt32(3); //ดึงข้อมูลภายใน obj ตัวที่  3 คือ point

                        if (username == usernameRes && password == passwordRes) // check connection username and password หาก มีค่าตรงกัน ก็จะทำการ set ค่า ให้กับ username 
                        {
                            _userService.SetUsername(username); //set username
                            _userService.SetUserScore(point); // set point

                            return true; 
                        }
                        else
                        {
                            
                            return false;
                        }
                    }
                    reader.Close(); 
                    cmd.Dispose();
                    con.Close();
                   
                }

            }
            catch (Exception e) // กรณีเกิด Exception จะทำการแสดง exception
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                return false;
            }

            return false;

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

        /**
         * ปิด application
         **/
        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /**
         * Open form register
         **/
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister.Show();
        }
    }
}
