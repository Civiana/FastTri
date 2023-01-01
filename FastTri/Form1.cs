using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYY_Click(object sender, EventArgs e)
        {
            YYForm YY = new YYForm();
            YY.Show();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            DDForm DD = new DDForm();
            DD.Show();
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            NNForm NN = new NNForm();
            NN.Show();
        }

        private void btnZZ_Click(object sender, EventArgs e)
        {
            ZZForm ZZ = new ZZForm();
            ZZ.Show();
        }
    }
}
