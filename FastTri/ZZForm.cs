using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FastTri
{
    
    public partial class ZZForm : Form
    {
        private SoundPlayer _soundplayer;
        public ZZForm()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer("ZZ.wav");
        }

        private void ZZForm_Load(object sender, EventArgs e)
        {
          pictureBox1.Image = Image.FromFile("ZZ.png");
          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                pictureBox1.Image = Image.FromFile("ZZ.gif");
                _soundplayer.Play();
            }
            else
            {
                checkBox1.Text = "Socialize";
                pictureBox1.Image = Image.FromFile("ZZ.png");
                _soundplayer.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
