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
        //OleDbConnection con;
        //OleDbCommand cmd;
        //OleDbDataAdapter da;
        //static string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        //static string[] words = path.Split(@"\");
        //static string fixpath = words[0] + @"\" + words[1] + @"\" + words[2] + @"\";

        //string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ fixpath +"db_user.mdb;";

   

        public static frmLogin frmLogin = new frmLogin();
        public frmRegister()
        {
            InitializeComponent();
            this.CenterToScreen();
            //con = new OleDbConnection(ConnectionString);
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

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

        private bool Register(string username, string password)
        {

            password = password.GetSHA256HashString();

            try
            {

                if (!checkUsernameExits(username))
                {
                    using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString))
                    {
                        con.Open();

                        using (OleDbDataAdapter da = new OleDbDataAdapter())
                        using (OleDbCommandBuilder bld = new OleDbCommandBuilder(da))
                        {
                            bld.QuotePrefix = "[";  // these are
                            bld.QuoteSuffix = "]";  //   important!

                            da.SelectCommand = new OleDbCommand(
                                    "SELECT [ID], [username], [password], [point] " +
                                    "FROM [tbl_users] " +
                                    "WHERE False",
                                    con);
                            using (System.Data.DataTable dt = new System.Data.DataTable("tbl_users"))
                            {
                                // create an empty DataTable with the correct structure
                                da.Fill(dt);

                                System.Data.DataRow dr = dt.NewRow();
                                dr["username"] = username;
                                dr["password"] = password;
                                dr["point"] = 0;
                                dt.Rows.Add(dr);

                                da.Update(dt);  // write new row back to database
                            }
                        }
                        con.Close();

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
            catch (Exception e){
                Console.WriteLine(e);

            }

            return true;

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUsername.Text)))
            {
                if (!(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfPassoword.Text)))
                {
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
                    // password is empty
                }

            }
        }
        private bool checkUsernameExits(string username)
        {
            try
            {

                
                using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString))
                {
                    con.Open();
                    var sql = $"SELECT [ID], [username] FROM [tbl_users] WHERE username=?";
                    var cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = username;

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var aaa = reader.GetString(1);
                        if (username == aaa)
                        {
                            return true;
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

            return false;


        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
