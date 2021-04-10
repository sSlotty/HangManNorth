
namespace Hangman
{
    partial class playGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TextAns = new System.Windows.Forms.TextBox();
            this.TextPoint = new System.Windows.Forms.Label();
            this.submitBox = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.TextHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1134, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 43);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1184, -8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 63);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // TextAns
            // 
            this.TextAns.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextAns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAns.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextAns.Location = new System.Drawing.Point(675, 444);
            this.TextAns.Multiline = true;
            this.TextAns.Name = "TextAns";
            this.TextAns.PlaceholderText = "Answer";
            this.TextAns.Size = new System.Drawing.Size(544, 73);
            this.TextAns.TabIndex = 3;
            // 
            // TextPoint
            // 
            this.TextPoint.AutoSize = true;
            this.TextPoint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextPoint.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPoint.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextPoint.Location = new System.Drawing.Point(291, 548);
            this.TextPoint.Name = "TextPoint";
            this.TextPoint.Size = new System.Drawing.Size(0, 114);
            this.TextPoint.TabIndex = 4;
            // 
            // submitBox
            // 
            this.submitBox.BackColor = System.Drawing.Color.White;
            this.submitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBox.Image = ((System.Drawing.Image)(resources.GetObject("submitBox.Image")));
            this.submitBox.Location = new System.Drawing.Point(1058, 548);
            this.submitBox.Margin = new System.Windows.Forms.Padding(0);
            this.submitBox.Name = "submitBox";
            this.submitBox.Size = new System.Drawing.Size(197, 71);
            this.submitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.submitBox.TabIndex = 5;
            this.submitBox.TabStop = false;
            this.submitBox.Click += new System.EventHandler(this.submitBox_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(109, 60);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(445, 442);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(109, 60);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(445, 442);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 8;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(109, 60);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(445, 442);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 9;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(109, 60);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(445, 442);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 10;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(109, 60);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(445, 442);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 11;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
            this.pic6.Location = new System.Drawing.Point(109, 60);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(445, 442);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6.TabIndex = 12;
            this.pic6.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
            this.pic7.Location = new System.Drawing.Point(109, 60);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(445, 442);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic7.TabIndex = 13;
            this.pic7.TabStop = false;
            // 
            // TextHint
            // 
            this.TextHint.AutoSize = true;
            this.TextHint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextHint.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextHint.Location = new System.Drawing.Point(708, 106);
            this.TextHint.Name = "TextHint";
            this.TextHint.Size = new System.Drawing.Size(90, 37);
            this.TextHint.TabIndex = 14;
            this.TextHint.Text = "label1";
            this.TextHint.Click += new System.EventHandler(this.TextHint_Click);
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TextHint);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.submitBox);
            this.Controls.Add(this.TextPoint);
            this.Controls.Add(this.TextAns);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "playGame";
            this.Text = "Play Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TextAns;
        private System.Windows.Forms.Label TextPoint;
        private System.Windows.Forms.PictureBox submitBox;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.Label TextHint;
    }
}