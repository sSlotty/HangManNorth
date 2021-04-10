
namespace Hangman
{
    partial class frmRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRule));
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(1142, 34);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 68);
            this.backBtn.TabIndex = 6;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1200, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 68);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // frmRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRule";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}