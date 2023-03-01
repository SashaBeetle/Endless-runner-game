using System.Windows.Forms;

namespace _2DGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            BORDER = new PictureBox();
            BORDER2 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            BORDER3 = new PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            BORDER_SIGN_RIGHT = new PictureBox();
            BORDER_SIGN_LEFT = new PictureBox();
            label1 = new Label();
            Star_Timer = new System.Windows.Forms.Timer(components);
            starlabel = new Label();
            game_over_picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BORDER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BORDER2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BORDER3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BORDER_SIGN_RIGHT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BORDER_SIGN_LEFT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)game_over_picturebox).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick_1;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Resource1.playerCar;
            player.Location = new Point(562, 493);
            player.Name = "player";
            player.Size = new Size(88, 170);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 4;
            player.TabStop = false;
            player.Tag = "MainCar";
            // 
            // BORDER
            // 
            BORDER.Location = new Point(41, 978);
            BORDER.Name = "BORDER";
            BORDER.Size = new Size(870, 28);
            BORDER.TabIndex = 5;
            BORDER.TabStop = false;
            BORDER.Tag = "border";
            BORDER.Click += BORDER_Click;
            // 
            // BORDER2
            // 
            BORDER2.Location = new Point(36, 1360);
            BORDER2.Name = "BORDER2";
            BORDER2.Size = new Size(811, 9);
            BORDER2.TabIndex = 6;
            BORDER2.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // BORDER3
            // 
            BORDER3.Location = new Point(10, 2125);
            BORDER3.Name = "BORDER3";
            BORDER3.Size = new Size(906, 18);
            BORDER3.TabIndex = 7;
            BORDER3.TabStop = false;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // BORDER_SIGN_RIGHT
            // 
            BORDER_SIGN_RIGHT.Location = new Point(636, 944);
            BORDER_SIGN_RIGHT.Name = "BORDER_SIGN_RIGHT";
            BORDER_SIGN_RIGHT.Size = new Size(178, 8);
            BORDER_SIGN_RIGHT.TabIndex = 8;
            BORDER_SIGN_RIGHT.TabStop = false;
            // 
            // BORDER_SIGN_LEFT
            // 
            BORDER_SIGN_LEFT.Location = new Point(172, 944);
            BORDER_SIGN_LEFT.Name = "BORDER_SIGN_LEFT";
            BORDER_SIGN_LEFT.Size = new Size(137, 14);
            BORDER_SIGN_LEFT.TabIndex = 9;
            BORDER_SIGN_LEFT.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 10;
            label1.Text = "Score: 0";
            // 
            // Star_Timer
            // 
            Star_Timer.Enabled = true;
            Star_Timer.Interval = 40000;
            Star_Timer.Tick += Star_Timer_Tick;
            // 
            // starlabel
            // 
            starlabel.AutoSize = true;
            starlabel.BackColor = Color.Transparent;
            starlabel.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            starlabel.ForeColor = Color.WhiteSmoke;
            starlabel.Location = new Point(845, 19);
            starlabel.Name = "starlabel";
            starlabel.Size = new Size(75, 23);
            starlabel.TabIndex = 11;
            starlabel.Text = "Stars: 0";
            // 
            // game_over_picturebox
            // 
            game_over_picturebox.BackgroundImage = Resource1.game_over;
            game_over_picturebox.Dock = DockStyle.Fill;
            game_over_picturebox.InitialImage = Resource1.game_over;
            game_over_picturebox.Location = new Point(0, 0);
            game_over_picturebox.Name = "game_over_picturebox";
            game_over_picturebox.Size = new Size(953, 721);
            game_over_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            game_over_picturebox.TabIndex = 12;
            game_over_picturebox.TabStop = false;
            game_over_picturebox.Visible = false;
            game_over_picturebox.Click += game_over_picturebox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.Backroad;
            ClientSize = new Size(953, 721);
            Controls.Add(starlabel);
            Controls.Add(label1);
            Controls.Add(BORDER_SIGN_LEFT);
            Controls.Add(BORDER_SIGN_RIGHT);
            Controls.Add(BORDER3);
            Controls.Add(BORDER2);
            Controls.Add(player);
            Controls.Add(BORDER);
            Controls.Add(game_over_picturebox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Endless-Car-Game";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            RightToLeftChanged += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += KeyisDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)BORDER).EndInit();
            ((System.ComponentModel.ISupportInitialize)BORDER2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BORDER3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BORDER_SIGN_RIGHT).EndInit();
            ((System.ComponentModel.ISupportInitialize)BORDER_SIGN_LEFT).EndInit();
            ((System.ComponentModel.ISupportInitialize)game_over_picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox player;
        private PictureBox BORDER;
        private PictureBox BORDER2;
        private System.Windows.Forms.Timer timer2;
        private PictureBox BORDER3;
        private System.Windows.Forms.Timer timer3;
        private PictureBox BORDER_SIGN_RIGHT;
        private PictureBox BORDER_SIGN_LEFT;
        private Label label1;
        private System.Windows.Forms.Timer Star_Timer;
        private Label starlabel;
        private PictureBox game_over_picturebox;
    }
}