using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hangman.Extension;
using System.Data.OleDb;
using Hangman.Constants;

namespace Hangman
{
    public partial class frmRegister : Form
    {
      

   
       //create static constance form Login
        public static frmLogin frmLogin = new frmLogin();

        /**
         * create constructor and setScreen to center
         **/
        public frmRegister()
        {
            InitializeComponent();
            this.CenterToScreen();
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /**
         * กลับไปยัง form login และ ทำการ hide form register
         **/
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

        /**
         * close application
         **/
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

        //function register return type is boolean
        private bool Register(string username, string password)
        {

            password = password.GetSHA256HashString(); // hash string password

            try
            {

                if (!checkUsernameExits(username)) // check username กรณีมีการใช้ชื่อ username ซ้ำ
                {
                    using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString)) //create new OleDBConnect โดย ได้ดึง viriable.ConnectionString มาใช้งาน
                    {
                        con.Open();

                        using (OleDbDataAdapter da = new OleDbDataAdapter()) // create adapter
                        using (OleDbCommandBuilder bld = new OleDbCommandBuilder(da)) //create command builder
                        {
                            bld.QuotePrefix = "[";  // these are
                            bld.QuoteSuffix = "]";  //   important!

                            da.SelectCommand = new OleDbCommand(
                                    "SELECT [ID], [username], [password], [point] " +
                                    "FROM [tbl_users] " +
                                    "WHERE False",
                                    con); //create command obj และ ทำการส่ง command และ obj connection

                            using (System.Data.DataTable dt = new System.Data.DataTable("tbl_users")) //select database Table
                            {
                                // create an empty DataTable with the correct structure
                                da.Fill(dt);

                                System.Data.DataRow dr = dt.NewRow(); // new row
                                dr["username"] = username; //set username to obj
                                dr["password"] = password; //set password to obj
                                dr["point"] = 0; // set first point  to obj
                                dt.Rows.Add(dr); // add new row

                                da.Update(dt);  // write new row back to database
                            }
                        }
                        con.Close(); // close connection

                        MessageBox.Show("Success", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConfPassoword.Text = "";
                        this.Hide();
                        new frmLogin().Show();

                        return true;
                    }

                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfPassoword.Text = "";
                    MessageBox.Show("username is already haveing", "Register fail");
                    return false;
                }

            }
            catch (Exception e){ //กรณีเกิดข้อมผิดพลาดจะทำการแสดง Exception
                Console.WriteLine(e);

            }

            return true;

        }

        /**
         * button image เช็คค่าภายใน input กรณีถ้ามีค่าใดค่าหนึ่งว่าง จะทำการ show message 
         * และมีการส่งค่าไปยัง funcion register
         **/
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUsername.Text)))
            {
                if (!(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfPassoword.Text)))
                {
                    if(string.IsNullOrEmpty(txtPassword.Text) == string.IsNullOrEmpty(txtConfPassoword.Text)){

                        var reg = Register(txtUsername.Text, txtPassword.Text);

                        if (reg)
                        {
                            //Show alert success
                            Console.WriteLine(reg);
                        }
                        else
                        {
                            //Show alert fail
                            Console.WriteLine(reg);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password don't match", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    // password is empty
                    MessageBox.Show("Password or Confirm password is empty", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        // create function checkUsername return type boolean
        private bool checkUsernameExits(string username)
        {
            try
            {

                
                using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString)) //create new OleDBConnect โดย ได้ดึง viriable.ConnectionString มาใช้งาน
                {
                    con.Open(); //open connection
                    var sql = $"SELECT [ID], [username] FROM [tbl_users] WHERE username=?"; //sql command
                    var cmd = new OleDbCommand(sql, con); // new Obj OleDbCommand โดยได้ส่ง  string sql และ connection
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = username; //ใส่ parameter โดย ใช้ string "?" = username หา ข้อมูล ใน database ที่ชื่อตรงกัน 

                    var reader = cmd.ExecuteReader();  //ทำการ excute command
                    while (reader.Read()) // ทำการอ่าน ข้อมูลที่  response กลับมา
                    {
                        var aaa = reader.GetString(1); //ดึงข้อมูลภายใน obj ตัวที่  1 คือ username
                        if (username == aaa) // ถ้า username ตรงกัน จะ return true
                        {
                            return true;
                        }
                    }

                    reader.Close(); // close reader
                    cmd.Dispose(); 
                    con.Close(); //close connection
                }

            }
            catch (Exception e) // กรณีเกิด Exception จะทำการแสดง exception
            {
                Console.WriteLine(e);
            }

            return false;


        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
