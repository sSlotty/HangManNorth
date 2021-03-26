
namespace Hangman
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.rultBtn = new System.Windows.Forms.PictureBox();
            this.playGameBtn = new System.Windows.Forms.PictureBox();
            this.scoreBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rultBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // rultBtn
            // 
            this.rultBtn.Image = ((System.Drawing.Image)(resources.GetObject("rultBtn.Image")));
            this.rultBtn.Location = new System.Drawing.Point(12, 619);
            this.rultBtn.Name = "rultBtn";
            this.rultBtn.Size = new System.Drawing.Size(52, 50);
            this.rultBtn.TabIndex = 0;
            this.rultBtn.TabStop = false;
            this.rultBtn.Click += new System.EventHandler(this.rultBtn_Click);
            // 
            // playGameBtn
            // 
            this.playGameBtn.Image = ((System.Drawing.Image)(resources.GetObject("playGameBtn.Image")));
            this.playGameBtn.Location = new System.Drawing.Point(143, 152);
            this.playGameBtn.Name = "playGameBtn";
            this.playGameBtn.Size = new System.Drawing.Size(482, 174);
            this.playGameBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playGameBtn.TabIndex = 1;
            this.playGameBtn.TabStop = false;
            this.playGameBtn.Click += new System.EventHandler(this.playGameBtn_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("scoreBtn.Image")));
            this.scoreBtn.Location = new System.Drawing.Point(648, 152);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(349, 174);
            this.scoreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scoreBtn.TabIndex = 2;
            this.scoreBtn.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1200, 18);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 68);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(1142, 40);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 68);
            this.backBtn.TabIndex = 4;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.playGameBtn);
            this.Controls.Add(this.rultBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rultBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rultBtn;
        private System.Windows.Forms.PictureBox playGameBtn;
        private System.Windows.Forms.PictureBox scoreBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox backBtn;
    }
}