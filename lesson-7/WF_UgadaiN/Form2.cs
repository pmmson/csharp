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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string tBoxF2String
        {
            get { return tBoxF2.Text; }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
