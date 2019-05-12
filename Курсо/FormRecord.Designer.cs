namespace Курсо
{
    partial class FormRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecord));
            this.buttonExitMenu = new System.Windows.Forms.Button();
            this.DataGridViewRecord = new System.Windows.Forms.DataGridView();
            this.НомерИгрока = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИмяИгрока = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счёт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaPlayerRecord = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExitMenu
            // 
            this.buttonExitMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExitMenu.BackgroundImage = global::Курсо.Properties.Resources.Rec;
            this.buttonExitMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitMenu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExitMenu.Location = new System.Drawing.Point(12, 514);
            this.buttonExitMenu.Name = "buttonExitMenu";
            this.buttonExitMenu.Size = new System.Drawing.Size(123, 35);
            this.buttonExitMenu.TabIndex = 4;
            this.buttonExitMenu.Text = "Выйти";
            this.buttonExitMenu.UseVisualStyleBackColor = false;
            this.buttonExitMenu.Click += new System.EventHandler(this.buttonExitMenu_Click);
            // 
            // DataGridViewRecord
            // 
            this.DataGridViewRecord.AllowUserToAddRows = false;
            this.DataGridViewRecord.AllowUserToDeleteRows = false;
            this.DataGridViewRecord.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.НомерИгрока,
            this.ИмяИгрока,
            this.Счёт});
            this.DataGridViewRecord.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewRecord.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewRecord.Name = "DataGridViewRecord";
            this.DataGridViewRecord.ReadOnly = true;
            this.DataGridViewRecord.RowHeadersVisible = false;
            this.DataGridViewRecord.Size = new System.Drawing.Size(343, 496);
            this.DataGridViewRecord.TabIndex = 15;
            // 
            // НомерИгрока
            // 
            this.НомерИгрока.HeaderText = "Номер Игрока";
            this.НомерИгрока.Name = "НомерИгрока";
            this.НомерИгрока.ReadOnly = true;
            this.НомерИгрока.Width = 50;
            // 
            // ИмяИгрока
            // 
            this.ИмяИгрока.HeaderText = "Имя Игрока";
            this.ИмяИгрока.Name = "ИмяИгрока";
            this.ИмяИгрока.ReadOnly = true;
            this.ИмяИгрока.Width = 170;
            // 
            // Счёт
            // 
            this.Счёт.HeaderText = "Счёт";
            this.Счёт.Name = "Счёт";
            this.Счёт.ReadOnly = true;
            this.Счёт.Width = 120;
            // 
            // MediaPlayerRecord
            // 
            this.MediaPlayerRecord.Enabled = true;
            this.MediaPlayerRecord.Location = new System.Drawing.Point(697, 526);
            this.MediaPlayerRecord.Name = "MediaPlayerRecord";
            this.MediaPlayerRecord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerRecord.OcxState")));
            this.MediaPlayerRecord.Size = new System.Drawing.Size(75, 23);
            this.MediaPlayerRecord.TabIndex = 16;
            this.MediaPlayerRecord.Visible = false;
            // 
            // FormRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсо.Properties.Resources.Rec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MediaPlayerRecord);
            this.Controls.Add(this.DataGridViewRecord);
            this.Controls.Add(this.buttonExitMenu);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(667, 594);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рекорды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRecord_FormClosed);
            this.Load += new System.EventHandler(this.FormRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitMenu;
        private System.Windows.Forms.DataGridView DataGridViewRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерИгрока;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИмяИгрока;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счёт;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerRecord;
    }
}