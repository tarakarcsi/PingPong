namespace PingPong
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
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer_movement = new System.Windows.Forms.Timer(this.components);
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.Playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.Points);
            this.Playground.Controls.Add(this.Score);
            this.Playground.Controls.Add(this.Ball);
            this.Playground.Controls.Add(this.Racket);
            this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playground.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(800, 450);
            this.Playground.TabIndex = 0;
            this.Playground.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
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
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Desktop;
            this.Ball.Location = new System.Drawing.Point(409, 222);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
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
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(72, 4);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(19, 21);
            this.Points.TabIndex = 3;
            this.Points.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Playground.ResumeLayout(false);
            this.Playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer_movement;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Points;
    }
}

