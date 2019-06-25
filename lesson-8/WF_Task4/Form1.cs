using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Task4
{
    public partial class Form1 : Form
    {
        WorkOut db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                db = new WorkOut(sfd.FileName);
                db.Add("01.01.0001", 0.0, 0);
                db.Save();
            }
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (db != null) db.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                db = new WorkOut(ofd.FileName);
                db.Load();
                db.FillListView(this.listBox);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new WorkOut();
            db.FillListView(this.listBox);
        }
    }
}
