﻿namespace PingPong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Playground = new System.Windows.Forms.Panel();
            this.GiftScore = new System.Windows.Forms.Label();
            this.Gifts_lbl = new System.Windows.Forms.Label();
            this.GiftBox = new System.Windows.Forms.PictureBox();
            this.LevelScore = new System.Windows.Forms.Label();
            this.Level_lbl = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer_movement = new System.Windows.Forms.Timer(this.components);
            this.Pause_lbl = new System.Windows.Forms.Label();
            this.Playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.Pause_lbl);
            this.Playground.Controls.Add(this.GiftScore);
            this.Playground.Controls.Add(this.Gifts_lbl);
            this.Playground.Controls.Add(this.GiftBox);
            this.Playground.Controls.Add(this.LevelScore);
            this.Playground.Controls.Add(this.Level_lbl);
            this.Playground.Controls.Add(this.GameOver);
            this.Playground.Controls.Add(this.Points);
            this.Playground.Controls.Add(this.Score);
            this.Playground.Controls.Add(this.Ball);
            this.Playground.Controls.Add(this.Racket);
            this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playground.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(800, 440);
            this.Playground.TabIndex = 0;
            this.Playground.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
            // 
            // GiftScore
            // 
            this.GiftScore.AutoSize = true;
            this.GiftScore.ForeColor = System.Drawing.Color.Gold;
            this.GiftScore.Location = new System.Drawing.Point(72, 25);
            this.GiftScore.Name = "GiftScore";
            this.GiftScore.Size = new System.Drawing.Size(19, 21);
            this.GiftScore.TabIndex = 9;
            this.GiftScore.Text = "0";
            // 
            // Gifts_lbl
            // 
            this.Gifts_lbl.AutoSize = true;
            this.Gifts_lbl.ForeColor = System.Drawing.Color.Gold;
            this.Gifts_lbl.Location = new System.Drawing.Point(24, 25);
            this.Gifts_lbl.Name = "Gifts_lbl";
            this.Gifts_lbl.Size = new System.Drawing.Size(51, 21);
            this.Gifts_lbl.TabIndex = 8;
            this.Gifts_lbl.Text = "Gifts: ";
            // 
            // GiftBox
            // 
            this.GiftBox.BackColor = System.Drawing.Color.Gold;
            this.GiftBox.Location = new System.Drawing.Point(367, 57);
            this.GiftBox.Name = "GiftBox";
            this.GiftBox.Size = new System.Drawing.Size(120, 103);
            this.GiftBox.TabIndex = 7;
            this.GiftBox.TabStop = false;
            // 
            // LevelScore
            // 
            this.LevelScore.AutoSize = true;
            this.LevelScore.Location = new System.Drawing.Point(708, 4);
            this.LevelScore.Name = "LevelScore";
            this.LevelScore.Size = new System.Drawing.Size(19, 21);
            this.LevelScore.TabIndex = 6;
            this.LevelScore.Text = "0";
            // 
            // Level_lbl
            // 
            this.Level_lbl.AutoSize = true;
            this.Level_lbl.Location = new System.Drawing.Point(663, 4);
            this.Level_lbl.Name = "Level_lbl";
            this.Level_lbl.Size = new System.Drawing.Size(50, 21);
            this.Level_lbl.TabIndex = 5;
            this.Level_lbl.Text = "Level:";
            // 
            // GameOver
            // 
            this.GameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(493, 117);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(117, 130);
            this.GameOver.TabIndex = 4;
            this.GameOver.Text = "NOOB!\r\n\r\nF1 - Restart\r\n\r\nEscape - Exit\r\n";
            this.GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(72, 4);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(19, 21);
            this.Points.TabIndex = 3;
            this.Points.Text = "0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(23, 4);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(53, 21);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score:";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Desktop;
            this.Ball.Location = new System.Drawing.Point(409, 222);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Crimson;
            this.Racket.Location = new System.Drawing.Point(327, 329);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(200, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer_movement
            // 
            this.timer_movement.Interval = 1;
            this.timer_movement.Tick += new System.EventHandler(this.timer_movement_Tick);
            // 
            // Pause_lbl
            // 
            this.Pause_lbl.AutoSize = true;
            this.Pause_lbl.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.Pause_lbl.Location = new System.Drawing.Point(144, 181);
            this.Pause_lbl.Name = "Pause_lbl";
            this.Pause_lbl.Size = new System.Drawing.Size(211, 52);
            this.Pause_lbl.TabIndex = 10;
            this.Pause_lbl.Text = "         Game Paused\r\nPress Enter to Continue";
            this.Pause_lbl.Visible = false;
            this.Pause_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.Playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Playground.ResumeLayout(false);
            this.Playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer_movement;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label LevelScore;
        private System.Windows.Forms.Label Level_lbl;
        private System.Windows.Forms.PictureBox GiftBox;
        private System.Windows.Forms.Label GiftScore;
        private System.Windows.Forms.Label Gifts_lbl;
        private System.Windows.Forms.Label Pause_lbl;
    }
}

