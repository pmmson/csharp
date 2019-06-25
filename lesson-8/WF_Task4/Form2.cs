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
        WorkOut db;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            db = new WorkOut();
            db.Add(tBoxData.Text.ToString(), double.Parse(tBoxDist.Text), int.Parse(tBoxTime.Text));
            Close();
        }
    }
}
