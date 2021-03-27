using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class playGame : Form
    {
        string Type = null;

        public playGame()
        {
            InitializeComponent();
            this.CenterToScreen();

        }
        public void setType(string type)
        {
            this.Type = type;
            titleType.Text = type;
            showType();
        }

        public String getType()
        {
            return this.Type;
        }
        
        public void showType()
        {
            MessageBox.Show(getType());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
