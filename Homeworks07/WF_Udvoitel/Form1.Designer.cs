
using System;

namespace WF_Udvoitel
{
    partial class Form1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.MenuStrip();
            this.StartNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.udoBtn = new System.Windows.Forms.Button();
            this.NewGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(297, 30);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(117, 42);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(297, 111);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(117, 42);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(297, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 42);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoEllipsis = true;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNumber.Location = new System.Drawing.Point(0, 28);
            this.lblNumber.MaximumSize = new System.Drawing.Size(250, 300);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // NewGame
            // 
            this.NewGame.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.NewGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NewGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNewGame});
            this.NewGame.Location = new System.Drawing.Point(0, 0);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(444, 28);
            this.NewGame.TabIndex = 4;
            this.NewGame.Text = "menuStrip1";
            this.NewGame.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NewGame_ItemClicked);
            // 
            // StartNewGame
            // 
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(92, 24);
            this.StartNewGame.Text = "NewGame";
            // 
            // udoBtn
            // 
            this.udoBtn.Location = new System.Drawing.Point(113, 255);
            this.udoBtn.Name = "udoBtn";
            this.udoBtn.Size = new System.Drawing.Size(117, 42);
            this.udoBtn.TabIndex = 5;
            this.udoBtn.Text = "button3";
            this.udoBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 348);
            this.Controls.Add(this.udoBtn);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.NewGame);
            this.MainMenuStrip = this.NewGame;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewGame.ResumeLayout(false);
            this.NewGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = String.Empty;
            udoBtn.Text = "Отмена";
            lblNumber.Text = p.Result.ToString();
            this.Text = "Удвоитель";
            btnCommand1.Visible = false;
            btnCommand2.Visible = false;
            btnReset.Visible = false;
            udoBtn.Visible = false;
        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.MenuStrip NewGame;
        private System.Windows.Forms.ToolStripMenuItem StartNewGame;
        private System.Windows.Forms.Button udoBtn;
    }
}

