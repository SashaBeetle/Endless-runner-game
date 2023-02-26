using System.Drawing;
using _2DGame.Data;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _2DGame
{
    public partial class Form1 : Form
    {
        bool moveRight, moveLeft;
        int speed = 20, enmspeed;
        int sizeh = 200, sizew = 200;
        bool gameOver = true;
        int amount_enm = 0;
        Random rand = new Random();
        List<PictureBox> enemys = new List<PictureBox>();
        

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Resource1.Backroad;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MakeEnemys()
        {
            PictureBox newEnemy = new PictureBox();
            newEnemy.Height = 200;
            newEnemy.Width = 200;
            newEnemy.Image = Resource1.NPCcar;
            newEnemy.Tag = "Enemy";

            int x = rand.Next(30, 800);
            int y = 12;
            newEnemy.Location = new Point(x, y);

            enemys.Add(newEnemy);
            this.Controls.Add(newEnemy);

            amount_enm++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enemy_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (amount_enm <= 4)
            {
                MakeEnemys();
            }
            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (moveRight == true && player.Left > 0)
            {
                player.Left += speed;
            }


            this.Invalidate();

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                   

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        gameOver = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "border")
                {

                    if (pictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        pictureBox.Refresh();
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
       
    } 
}