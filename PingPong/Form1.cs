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
        public int gifts = 0;

        public Form1()
        {
            InitializeComponent();

            timer_movement.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Pause_lbl.Left = (Playground.Width/2) - (Pause_lbl.Width/2);
            Pause_lbl.Top = (Playground.Height / 2) - (Pause_lbl.Height / 2);


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

            //Collision gift-ball
            if ((Ball.Bottom >= GiftBox.Top && Ball.Bottom <= GiftBox.Bottom && Ball.Left >= GiftBox.Left && Ball.Right <= GiftBox.Right) ||
                (Ball.Top <= GiftBox.Bottom && Ball.Top >= GiftBox.Top && Ball.Left >= GiftBox.Left && Ball.Right <= GiftBox.Right) ||
                (Ball.Left >= GiftBox.Right && Ball.Left <= GiftBox.Left && Ball.Bottom >= GiftBox.Bottom && Ball.Top <= GiftBox.Top) ||
                (Ball.Right <= GiftBox.Left && Ball.Right >= GiftBox.Right && Ball.Top <= GiftBox.Top && Ball.Bottom >= GiftBox.Bottom)
                )
            {
                Random r = new Random();
                int position_width = r.Next(0, Playground.Width);
                int position_height = r.Next(0, Playground.Height - Ball.Height);
                Point newPosition =  new Point(position_width, position_height);
                GiftBox.Location = newPosition;
                gifts += 1;
                GiftScore.Text = gifts.ToString();
                
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

            if(e.KeyCode == Keys.Space)
            {
                speed_left = 0;
                speed_top = 0;
                Pause_lbl.Visible = true;
            }

            if(e.KeyCode == Keys.Enter)
            {
                Pause_lbl.Visible = false;
                speed_top = 4;
                speed_left = 4;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
