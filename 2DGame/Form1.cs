using System.Collections.Generic;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace _2DGame  /* The game was made by
                      Oleksandr Zhuk(https://github.com/SashaBeetle),
                      Oleksandr Zakala(https://github.com/Rovikido),
                      Synytskyi Vitalii(https://github.com/VitaliySynytskyi);
                   */
{
    public partial class Form1 : Form
    {
        //all variables 
        bool moveRight, moveLeft;
        int speed = 20, score = 0;
        float difficulty = 1f;
        bool gameOver = false;
        int amount_signL = 0, amount_signR = 0, amount_enm = 0, amount_star = 0;
        Random rand = new Random();
        List<PictureBox> enemys = new List<PictureBox>();
        List<PictureBox> marksL = new List<PictureBox>();
        List<PictureBox> marksR = new List<PictureBox>();
        List<PictureBox> stars = new List<PictureBox>();
        IDictionary<PictureBox, int> enemy_speed = new Dictionary<PictureBox, int>();
        List<Image> carSprites = new List<Image>();
        List<int> spawn_positions = new List<int>() { 90, 320, 570, 780 };
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer crash = new System.Media.SoundPlayer();




        //utility variables
        Random rnd = new Random();
        int frame_count = 0, prev_enemy_spawn = 0;

        //Form(Window)
        public Form1()
        {
            InitializeComponent();

            //Add resources
            carSprites.Add(Resource1.NPCcar1);
            carSprites.Add(Resource1.NPCcar2);
            carSprites.Add(Resource1.NPCcar3);
            carSprites.Add(Resource1.NPCcar4);
            carSprites.Add(Resource1.NPCcar5);

            this.BackgroundImage = Resource1.Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            music.SoundLocation = "KADILAK.wav";
            crash.SoundLocation = "CRASH.wav";
            music.Play();
        }
        //Making stars
        private void makeStar()
        {
            PictureBox newStar = new PictureBox();
            newStar.Image = Resource1.Star;
            newStar.Height = 100;
            newStar.Width = 100;
            newStar.Tag = "Star";
            newStar.BackColor = Color.Transparent;
            this.Controls.Add(newStar);
            stars.Add(newStar);

            int pos = rand.Next(0, 4);
            newStar.Location = new Point(spawn_positions[pos], -400);

        }
        //Making left road marking
        private void makeMarkL()
        {
            PictureBox newMarkl = new PictureBox();
            newMarkl.Height = 100;
            newMarkl.Width = 10;
            newMarkl.BackColor = Color.WhiteSmoke;
            newMarkl.Tag = "Marking";
            newMarkl.Location = new Point(250, -70);
            newMarkl.SendToBack();
            this.Controls.Add(newMarkl);
            marksL.Add(newMarkl);
            amount_signL++;
        }
        //Making right road marking
        private void makeMarkR()
        {
            PictureBox newMarkR = new PictureBox();
            newMarkR.Height = 100;
            newMarkR.Width = 10;
            newMarkR.BackColor = Color.WhiteSmoke;
            newMarkR.Tag = "Marking";
            newMarkR.Location = new Point(725, -70);
            newMarkR.SendToBack();
            this.Controls.Add(newMarkR);
            marksR.Add(newMarkR);
            amount_signR++;
        }
        //Making Enemys 
        private void MakeEnemys()
        {
            PictureBox newEnemy = new PictureBox();
            newEnemy.Height = 200;
            newEnemy.Width = 100;
            newEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            newEnemy.Tag = "Enemy";
            newEnemy.BringToFront();
            newEnemy.BackColor = Color.Transparent;

            Random rnd2 = new Random();
            newEnemy.Image = carSprites[rnd2.Next(carSprites.Count)];



            int speed = (int)(20 * difficulty * ((rnd.NextDouble() / 3) + 0.85));
            enemy_speed[newEnemy] = speed;

            var sp = new List<int>(spawn_positions);
            sp.RemoveAt(prev_enemy_spawn);

            int pos = rand.Next(0, 3);
            newEnemy.Location = new Point(sp[pos] + rand.Next(-30, 30), -400);

            prev_enemy_spawn = spawn_positions.FindIndex(a => a == sp[pos]);
            enemys.Add(newEnemy);
            this.Controls.Add(newEnemy);
            amount_enm++;
        }
        //Actions when key is Down
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }
        //Actions when key is Up

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }

        //Making crash-window
        private void GameOver()
        {
            crash.Play();

            gameOver = true;

            game_over_picturebox.Visible = true;
            game_over_picturebox.BringToFront();
            label1.Font = new Font(label1.Font.Name, 28, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 149, 184);
            label1.BackColor = Color.WhiteSmoke;

            label1.Top = 383;
            label1.Left = 405;
            label1.BringToFront();
        }
        //Timer for music
        private void MusicPlayer_Tick(object sender, EventArgs e)
        {
            music.Play();
        }
        //Timer for speed(Stars and Road Marking) and Borders
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gameOver) { return; }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Marking")
                {
                    x.Top += speed;
                }
                if (x is PictureBox && (string)x.Tag == "Star")
                {
                    x.Top += speed;
                }

            }
            foreach (PictureBox en in marksL.ToList())
            {
                if (BORDER_SIGN_LEFT.Bounds.IntersectsWith(en.Bounds))
                {
                    marksL.Remove(en);
                    this.Controls.Remove(en);
                    amount_signL--;
                }

            }
            foreach (PictureBox en in marksR.ToList())
            {
                if (BORDER_SIGN_RIGHT.Bounds.IntersectsWith(en.Bounds))
                {
                    marksR.Remove(en);
                    this.Controls.Remove(en);
                    amount_signR--;
                }

            }
            this.Invalidate();

        }
        

        //Refresh after game over
        private void game_over_picturebox_Click_1(object sender, EventArgs e)
        {
            Application.Restart();

        }
        //Timer for making stars
        private void Star_Timer_Tick_1(object sender, EventArgs e)
        {
            if (gameOver) { return; }
            makeStar();
        }
        //Timer for making Left and Right road Marking
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (gameOver) { return; }
            if (amount_signL <= 6)
            {
                makeMarkL();
            }
            if (amount_signR <= 6)
            {
                makeMarkR();
            }
        }
        //Main timer in Solutions
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameOver) { return; }
            score++;
            frame_count--;
            difficulty += 0.003f;
            if (amount_enm <= 5 && frame_count <= 0)
            {
                frame_count = rnd.Next(9, 25);
                MakeEnemys();
            }
            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (moveRight == true && player.Left < 840)
            {
                player.Left += speed;
            }

            label1.Text = "Score: " + score;


            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                    x.Top += enemy_speed[(PictureBox)x];

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        GameOver();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "Star")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        amount_star++;
                        starlabel.Text = "Stars: " + amount_star;
                        score += 500;
                    }
                }



            }

            foreach (PictureBox en in enemys.ToList())
            {
                if (BORDER.Bounds.IntersectsWith(en.Bounds))
                {
                    enemys.Remove(en);
                    enemy_speed.Remove(en);
                    this.Controls.Remove(en);
                    amount_enm--;
                }
            }
            foreach (PictureBox en in stars.ToList())
            {
                if (BORDER.Bounds.IntersectsWith(en.Bounds))
                {
                    stars.Remove(en);
                    this.Controls.Remove(en);
                }
            }
            foreach (PictureBox en in stars.ToList())
            {
                if (player.Bounds.IntersectsWith(en.Bounds))
                {
                    stars.Remove(en);
                    this.Controls.Remove(en);
                }
            }
        } 
    }
}