using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lions_Click(object sender, EventArgs e)
        {
            new LionsForm().ShowDialog();
        }

        private void btn_tigers_Click(object sender, EventArgs e)
        {
            new TigersForm().ShowDialog();
        }

        private void btn_Dolphins_Click(object sender, EventArgs e)
        {
            new DolphinsForm().ShowDialog();
        }

        private void btn_Clownfish_Click(object sender, EventArgs e)
        {
            new ClownFishForm().ShowDialog();
        }

        private void btn_Parrots_Click(object sender, EventArgs e)
        {
            new ParrotsForm().ShowDialog();
        }

        private void btn_eagles_Click(object sender, EventArgs e)
        {
            new EaglesForm().ShowDialog();
        }
    }
}
