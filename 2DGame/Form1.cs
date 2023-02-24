using System.Drawing;
using _2DGame.Data;

namespace _2DGame
{
    public partial class Form1 : Form
    {
        Image Car;
        bool moveRight, moveLeft;
        int posY = 550, posX = 400;
        int speed = 20;
        int sizeh = 200, sizew = 200;
        public Bitmap Enemycar = Resource1.NPCcar,
                      Usercar = Resource1.USERcar;

        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Resource1.Backroad;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Car = Resource1.USERcar;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) {
                moveLeft= true;
            }
            else if(e.KeyCode == Keys.Right)
            {
                moveRight= true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (moveLeft && posX > 0)
            {
                posX -= speed;
            }
            if (moveRight && posX > 0)
            {
                posX += speed;
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            Canvas.DrawImage(Car, posX, posY, sizew, sizeh);

            
            
            //g.DrawImage(Enemycar,new Rectangle(500,0,200,200));
           // g.DrawImage(Usercar, new Rectangle(700,560,200,200));
           


            

        }
    }
}