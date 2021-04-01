﻿using System;
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
namespace Hangman
{
    public partial class frmLogin : Form
    {
        public static string user = "";
        public static int point;

        static string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static string[] words = path.Split(@"\");
        static string fixpath = words[0] + @"\" + words[1] + @"\" + words[2] + @"\";

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fixpath + "db_user.mdb;";

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
            var password = txtPassword.Text.GetSHA256HashString();
            login(txtUsername.Text, password);
        }

        private void login(string username, string password)
        {
            try
            {


                using (OleDbConnection con = new OleDbConnection(ConnectionString))
                {
                    con.Open();
                    var sql = $"SELECT [ID], [username],[password],[point] FROM [tbl_users] WHERE username=?";
                    var cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = username;

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var usernameRes = reader.GetString(1);
                        var passwordRes = reader.GetString(2);
                        var point = reader.GetInt32(3);
                        
                        if (username == usernameRes && password == passwordRes)
                        {

                            user = username;
                            point = point;
                            this.Hide();
                            new frmHome().Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or password incorrect!");
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                    con.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

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
