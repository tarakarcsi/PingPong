using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public int level = 0;

        public Form1()
        {
            InitializeComponent();

            timer_movement.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            Racket.Top = Playground.Bottom - (Playground.Bottom / 10);

            GameOver.Left = (Playground.Width / 2) - (GameOver.Width / 2);
            GameOver.Top = (Playground.Height / 2) - (GameOver.Height / 2);

            GameOver.Visible = false;
            
        }

        private void timer_movement_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            Ball.Left += speed_left;
            Ball.Top += speed_top;

            //Collision racket-ball
            if(Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                Points.Text = points.ToString();
                level = points / 3;
                LevelScore.Text = level.ToString();
            }

            if(Ball.Left <= Playground.Left)
            {
                speed_left = - speed_left;
            }

            if (Ball.Right >= Playground.Right)
            {
                speed_left = -speed_left;
            }

            if (Ball.Top <= Playground.Top)
            {
                speed_top = -speed_top;
            }

            if(Ball.Bottom >= Playground.Bottom)
            {
                timer_movement.Enabled = false;
                GameOver.Visible = true;
            }
        }
        public Boolean Collision_Left(PictureBox obj)
        {
            if (obj.Location.X <= 0)
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox obj)
        {
            if (obj.Location.X + obj.Width >= Playground.Width)
            {
                return true;
            }
            return false;
        }

        private void Playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if(e.KeyCode == Keys.F1)
            {
                Ball.Left = 50;
                Ball.Top = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                Points.Text = "0";
                timer_movement.Enabled = true;
                GameOver.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
