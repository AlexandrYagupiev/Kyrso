using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Курсо
{   
    public partial class FormGame : Form
    {
        public int score = 0;
        bool check = true;
        int timerCount = 0;
        int p1, p2;
        int b = 0;
        SoundPlayer piy = new SoundPlayer("Выстрел.wav");
        public FormGame()
        {
            InitializeComponent();
            this.pictureBoxRocket.BackColor = Color.Transparent;
            this.pictureBoxMeteor.BackColor = Color.Transparent;
            pictureBoxRocket.BringToFront();
            p1 = Size.Width - 150;
            p2 = Size.Height - 550;
        }
        List<PictureBox> pictureBoxesAmmo = new List<PictureBox>();
        private void buttonExitMenu_Click(object sender, EventArgs e)
        {
            MediaPlayerGame.Ctlcontrols.stop();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
            timerDel.Stop();
            timerDel.Dispose();
            timerMeteor.Stop();
            timerMeteor.Dispose();
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            MediaPlayerGame.URL = "Игра.wav";   
        }
        private void Meteor(ref PictureBox meteor)
        {
            meteor.Visible = false;
            int s1 = meteor.Size.Width;
            int s2 = meteor.Size.Height;
            Random rnd = new Random();
            meteor.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
            meteor.Visible = true;
        }
        private bool CheckIntersect(ref PictureBox rect1, ref PictureBox rect2)
        {
            Rectangle mt = new Rectangle(rect1.Location, rect1.Size);
            Rectangle rk = new Rectangle(rect2.Location, rect2.Size);
            if (mt.IntersectsWith(rk))
                return true;
            return false;
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                labelStart.Visible = false;
                timerDel.Start();
                timerMeteor.Start();
            }
            if (e.KeyData == Keys.W && pictureBoxRocket.Location.Y >= 0)
            {
                Size save = pictureBoxRocket.Size;
                pictureBoxRocket.Size = new Size(1, 1);
                pictureBoxRocket.Location = new Point(pictureBoxRocket.Location.X, pictureBoxRocket.Location.Y - 10);
                pictureBoxRocket.Size = save;
                if (CheckIntersect(ref pictureBoxRocket, ref pictureBoxMeteor))
                {
                    b++;
                    Meteor(ref pictureBoxMeteor);
                }
            }
            if (e.KeyData == Keys.S && pictureBoxRocket.Location.Y < this.Height - pictureBoxRocket.Height - 94)
            {
                Size save = pictureBoxRocket.Size;
                pictureBoxRocket.Size = new Size(1, 1);
                pictureBoxRocket.Location = new Point(pictureBoxRocket.Location.X, pictureBoxRocket.Location.Y + 10);
                pictureBoxRocket.Size = save;

                if (CheckIntersect(ref pictureBoxRocket, ref pictureBoxMeteor))
                {
                    b++;
                    Meteor(ref pictureBoxMeteor);
                }
            }
            if (e.KeyData == Keys.A && pictureBoxRocket.Location.X + 10 >= 0)
            {
                Size save = pictureBoxRocket.Size;
                pictureBoxRocket.Size = new Size(1, 1);
                pictureBoxRocket.Location = new Point(pictureBoxRocket.Location.X - 10, pictureBoxRocket.Location.Y);
                pictureBoxRocket.Size = save;

                if (CheckIntersect(ref pictureBoxRocket, ref pictureBoxMeteor))
                {
                    b++;
                    Meteor(ref pictureBoxMeteor);
                }
            }
            if (e.KeyData == Keys.D && pictureBoxRocket.Location.X <= this.Width - pictureBoxRocket.Width - 10)
            {
                Size save = pictureBoxRocket.Size;
                pictureBoxRocket.Size = new Size(1, 1);
                pictureBoxRocket.Location = new Point(pictureBoxRocket.Location.X + 10, pictureBoxRocket.Location.Y);
                pictureBoxRocket.Size = save;

                if (CheckIntersect(ref pictureBoxRocket, ref pictureBoxMeteor))
                {
                    b++;
                    Meteor(ref pictureBoxMeteor);
                }
            }
            if (e.KeyData == Keys.Space)
            {
                if (check)
                {
                    PictureBox pictureBoxAmmo = new PictureBox()
                    {
                        Location = new Point(pictureBoxRocket.Location.X + 20, pictureBoxRocket.Location.Y),
                        BackColor = Color.Yellow,
                        Width = 5,
                        Height = 10,
                    };
                    this.Controls.Add(pictureBoxAmmo);
                    pictureBoxesAmmo.Add(pictureBoxAmmo);
                    check = false;
                    timerShot.Dispose();
                    timerShot.Start();
                    piy.Play();
                }
            }

        }
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBoxesAmmo.Count; i++)
            {
                PictureBox pic = pictureBoxesAmmo[i];

                Size save = pic.Size;
                pic.Size = new Size(1, 1);
                pic.Location = new Point(pic.Location.X, pic.Location.Y - 10);
                pic.Size = save;

                if (CheckIntersect(ref pic, ref pictureBoxMeteor))
                {
                    score += 100;
                    Meteor(ref pictureBoxMeteor);
                    pic.Dispose();
                    pictureBoxesAmmo.Remove(pic);
                    i--;
                }
                else
                {
                    if (pic.Location.Y <= 1)
                    {
                        pic.Dispose();
                        pictureBoxesAmmo.Remove(pictureBoxesAmmo[i]);
                        i--;
                    }
                }
                labelScore.Text = score.ToString();
            }
        }
        private void timerShot_Tick(object sender, EventArgs e)
        {
            timerCount++;
            if (timerCount == 1)
            {
                check = true;
                timerShot.Stop();
                timerShot.Dispose();
                timerCount = 0;
            }
        }
        private void CheckHP()
        {
            switch (b)
            {
                case 1: pictureBoxHP3.Visible = false; break;
                case 2: pictureBoxHP2.Visible = false; break;
                case 3:
                    {
                        pictureBoxHP1.Visible = false;

                        timerDel.Stop();
                        timerDel.Dispose();

                        timerShot.Stop();
                        timerShot.Dispose();

                        timerMeteor.Stop();
                        timerMeteor.Dispose();

                        pictureBoxRocket.Visible = false;
                        pictureBoxMeteor.Visible = false;

                        MessageBox.Show("GAME OVER" + "\n" + "Ваш счёт:" + score.ToString());
                        Form rec = new Form()
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            Size = new Size(400, 400),
                            BackgroundImage = Курсо.Properties.Resources.Rec,
                            FormBorderStyle = FormBorderStyle.FixedSingle,
                        };
                        TextBox Name = new TextBox
                        {
                            Location = new Point(220, 100),
                            Text = "",
                            Size = new Size(80, 25),
                        };
                        Label Score = new Label
                        {
                            Location = new Point(200, 150),
                            Text = score.ToString(),
                        };
                        Label label1 = new Label
                        {
                            Location = new Point(125, 100),
                            Text = "Введите Имя",
                            ForeColor = Color.White,
                            BackgroundImage = Курсо.Properties.Resources.Rec,
                        };
                        Label label2 = new Label
                        {
                            Location = new Point(125, 150),
                            Text = "Очки",
                            ForeColor = Color.White,
                            BackgroundImage = Курсо.Properties.Resources.Rec,
                        };
                        Button ok = new Button
                        {
                            Location = new Point(300, 300),
                            Text = "OK",
                            ForeColor = Color.White,
                            BackgroundImage = Курсо.Properties.Resources.Rec,
                            DialogResult=DialogResult.OK,
                        };
                        void ButtonOK(object sender, EventArgs e)
                        {
                            StreamWriter stream = new StreamWriter("Record.txt", true);
                            stream.Write("{0} {1};",Name.Text,Score.Text);
                            stream.Close();
                            MediaPlayerGame.Ctlcontrols.stop();
                        }
                        ok.Click += ButtonOK;
                        rec.Controls.Add(Name);
                        rec.Controls.Add(Score);
                        rec.Controls.Add(label1);
                        rec.Controls.Add(label2);
                        rec.Controls.Add(ok);
                        rec.ShowDialog();
                        FormRecord formRecord = new FormRecord();
                        formRecord.Show();
                        this.Hide();
                    }
                    break;
            }
        }
        private void timerMeteor_Tick(object sender, EventArgs e)
        {
            if (pictureBoxMeteor.Location.Y < this.Height - pictureBoxMeteor.Height - 97)
            {
                Size save = pictureBoxMeteor.Size;
                pictureBoxMeteor.Size = new Size(1, 1);
                pictureBoxMeteor.Location = new Point(pictureBoxMeteor.Location.X, pictureBoxMeteor.Location.Y + 2);
                pictureBoxMeteor.Size = save;
            }
            else
            {
                b++;
                Meteor(ref pictureBoxMeteor);
                CheckHP();
                return;
            }

            if (CheckIntersect(ref pictureBoxMeteor, ref pictureBoxRocket))
            {
                b++;
                Meteor(ref pictureBoxMeteor);
                CheckHP();
            }
        }
    }
}






