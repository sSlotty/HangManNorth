
namespace Hangman
{
    partial class frmSelectType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectType));
            this.travel = new System.Windows.Forms.PictureBox();
            this.language = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.culture = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.travel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.language)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.culture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // travel
            // 
            this.travel.Image = ((System.Drawing.Image)(resources.GetObject("travel.Image")));
            this.travel.Location = new System.Drawing.Point(230, 256);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(324, 72);
            this.travel.TabIndex = 0;
            this.travel.TabStop = false;
            this.travel.Click += new System.EventHandler(this.travel_Click);
            // 
            // language
            // 
            this.language.Image = ((System.Drawing.Image)(resources.GetObject("language.Image")));
            this.language.Location = new System.Drawing.Point(704, 256);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(324, 72);
            this.language.TabIndex = 1;
            this.language.TabStop = false;
            this.language.Click += new System.EventHandler(this.language_Click);
            // 
            // food
            // 
            this.food.Image = ((System.Drawing.Image)(resources.GetObject("food.Image")));
            this.food.Location = new System.Drawing.Point(230, 352);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(324, 72);
            this.food.TabIndex = 2;
            this.food.TabStop = false;
            this.food.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // culture
            // 
            this.culture.Image = ((System.Drawing.Image)(resources.GetObject("culture.Image")));
            this.culture.Location = new System.Drawing.Point(704, 352);
            this.culture.Name = "culture";
            this.culture.Size = new System.Drawing.Size(324, 72);
            this.culture.TabIndex = 3;
            this.culture.TabStop = false;
            this.culture.Click += new System.EventHandler(this.culture_Click);
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(1154, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(45, 43);
            this.backBtn.TabIndex = 4;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1205, -13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(65, 68);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // frmSelectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.culture);
            this.Controls.Add(this.food);
            this.Controls.Add(this.language);
            this.Controls.Add(this.travel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectType";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.travel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.language)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.culture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox travel;
        private System.Windows.Forms.PictureBox language;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.PictureBox culture;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}