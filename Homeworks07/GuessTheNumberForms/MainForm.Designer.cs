
namespace GuessTheNumberFormMain
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Location = new System.Drawing.Point(300, 32);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(183, 73);
            this.BtnNewGame.TabIndex = 0;
            this.BtnNewGame.Text = "NewGame";
            this.BtnNewGame.UseVisualStyleBackColor = true;
      // this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(176, 263);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(432, 133);
            this.BtnAnswer.TabIndex = 1;
            this.BtnAnswer.Text = "Answer";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 155);
            this.label1.MaximumSize = new System.Drawing.Size(300, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.MaximumSize = new System.Drawing.Size(300, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.BtnNewGame);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

