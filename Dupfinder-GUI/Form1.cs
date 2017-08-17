using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dupfinder_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioBlacklist_CheckedChanged(object sender, EventArgs e)
        {


            if (radioBlacklist.Checked)
            {
                radioWhitelist.Checked = false;
            }


        }

        private void radioWhitelist_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhitelist.Checked)
            {
                radioBlacklist.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();

        }
    }
}
