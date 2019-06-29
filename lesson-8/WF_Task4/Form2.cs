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
            get { return (tBoxDist.Text != "") ? double.Parse(tBoxDist.Text) : 0; }
        }
        public int tBoxTimeInt
        {
            get { return (tBoxTime.Text != "") ? int.Parse(tBoxTime.Text) : 0; }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
