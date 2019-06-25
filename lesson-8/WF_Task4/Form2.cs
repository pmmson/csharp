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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string tBoxDataStr
        {
            get { return tBoxData.Text; }
        }
        public double tBoxDistDouble
        {
            get { return double.Parse(tBoxDist.Text); }
        }
        public int tBoxTimeInt
        {
            get { return int.Parse(tBoxTime.Text); }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
