using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRaceApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scoreGained = 0;
        int roadSpeed = 5;
        int myCarSpeed = 5;  // my car speed

        bool leftRoad = false;
        bool rightRoad = false;

        int otherCarSpeed = 5;  //other car speed

        Random random = new Random();


        public void startRace()
        {
            btn_startrace.Enabled = false;
            crash.Visible = false;

            lbl_highscore.Text =Settings1.Default.highScore.ToString();

            myCarSpeed = 7;
            otherCarSpeed = 7;
            scoreGained = 0;

            // cars location

            mycar.Left = 160;
            mycar.Top = 300;

            car1.Left = 30;
            car1.Top = 50;

            car2.Left = 320;
            car2.Top = 50;

            leftRoad = false;
            rightRoad = false;

            crash.Left = 165;
            crash.Top = 294;

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startRace();
            volumeUp();
        }

        private void volumeUp()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesYol = "C:\\Users\\salih\\source\\repos\\CarRaceApplication\\CarRaceApplication\\dilara.wav";
            ses.SoundLocation = sesYol;
            ses.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreGained++;
            lbl_score.Text = scoreGained.ToString();

            road.Top += roadSpeed;
            if (road.Top > 400)
            {
                road.Top = road.Top - 375;
            }

            if (leftRoad)
            {
                mycar.Left -= myCarSpeed;
            }
            if (rightRoad)
            {
                mycar.Left += myCarSpeed;
            }

            if (mycar.Left < 1)
            {
                leftRoad = false;
            }
            else if (mycar.Left + mycar.Width > 510) { rightRoad = false; }

            car1.Top += otherCarSpeed;
            car2.Top += otherCarSpeed;

            if (car1.Top > panel1.Height)
            {
                changeCar1();
                car1.Left = random.Next(20, 50);
                car1.Top = random.Next(40, 140) * (-1);
            }
            if (car2.Top > panel1.Height)
            {
                changeCar2();
                car2.Left = random.Next(20, 250);
                car2.Top = random.Next(40, 140) * (-1);
            }
            if (mycar.Bounds.IntersectsWith(car1.Bounds) || mycar.Bounds.IntersectsWith(car2.Bounds))
            {
                raceOver();
            }

        }

        private void changeCar1()
        {
            int line = random.Next(1, 7);
            switch (line)
            {
                case 1:
                    car1.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    car1.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    car1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car1.Image = Properties.Resources.araba7;
                    break;
            }
        }

        private void changeCar2()
        {
            int line = random.Next(1, 7);
            switch (line)
            {
                case 1:
                    car2.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    car2.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    car2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    car2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    car2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    car2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    car2.Image = Properties.Resources.araba7;
                    break;
            }
        }


        private void raceOver()
        {
            timer1.Stop();
            if(Convert.ToInt32(lbl_score.Text) > Convert.ToInt32(Settings1.Default.highScore.ToString())) {

           //     Settings1.Default.highScore = lbl_score.Text;
            }


            btn_startrace.Enabled = true;
            crash.Visible = true;

            mycar.Controls.Add(crash);
            crash.Location = new Point(7, -5);

            crash.BringToFront();
            crash.BackColor = Color.Transparent;

            MessageBox.Show("Congratulations Score Gained :" + lbl_score.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0) { leftRoad = true; }
            if (e.KeyCode == Keys.Right && mycar.Left + mycar.Width < panel1.Width)
            {
                rightRoad = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftRoad = false; }
            if (e.KeyCode == Keys.Right) { rightRoad = false; }
        }

        private void btn_startrace_Click(object sender, EventArgs e)
        {
            startRace();
            volumeUp();
        }
    }
}
