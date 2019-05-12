using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Курсо
{
    public partial class FormMenu : Form
    {     
        public FormMenu()
        {
            InitializeComponent();        
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            MediaPlayerMenu.URL = "Меню.wav";
        }
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            MediaPlayerMenu.Ctlcontrols.stop();
            FormGame formGame= new FormGame();
            formGame.Show();
            this.Hide();  
        }
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            MediaPlayerMenu.Ctlcontrols.stop();
            FormRecord formRecord = new FormRecord();
            formRecord.Show();
            this.Hide();   
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?",
                                             "Выход из программы",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Close(); }
            else
            { return; }
            Application.Exit();
        }
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
