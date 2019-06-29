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
        WorkOut db = new WorkOut();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка Выход панели Меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Кнопка Новый панели Меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                db = new WorkOut();
                listBox.Items.Clear();
                db.Add("01.01.0001", 0, 0);
                db.Save(sfd.FileName);
                db.FileName = sfd.FileName;
                db.FillListView(listBox);
            }

        }
        /// <summary>
        /// Кнопка Сохранить панели Меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (db.Count != 0)
            {
                db.Save(db.FileName);
            }
            else MessageBox.Show("База данных не создана или не открыта");
        }
        /// <summary>
        /// Кнопка Открыть панели Меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                db.FileName = ofd.FileName;
                db.Load(ofd.FileName);
                listBox.Items.Clear();
                db.FillListView(listBox);
            }
        }
        /// <summary>
        /// Кнопка Добавить Главного окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (db.Count != 0)
            {
                Form2 f = new Form2();
                f.ShowDialog();
                if (f.tBoxDataStr != "" || f.tBoxDistDouble != 0 || f.tBoxTimeInt != 0)
                {
                    db.Add(f.tBoxDataStr, f.tBoxDistDouble, f.tBoxTimeInt);
                    db.FillListViewItem(listBox);
                }
            }
            else MessageBox.Show("База данных не создана или не открыта");
        }
        /// <summary>
        /// Кнопка Сохранить Главного окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (db.Count != 0)
            {
                db.Save(db.FileName);
            }
            else MessageBox.Show("База данных не создана или не открыта");
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (db.Count != 0)
            {
                db.Remove(listBox.SelectedIndex);
                listBox.Items.Clear();
                db.FillListView(listBox);
            }
            else MessageBox.Show("База данных не создана или не открыта");
        }
    }
}
