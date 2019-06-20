/*
 * Павленко Михаил
 * 
 * 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 *    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
 *       Игрок должен получить это число за минимальное количество ходов. 
 *    в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
 *    Вся логика игры должна быть реализована в классе с удвоителем.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            clickCounter.Text = (int.Parse(clickCounter.Text) + 1).ToString();
        }

        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            clickCounter.Text = (int.Parse(clickCounter.Text) + 1).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            clickCounter.Text = (int.Parse(clickCounter.Text) + 1).ToString();
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show($"Необходимо получить число {r.Next(100)} за минимальное число ходов!");
        }
    }
}
