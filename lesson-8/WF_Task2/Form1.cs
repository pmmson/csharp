using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NUD1_ValueChanged(object sender, EventArgs e)
        {
            tBox1.Text = nUD1.Value.ToString();
        }
    }
}
