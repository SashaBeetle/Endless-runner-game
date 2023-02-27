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
        int speed = 20, enmspeed = 1, score = 0;
        bool gameOver = true;
        int amount_enm = 0;
        int amount_signL = 0, amount_signR = 0;
        Random rand = new Random();
        List<PictureBox> enemys = new List<PictureBox>();
        List<PictureBox> marksL = new List<PictureBox>();
        List<PictureBox> marksR = new List<PictureBox>();






        public Form1()
        {
            
            InitializeComponent();
            this.BackgroundImage = Resource1.Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void makeMarkL()
        {
            PictureBox newMarkl = new PictureBox();
            newMarkl.Height = 100;
            newMarkl.Width = 10;
            newMarkl.BackColor = Color.WhiteSmoke;
            newMarkl.Tag = "Marking";
            newMarkl.Location= new Point(270, -70);
            newMarkl.SendToBack();
            this.Controls.Add(newMarkl);
            marksL.Add(newMarkl);
            amount_signL++;
        }
        private void makeMarkR()
        {
            PictureBox newMarkR = new PictureBox();
            newMarkR.Height = 100;
            newMarkR.Width = 10;
            newMarkR.BackColor = Color.WhiteSmoke;
            newMarkR.Tag = "Marking";
            newMarkR.Location = new Point(825, -70);
            newMarkR.SendToBack();
            this.Controls.Add(newMarkR);
            marksR.Add(newMarkR);
            amount_signR++;
        }
        private void MakeEnemys()
        {
            PictureBox newEnemy = new PictureBox();
            newEnemy.Height = 200;
            newEnemy.Width = 100;
            newEnemy.Image = Resource1.NPCcar;
            newEnemy.Tag = "Enemy";
            newEnemy.BringToFront();
            int x=0;
            

            int pos = rand.Next(1,5);
            if (pos == 1) { x = 90; } else if (pos == 2) { x = 360; } else if (pos == 3) { x = 650; } else if(pos == 4) { x = 917; }
           
            

            int y = -400;
            newEnemy.Location = new Point(x, y);

            enemys.Add(newEnemy);
            this.Controls.Add(newEnemy);
            amount_enm++;
        }

        private void Form1_Load(object sender, EventArgs e)
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

      

        private void BORDER_Click(object sender, EventArgs e)
        {

        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {

           
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "Marking")
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (amount_signL <= 6)
            {
                makeMarkL();
            }
            if (amount_signR <= 6)
            {
                makeMarkR();
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            score++;
            if (amount_enm <= 3)
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

            label1.Text = "Score: " + score;


            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                    x.Top += speed;

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        gameOver = true;
                    }
                }

          
                
            }
           
            foreach(PictureBox en in enemys.ToList())
            {
                if (BORDER.Bounds.IntersectsWith(en.Bounds))
                {
                    enemys.Remove(en);
                    this.Controls.Remove(en);
                    amount_enm--;
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
       
    } 
}