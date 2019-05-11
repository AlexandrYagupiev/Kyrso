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

namespace Курсо
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {  
            InitializeComponent();
        }

        private void buttonExitMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void FormRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            string[] data =new string [20];
            StreamReader reader = new StreamReader("Record.txt");
            data = reader.ReadToEnd().Split(';');
            for(int i=0;i<data.Length-1;i++)
            {
                string[] stroka = data[i].Split();
                DataGridViewRecord.Rows.Add(0,stroka[0],int.Parse(stroka[1]));
            }
            DataGridViewRecord.Sort(DataGridViewRecord.Columns[2], ListSortDirection.Descending);
            for(int j=0;j< DataGridViewRecord.RowCount;j++)
            {
                DataGridViewRecord.Rows[j].Cells[0].Value = j+1;
            }
            reader.Close();
        }

        private void Record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
