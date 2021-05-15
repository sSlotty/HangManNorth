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


     

        public List<string> allQuestion; //create List allQuestion
        public List<string> allAnswer; //create List allAnswer

        private List<int> questionSuffer; //create list questionSuffer
        private readonly int QUESTION_NUM = 10; // create int varible QUESTION_NUM

        private int round = 0;
        private int sumpoint ,question_num= 0;
        private int point = 0;
     
        bool gameOver = false;

        private string answser,hint;

        private readonly IUserService _userService;

        /**
         * create constructor formPlayGame and set Screen to center
         * _useService เรียกใช้ service IUserSercice
         * ทำการ resetGuman และ startGame
         **/
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
            // กรณีถ้า GameOver = true MessageBox
            if (!gameOver)
            {
                // กรณีถ้า คำถามหมดแล้วจะ show MessageBox และทำการ terminate ออกจาก application
                if (question_num <= 9)
                {
                    sufferQuestion(); //สุ่มคำถาม
                    if (round < 6) // กรณีตอบคำถามผิด น้อยกว่า 6 จะใหแสดงคำถาม ถ้ามากกว่า 6 จะ แสดง MessageBox
                    {
                        TextHint.Text = hint;
                        

                    }
                    else
                    {

                        MessageBox.Show("Game Over your score : " + this.sumpoint.ToString());
                        saveScore();
                        _userService.SetUserScore(sumpoint);
                        this.Close();
                        new frmHome().Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("End game your score : " + this.sumpoint.ToString());
                    saveScore();
                    _userService.SetUserScore(sumpoint);
                    this.Close();
                    new frmHome().Show();
              
                }

            }
            else
            {
                saveScore();
                _userService.SetUserScore(sumpoint);
                this.Close();
                MessageBox.Show("Game Over your score : " + this.sumpoint.ToString());
                new frmHome().Show();
                

            }

        }

        /*
         * สุ่มคำถาม 
         * โดยใช้ Random ทุกครั้ง ถ้าคำถามไหนโดนถามไปแล้ว ถูกลบ Question จะทำให้ไม่สุ่มคำถามเดิมมาถามอีกครั้ง
         */
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


        /*
         * read JsonFile 
         */
        private void JsonReadQuestion(string type)
        {
            allQuestion = new List<string>(); //craere new List of String 
            allAnswer = new List<string>(); //craere new List of String 

            questionSuffer = new List<int>(); //craere new List of int 

            var jsonFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\data\data.json"; //ทำการ  getDirectory ล่าสุดและเข้าไป select data.json
            var jsonString = File.ReadAllText(jsonFile); // read file json
            
            var data = JObject.Parse(jsonString); //ทำให้อยู่ใน รูปแบบ ของ jsonObject

            for(int i = 0; i < QUESTION_NUM; i++) 
            {
                allQuestion.Add(data[type][i]["hint"].ToString()); // add value to List allQuestion
                allAnswer.Add(data[type][i]["answer"].ToString()); // add value to list allAnswer
            }
            
             
        }

     
        /// <summary>
        /// button submit answer
        /// หากจำนวนรอบ การ count < 7 จะสามารถกดส่งคำตอบได้
        /// กรณีหากไม่ มากกว่า 7 score จะถูก save และ terminate กลับไปยังหน้า home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// กรณีถ้าตำตอบตรง 
        /// จะทำการ StartGame อีกครั้ง และทำการ reset หุ่น
        /// และหากถ้า ตอบผิดไปเรื่อยๆ จะทำการ show รูป จนตาย และ gameOver = true
        /// </summary>
        /// <param name="ans">คำตอบของคำถามนั้นๆ</param>

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
                        gameOver = true;
                        break;
                }

            }
   
          }

        /// <summary>
        /// open coonection database 
        /// และทำการ set point  = sumpoint โดย ที่ username = username และ ทำการ Execute และ ทำการ closeConnection 
        /// </summary>
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

        /// <summary>
        /// retset human set all pic.Visivle = false
        /// </summary>
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
        
        // ปุ่ม ออกจากแอพ จะทำการ seve score และทำการ set socre 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.sumpoint = point + _userService.GetUserScore();
            saveScore();
            _userService.SetUserScore(sumpoint);
            Application.Exit();
        }

        // ปุ่ม กลับไปยังหน้าเลือก type จะทำการ seve score และทำการ set socre 
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
