using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            get { Regex reg = new Regex(@"\d\d\.\d\d\.\d{4}"); return reg.IsMatch(tBoxData.Text) ? tBoxData.Text : ""; }
        }
        public double tBoxDistDouble
        {
            get { Regex reg = new Regex(@"\d"); return reg.IsMatch(tBoxDist.Text.Replace('.',',')) ? double.Parse(tBoxDist.Text.Replace('.',',')) : 0; }
        }
        public double tBoxTimeInt
        {
            get { Regex reg = new Regex(@"\d"); return reg.IsMatch(tBoxTime.Text.Replace('.', ',')) ? double.Parse(tBoxTime.Text.Replace('.', ',')) : 0; }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
