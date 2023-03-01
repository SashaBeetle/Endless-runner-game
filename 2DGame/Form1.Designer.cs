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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.BORDER = new System.Windows.Forms.PictureBox();
            this.BORDER2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BORDER3 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.BORDER_SIGN_RIGHT = new System.Windows.Forms.PictureBox();
            this.BORDER_SIGN_LEFT = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Star_Timer = new System.Windows.Forms.Timer(this.components);
            this.starlabel = new System.Windows.Forms.Label();
            this.game_over_picturebox = new System.Windows.Forms.PictureBox();
            this.MusicPlayer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER_SIGN_RIGHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER_SIGN_LEFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_over_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::_2DGame.Resource1.playerCar;
            this.player.Location = new System.Drawing.Point(642, 580);
            this.player.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(101, 200);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "MainCar";
            // 
            // BORDER
            // 
            this.BORDER.Location = new System.Drawing.Point(47, 1151);
            this.BORDER.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BORDER.Name = "BORDER";
            this.BORDER.Size = new System.Drawing.Size(994, 33);
            this.BORDER.TabIndex = 5;
            this.BORDER.TabStop = false;
            this.BORDER.Tag = "border";
            // 
            // BORDER2
            // 
            this.BORDER2.Location = new System.Drawing.Point(41, 1600);
            this.BORDER2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BORDER2.Name = "BORDER2";
            this.BORDER2.Size = new System.Drawing.Size(927, 11);
            this.BORDER2.TabIndex = 6;
            this.BORDER2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BORDER3
            // 
            this.BORDER3.Location = new System.Drawing.Point(11, 2500);
            this.BORDER3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BORDER3.Name = "BORDER3";
            this.BORDER3.Size = new System.Drawing.Size(1035, 21);
            this.BORDER3.TabIndex = 7;
            this.BORDER3.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // BORDER_SIGN_RIGHT
            // 
            this.BORDER_SIGN_RIGHT.Location = new System.Drawing.Point(727, 1111);
            this.BORDER_SIGN_RIGHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BORDER_SIGN_RIGHT.Name = "BORDER_SIGN_RIGHT";
            this.BORDER_SIGN_RIGHT.Size = new System.Drawing.Size(203, 9);
            this.BORDER_SIGN_RIGHT.TabIndex = 8;
            this.BORDER_SIGN_RIGHT.TabStop = false;
            // 
            // BORDER_SIGN_LEFT
            // 
            this.BORDER_SIGN_LEFT.Location = new System.Drawing.Point(197, 1111);
            this.BORDER_SIGN_LEFT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BORDER_SIGN_LEFT.Name = "BORDER_SIGN_LEFT";
            this.BORDER_SIGN_LEFT.Size = new System.Drawing.Size(157, 16);
            this.BORDER_SIGN_LEFT.TabIndex = 9;
            this.BORDER_SIGN_LEFT.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score: 0";
            // 
            // Star_Timer
            // 
            this.Star_Timer.Enabled = true;
            this.Star_Timer.Interval = 40000;
            this.Star_Timer.Tick += new System.EventHandler(this.Star_Timer_Tick_1);
            // 
            // starlabel
            // 
            this.starlabel.AutoSize = true;
            this.starlabel.BackColor = System.Drawing.Color.Transparent;
            this.starlabel.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.starlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.starlabel.Location = new System.Drawing.Point(830, 22);
            this.starlabel.Name = "starlabel";
            this.starlabel.Size = new System.Drawing.Size(92, 28);
            this.starlabel.TabIndex = 11;
            this.starlabel.Text = "Stars: 0";
            // 
            // game_over_picturebox
            // 
            this.game_over_picturebox.BackgroundImage = global::_2DGame.Resource1.game_over;
            this.game_over_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_over_picturebox.InitialImage = global::_2DGame.Resource1.game_over;
            this.game_over_picturebox.Location = new System.Drawing.Point(0, 0);
            this.game_over_picturebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game_over_picturebox.Name = "game_over_picturebox";
            this.game_over_picturebox.Size = new System.Drawing.Size(958, 848);
            this.game_over_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_over_picturebox.TabIndex = 12;
            this.game_over_picturebox.TabStop = false;
            this.game_over_picturebox.Visible = false;
            this.game_over_picturebox.Click += new System.EventHandler(this.game_over_picturebox_Click_1);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Interval = 120000;
            this.MusicPlayer.Tick += new System.EventHandler(this.MusicPlayer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2DGame.Resource1.Backroad;
            this.ClientSize = new System.Drawing.Size(958, 848);
            this.Controls.Add(this.starlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BORDER_SIGN_LEFT);
            this.Controls.Add(this.BORDER_SIGN_RIGHT);
            this.Controls.Add(this.BORDER3);
            this.Controls.Add(this.BORDER2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.BORDER);
            this.Controls.Add(this.game_over_picturebox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Endless-Car-Game";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER_SIGN_RIGHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER_SIGN_LEFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_over_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Timer MusicPlayer;
    }
}