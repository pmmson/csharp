﻿/*
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

        Random r = new Random();
        Stack<string> steps = new Stack<string>();

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            steps.Push(lblNumber.Text); // помещаем в стек команду
            clickCounter.Text = (int.Parse(clickCounter.Text) + 1).ToString();
        }

        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            steps.Push(lblNumber.Text); // помещаем в стек команду
            clickCounter.Text = (int.Parse(clickCounter.Text) + 1).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            steps.Clear();
            clickCounter.Text = "0";
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = r.Next(100);
            lblR.Text = $"Получите число {n} за минимальное кол-во ходов";
            MessageBox.Show($"Необходимо получить число {n} за минимальное число ходов!");
            lblName2.Visible = true;
            lblNumber.Visible = true;
            lblR.Visible = true;
            lblInfo.Visible = true;
            clickCounter.Visible = true;
            btnCommand1.Visible = true;
            btnCommand2.Visible = true;
            btnCancel.Visible = true;
            btnReset.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (steps.Count == 0)
            {
                MessageBox.Show("У вас нет ходов для отмены");
            }
            else
            {
                steps.Pop();
                if (steps.Count == 0)
                {
                    lblNumber.Text = "0";
                    clickCounter.Text = "0";
                }
                else
                {
                    lblNumber.Text = steps.Peek();
                    clickCounter.Text = (int.Parse(clickCounter.Text) - 1).ToString();
                }
            }
        }
    }
}
