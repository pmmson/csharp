using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_UgadaiN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int n;
        string userNumber;

        void MainUgadai()
        {
            bool flag;

            flag = int.TryParse(userNumber, out int userN);
            if (!flag)
            {
                lblInfoOut.Text = "Вы не ввели число или введенное число некорректно";
                lblInfoOut.Left = this.ClientSize.Width / 2 - lblInfoOut.Width / 2;
            }
            else
            {
                if (userN > n)
                {
                    lblInfoOut.Text = "Ваше число больше загаданного";
                    lblInfoOut.Left = this.ClientSize.Width / 2 - lblInfoOut.Width / 2;
                }
                else if (userN < n)
                {
                    lblInfoOut.Text = "Ваше число меньше загаданного";
                    lblInfoOut.Left = this.ClientSize.Width / 2 - lblInfoOut.Width / 2;
                }
                else
                {
                    tBoxEnter.Visible = false;
                    btnOneTime.Visible = false;
                    btnClick.Visible = false;
                    lblInfoOut.Text = "Поздравляю! Вы угадали!";
                    lblInfoOut.Left = this.ClientSize.Width / 2 - lblInfoOut.Width / 2;
                }
            }
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            userNumber = tBoxEnter.Text;
            MainUgadai();
            
            // MessageBox.Show($"{n} {userN}"); // для отладки
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            lblInfoOut.Text = "";
            tBoxEnter.Text = "";
            n = r.Next(1, 100);
            btnOneTime.Visible = false;
            lblInfo.Visible = true;
            tBoxEnter.Visible = true;
            btnClick.Visible = true;
            lblInfoOut.Visible = true;
        }

        private void TBoxEnter_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoOut.Text = "";
        }

        private void BtnNewGame2_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            tBoxEnter.Visible = false;
            btnClick.Visible = false;
            btnOneTime.Visible = false;
            lblInfoOut.Text = "";
            n = r.Next(1, 100);
            Form2 open = new Form2();
            open.ShowDialog();
            userNumber = open.tBoxF2String;
            MainUgadai();
            lblInfoOut.Visible = true;
            btnOneTime.Visible = true;
        }

        private void BtnOneTime_Click(object sender, EventArgs e)
        {
            lblInfoOut.Text = "";
            Form2 open = new Form2();
            open.ShowDialog();
            userNumber = open.tBoxF2String;
            MainUgadai();
            lblInfoOut.Visible = true;
        }
    }
}
