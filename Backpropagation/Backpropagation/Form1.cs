using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpropagation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int boxClick(PictureBox pb)
        {
            if (pb.BackColor == Color.Black)
            {
                pb.BackColor = Color.White;
                return -1;
            }
            else
            {
                pb.BackColor = Color.Black;
                return 1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox16);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox18);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox19);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox20);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox21);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox23);
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox24);
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox25);
        }
    }
}
