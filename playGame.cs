using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.OleDb;
using Hangman.Services;
using Hangman.Constants;

namespace Hangman
{
    
    public partial class playGame : Form
    {


        //static string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        //static string[] words = path.Split(@"\");
        //static string fixpath = words[0] + @"\" + words[1] + @"\" + words[2] + @"\";

        //string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fixpath + "db_user.mdb;";

        public List<string> allQuestion;
        public List<string> allAnswer;

        private List<int> questionSuffer;
        private readonly int QUESTION_NUM = 10;

        private int round = 0;
        private int sumpoint ,question_num= 0;
        private int point = 0;
        int time = 60;
        bool gameOver = false;

        private string answser,hint;

        private readonly IUserService _userService;
        public playGame()
        {
            _userService = (IUserService)Program.ServiceProvider.GetService(typeof(IUserService));
            InitializeComponent();
            this.CenterToScreen();
            JsonReadQuestion(frmSelectType.type);
            TextHint.MaximumSize = new Size(300, 0);
            TextHint.AutoSize = true;
            resetHuman();
            startGame();

        }
        private void startGame()
        {
            
            if (!gameOver)
            {
                if(question_num <= 9)
                {
                    sufferQuestion();
                    if (round < 6)
                    {
                        TextHint.Text = hint;
                        

                    }
                    else
                    {

                        MessageBox.Show("Game Over your score : " + this.sumpoint.ToString());
                        saveScore();
                        this.Close();
                        new frmHome().Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("End game your score : " + this.sumpoint.ToString());
                    saveScore();
                    this.Close();
                    new frmHome().Show();
              
                }

            }
            else
            {
                saveScore();
                this.Close();
                MessageBox.Show("Game Over your score : " + this.sumpoint.ToString());
                new frmHome().Show();
                

            }

        }

        public void sufferQuestion()
        {
            var rand = new Random();
            var r = rand.Next(0, allAnswer.Count);
            questionSuffer.Add(r);
            answser = allAnswer[r].ToString();
            hint = allQuestion[r].ToString();
            allAnswer.RemoveAt(r);
            allQuestion.RemoveAt(r);
            question_num++;
        }


        private void JsonReadQuestion(string type)
        {
            allQuestion = new List<string>();
            allAnswer = new List<string>();
            
            questionSuffer = new List<int>();

            var jsonFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\data\data.json";
            var jsonString = File.ReadAllText(jsonFile);
            
            var data = JObject.Parse(jsonString);

            for(int i = 0; i < QUESTION_NUM; i++)
            {
                allQuestion.Add(data[type][i]["hint"].ToString());
                allAnswer.Add(data[type][i]["answer"].ToString());
            }
            
             
        }

     

        private void submitBox_Click(object sender, EventArgs e)
        {
            if(this.round < 7)
            {
                checkAnswer(TextAns.Text);

            }
            else
            {
               
                this.sumpoint = point + _userService.GetUserScore();
                saveScore();
                _userService.SetUserScore(sumpoint);
                this.gameOver = true;
                MessageBox.Show("Game Over your score : " + this.sumpoint.ToString());
                this.Close();
                new frmHome().Show();
                

            }
        }

        public void checkAnswer(string ans)
        {
            if (ans.Equals(answser))
            {
                MessageBox.Show("Correct Answer");
                startGame();
                TextAns.Text = "";
                this.round = 0;
                point = point + 1;
                TextPoint.Text = point.ToString();
                resetHuman();
            }
            else
            {
                round++;
                
                switch (round)
                {
                    case 1:
                        pic1.Visible = true;
                        break;
                    case 2:
                        pic1.Visible = false;
                        pic2.Visible = true;
                        break;
                    case 3:
                        pic2.Visible = false;
                        pic3.Visible = true;
                        break;
                    case 4:
                        pic3.Visible = false;
                        pic4.Visible = true;
                        break;
                    case 5:
                        pic4.Visible = false;
                        pic5.Visible = true;
                        break;
                    case 6:
                        pic5.Visible = false;
                        pic6.Visible = true;
                        break;
                    case 7:
                        pic6.Visible = false;
                        pic7.Visible = true;
                        break;
                }

            }
   
          }

        private void saveScore()
        {
            try
            {


                using (OleDbConnection con = new OleDbConnection(Variable.ConnectionString))
                {
                    con.Open();
                    var sql = $"UPDATE [tbl_users] SET point = @point WHERE username= @username";
                    var cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add("@point", OleDbType.Integer).Value = this.sumpoint;
                    cmd.Parameters.Add("@username", OleDbType.VarChar).Value = _userService.GetUsername();
                    
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            

        }

        public void resetHuman()
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TextHint_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.sumpoint = point + _userService.GetUserScore();
            saveScore();
            _userService.SetUserScore(sumpoint);
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.sumpoint = point + _userService.GetUserScore();
            saveScore();
            _userService.SetUserScore(sumpoint);
            this.Hide();
            new frmSelectType().Show();
        }

     

       


    }
}
