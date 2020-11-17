using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class MathTimedGame : Form
    {
        public int timeLeft;
        public int a;
        public int b;
        public int c;
        public string z = " ";

        public MathTimedGame()
        {
            InitializeComponent();
            startButton.Hide();
            doneButton.Hide();
            answerBox.Hide();
            correctanswer.Hide();
            textcorrectanswer.Hide();
            alabel.Hide();
            pluslabel.Hide();
            blabel.Hide();
            alabel.Hide();
            timeleftmore.Hide();
            timerLabel.Hide();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 4;
            Random r = new Random();
            a = r.Next(10) + 1;
            b = r.Next(10) + 1;
            alabel.Text = a.ToString();
            blabel.Text = b.ToString();

            correctanswer.Hide();
            textcorrectanswer.Hide();

            timer1.Start();


            startButton.Enabled = false;
            doneButton.Enabled = true;
        }

        private void MathTimedGame_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();

            timer2.Enabled = true;
            timer2.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0)
            {
                doneButton.Enabled = false;
                startButton.Enabled = true;
                timer1.Stop();
                timerLabel.Text = "TIME UP";

                textcorrectanswer.Enabled = true;
                correctanswer.Enabled = true;

                correctanswer.Show();
                textcorrectanswer.Show();

                correctanswer.Text = c.ToString();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                startButton.Show();
                doneButton.Show();
                answerBox.Show();
                correctanswer.Show();
                textcorrectanswer.Show();
                alabel.Show();
                pluslabel.Show();
                blabel.Show();
                alabel.Show();
                timeleftmore.Show();
                timerLabel.Show();
                pictureBox1.Hide();
                pictureBox2.Hide();
                loading.Hide();
            }

            private void doneButton_Click(object sender, EventArgs e)
            {
                doneButton.Enabled = false;
                startButton.Enabled = true;
                timer1.Stop();
                //this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
                c = a + b;

                if (answerBox.Text == c.ToString())
                {
                    timer1.Stop();
                    timeleftmore.Enabled = false;
                    timerLabel.Text = "YOU WIN";
                    answerBox.Text = null;
                }

                else
                {
                    timerLabel.Text = "YOU LOST";
                }


            }


        }
    } }
