using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool drag = false;
        Point StartPoint = new Point(0, 0);
        int player;
        int bot;


        public Form1()
        {
            InitializeComponent();
        }


        private void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Salmon;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Black;
        }

        private void minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.SteelBlue;
        }

        private void minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.Black;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            while(game_panel.Location.X != 0)
            {
                game_panel.Location = new Point(game_panel.Location.X - 1, game_panel.Location.Y);
            }
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            while (game_panel.Location.X != 800)
            {
                game_panel.Location = new Point(game_panel.Location.X + 1, game_panel.Location.Y);
            }
        }

        private void rock_btn_Click(object sender, EventArgs e)
        {
            player_box.Image = Properties.Resources.rock;

            player = 1;
            bot = rnd.Next(1, 4);

            if(bot == 1)
            {
                bot_box.Image = Properties.Resources.rock;
                label2.Text = "Draw";
            }

            else if(bot == 2)
            {
                bot_box.Image = Properties.Resources.real_paper;
                label2.Text = "Bot won!";
            }

            else
            {
                bot_box.Image = Properties.Resources.paper;
                label2.Text = "You won!";
            }
        }

        private void paper_btn_Click(object sender, EventArgs e)
        {
            player_box.Image = Properties.Resources.real_paper;
            player = 2;
            bot = rnd.Next(1, 4);


            if (bot == 1)
            {
                bot_box.Image = Properties.Resources.rock;
                label2.Text = "You won!";
            }

            else if (bot == 2)
            {
                bot_box.Image = Properties.Resources.real_paper;
                label2.Text = "Draw";
            }

            else
            {
                bot_box.Image = Properties.Resources.paper;
                label2.Text = "Bot won!";
            }
        }

        private void scissors_btn_Click(object sender, EventArgs e)
        {
            player_box.Image = Properties.Resources.paper;
            player = 3;
            bot = rnd.Next(1, 4);

            if (bot == 1)
            {
                bot_box.Image = Properties.Resources.rock;
                label2.Text = "Bot won!";
            }

            else if (bot == 2)
            {
                bot_box.Image = Properties.Resources.real_paper;
                label2.Text = "You won!";
            }

            else
            {
                bot_box.Image = Properties.Resources.paper;
                label2.Text = "Draw";
            }
        }

        private void ControlBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
