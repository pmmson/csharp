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

        private void BtnClick_Click(object sender, EventArgs e)
        {
            int userN;
            bool flag;

            flag = int.TryParse(tBoxEnter.Text, out userN);
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
                    lblInfoOut.Text = "Поздравляю! Вы угадали!";
                    lblInfoOut.Left = this.ClientSize.Width / 2 - lblInfoOut.Width / 2;
                }
            }



            // MessageBox.Show($"{n} {userN}"); // для отладки
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            lblInfoOut.Text = "";
            tBoxEnter.Text = "";
            n = r.Next(1, 100);
            lblInfo.Visible = true;
            tBoxEnter.Visible = true;
            btnClick.Visible = true;
            lblInfoOut.Visible = true;
        }

        private void TBoxEnter_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoOut.Text = "";
        }
    }
}
