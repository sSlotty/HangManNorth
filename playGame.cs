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

namespace Hangman
{
    public partial class playGame : Form
    {
        static string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static string[] words = path.Split(@"\");
        static string fixpath = words[0] + @"\" + words[1] + @"\" + words[2] + @"\data.json";

        private string[] ArrayAns,ArrayHint;

        private int round = 0;
        private int sumpoint = 0;
        int timeLeft = 60;
        int oldRandTip;
        bool gameOver = false;

        private string answser,hint;

        public playGame()
        {
            InitializeComponent();
            this.CenterToScreen();
            readAns();
            readHint();
            startGame();
           
        }
        private void startGame()
        {
            gameOver = false;
            while (!gameOver)
            {
                randomChoice();
            }


        }
       private void readAns()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("travel.csv");
            ArrayAns = new string[readText.Length];


            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                ArrayAns[index++] = line[1];
              

            }
        }

        private void readHint()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("travel.csv");
            ArrayHint = new string[readText.Length];


            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                ArrayHint[index++] = line[2];
                

            }
        }

        private void randomChoice()
        {
            var rand = new Random();
            int tip = rand.Next(0, ArrayAns.Length);
            while(oldRandTip == tip)
            {
                tip = rand.Next(0, ArrayAns.Length);
            }

            answser = ArrayAns[tip];
            hint = ArrayHint[tip];
            label2.Text = hint;
            oldRandTip = tip;
            TextAns.Text = String.Empty;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSelectType().Show();
        }

     

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
          
        }


    }
}
