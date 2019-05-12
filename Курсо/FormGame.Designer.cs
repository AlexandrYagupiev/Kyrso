namespace Курсо
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.buttonExitMenu = new System.Windows.Forms.Button();
            this.pictureBoxRocket = new System.Windows.Forms.PictureBox();
            this.pictureBoxMeteor = new System.Windows.Forms.PictureBox();
            this.timerDel = new System.Windows.Forms.Timer(this.components);
            this.timerShot = new System.Windows.Forms.Timer(this.components);
            this.timerMeteor = new System.Windows.Forms.Timer(this.components);
            this.labelScoreTx = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxHP1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHP3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHP2 = new System.Windows.Forms.PictureBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelYprav = new System.Windows.Forms.Label();
            this.labelWASD = new System.Windows.Forms.Label();
            this.labelCel = new System.Windows.Forms.Label();
            this.labelCelInf = new System.Windows.Forms.Label();
            this.MediaPlayerGame = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerGame)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExitMenu
            // 
            this.buttonExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitMenu.BackgroundImage = global::Курсо.Properties.Resources.Game;
            this.buttonExitMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExitMenu.Location = new System.Drawing.Point(690, 12);
            this.buttonExitMenu.Name = "buttonExitMenu";
            this.buttonExitMenu.Size = new System.Drawing.Size(82, 37);
            this.buttonExitMenu.TabIndex = 2;
            this.buttonExitMenu.TabStop = false;
            this.buttonExitMenu.Text = "Выйти";
            this.buttonExitMenu.UseVisualStyleBackColor = false;
            this.buttonExitMenu.Click += new System.EventHandler(this.buttonExitMenu_Click);
            // 
            // pictureBoxRocket
            // 
            this.pictureBoxRocket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRocket.Image = global::Курсо.Properties.Resources.Rocket;
            this.pictureBoxRocket.Location = new System.Drawing.Point(367, 417);
            this.pictureBoxRocket.Name = "pictureBoxRocket";
            this.pictureBoxRocket.Size = new System.Drawing.Size(45, 89);
            this.pictureBoxRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRocket.TabIndex = 4;
            this.pictureBoxRocket.TabStop = false;
            // 
            // pictureBoxMeteor
            // 
            this.pictureBoxMeteor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMeteor.Image = global::Курсо.Properties.Resources.Meteors;
            this.pictureBoxMeteor.InitialImage = null;
            this.pictureBoxMeteor.Location = new System.Drawing.Point(194, 58);
            this.pictureBoxMeteor.Name = "pictureBoxMeteor";
            this.pictureBoxMeteor.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxMeteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMeteor.TabIndex = 2;
            this.pictureBoxMeteor.TabStop = false;
            // 
            // timerDel
            // 
            this.timerDel.Interval = 1;
            this.timerDel.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerShot
            // 
            this.timerShot.Interval = 1000;
            this.timerShot.Tick += new System.EventHandler(this.timerShot_Tick);
            // 
            // timerMeteor
            // 
            this.timerMeteor.Interval = 1;
            this.timerMeteor.Tick += new System.EventHandler(this.timerMeteor_Tick);
            // 
            // labelScoreTx
            // 
            this.labelScoreTx.AutoSize = true;
            this.labelScoreTx.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreTx.ForeColor = System.Drawing.SystemColors.Info;
            this.labelScoreTx.Location = new System.Drawing.Point(699, 52);
            this.labelScoreTx.Name = "labelScoreTx";
            this.labelScoreTx.Size = new System.Drawing.Size(43, 16);
            this.labelScoreTx.TabIndex = 5;
            this.labelScoreTx.Text = "Счёт:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Info;
            this.labelScore.Location = new System.Drawing.Point(737, 52);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 16);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = ".........";
            // 
            // pictureBoxHP1
            // 
            this.pictureBoxHP1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHP1.Image = global::Курсо.Properties.Resources.heart;
            this.pictureBoxHP1.Location = new System.Drawing.Point(732, 71);
            this.pictureBoxHP1.Name = "pictureBoxHP1";
            this.pictureBoxHP1.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxHP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHP1.TabIndex = 7;
            this.pictureBoxHP1.TabStop = false;
            // 
            // pictureBoxHP3
            // 
            this.pictureBoxHP3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHP3.Image = global::Курсо.Properties.Resources.heart;
            this.pictureBoxHP3.Location = new System.Drawing.Point(732, 157);
            this.pictureBoxHP3.Name = "pictureBoxHP3";
            this.pictureBoxHP3.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxHP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHP3.TabIndex = 8;
            this.pictureBoxHP3.TabStop = false;
            // 
            // pictureBoxHP2
            // 
            this.pictureBoxHP2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHP2.Image = global::Курсо.Properties.Resources.heart;
            this.pictureBoxHP2.Location = new System.Drawing.Point(732, 114);
            this.pictureBoxHP2.Name = "pictureBoxHP2";
            this.pictureBoxHP2.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxHP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHP2.TabIndex = 9;
            this.pictureBoxHP2.TabStop = false;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.ForeColor = System.Drawing.SystemColors.Info;
            this.labelStart.Location = new System.Drawing.Point(173, 269);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(436, 31);
            this.labelStart.TabIndex = 10;
            this.labelStart.Text = "Нажмите Enter чтобы начать игру";
            // 
            // labelYprav
            // 
            this.labelYprav.AutoSize = true;
            this.labelYprav.BackColor = System.Drawing.Color.Transparent;
            this.labelYprav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYprav.ForeColor = System.Drawing.SystemColors.Info;
            this.labelYprav.Location = new System.Drawing.Point(322, 528);
            this.labelYprav.Name = "labelYprav";
            this.labelYprav.Size = new System.Drawing.Size(92, 16);
            this.labelYprav.TabIndex = 0;
            this.labelYprav.Text = "Управление:";
            // 
            // labelWASD
            // 
            this.labelWASD.AutoSize = true;
            this.labelWASD.BackColor = System.Drawing.Color.Transparent;
            this.labelWASD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWASD.ForeColor = System.Drawing.SystemColors.Info;
            this.labelWASD.Location = new System.Drawing.Point(419, 528);
            this.labelWASD.Name = "labelWASD";
            this.labelWASD.Size = new System.Drawing.Size(355, 16);
            this.labelWASD.TabIndex = 1;
            this.labelWASD.Text = "W-Верх   S-Вниз   A-Влево   D-Вправо   Space-Выстрел";
            // 
            // labelCel
            // 
            this.labelCel.AutoSize = true;
            this.labelCel.BackColor = System.Drawing.Color.Transparent;
            this.labelCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCel.ForeColor = System.Drawing.SystemColors.Info;
            this.labelCel.Location = new System.Drawing.Point(5, 528);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(77, 16);
            this.labelCel.TabIndex = 2;
            this.labelCel.Text = "Цель игры:";
            // 
            // labelCelInf
            // 
            this.labelCelInf.AutoSize = true;
            this.labelCelInf.BackColor = System.Drawing.Color.Transparent;
            this.labelCelInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCelInf.ForeColor = System.Drawing.SystemColors.Info;
            this.labelCelInf.Location = new System.Drawing.Point(88, 520);
            this.labelCelInf.Name = "labelCelInf";
            this.labelCelInf.Size = new System.Drawing.Size(211, 32);
            this.labelCelInf.TabIndex = 3;
            this.labelCelInf.Text = "Спасти планету и уничтожить \r\nкак можно больше метеоритов.";
            // 
            // MediaPlayerGame
            // 
            this.MediaPlayerGame.Enabled = true;
            this.MediaPlayerGame.Location = new System.Drawing.Point(8, 547);
            this.MediaPlayerGame.Name = "MediaPlayerGame";
            this.MediaPlayerGame.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerGame.OcxState")));
            this.MediaPlayerGame.Size = new System.Drawing.Size(14, 14);
            this.MediaPlayerGame.TabIndex = 11;
            this.MediaPlayerGame.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсо.Properties.Resources.Game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MediaPlayerGame);
            this.Controls.Add(this.labelCelInf);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelCel);
            this.Controls.Add(this.pictureBoxHP2);
            this.Controls.Add(this.labelWASD);
            this.Controls.Add(this.labelYprav);
            this.Controls.Add(this.pictureBoxHP3);
            this.Controls.Add(this.pictureBoxHP1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelScoreTx);
            this.Controls.Add(this.pictureBoxMeteor);
            this.Controls.Add(this.pictureBoxRocket);
            this.Controls.Add(this.buttonExitMenu);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExitMenu;
        private System.Windows.Forms.PictureBox pictureBoxRocket;
        private System.Windows.Forms.PictureBox pictureBoxMeteor;
        private System.Windows.Forms.Timer timerDel;
        private System.Windows.Forms.Timer timerShot;
        private System.Windows.Forms.Timer timerMeteor;
        private System.Windows.Forms.Label labelScoreTx;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxHP1;
        private System.Windows.Forms.PictureBox pictureBoxHP3;
        private System.Windows.Forms.PictureBox pictureBoxHP2;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelYprav;
        private System.Windows.Forms.Label labelWASD;
        private System.Windows.Forms.Label labelCel;
        private System.Windows.Forms.Label labelCelInf;
        public AxWMPLib.AxWindowsMediaPlayer MediaPlayerGame;
    }
}