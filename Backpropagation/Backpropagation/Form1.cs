using Backprop;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Backpropagation
{
    public partial class Form1 : Form
    {
        private NeuralNet nn;
        private List<int> inputData = new List<int>(new int[25]);
        Color fill = Color.FromArgb(0, 34, 56);
        private int binaryEquivalent = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(25, 5, 5);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
            int noOfEpoch = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < noOfEpoch; i++) 
            {
                // +
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 1);
                nn.setInputs(3, 0);
                nn.setInputs(4, 0);
                nn.setInputs(5, 0);
                nn.setInputs(6, 0);
                nn.setInputs(7, 1);
                nn.setInputs(8, 0);
                nn.setInputs(9,  0);
                nn.setInputs(10, 1);
                nn.setInputs(11, 1);
                nn.setInputs(12, 1);
                nn.setInputs(13, 1);
                nn.setInputs(14, 1);
                nn.setInputs(15, 0);
                nn.setInputs(16, 0);
                nn.setInputs(17, 1);
                nn.setInputs(18, 0);
                nn.setInputs(19, 0);
                nn.setInputs(20, 0);
                nn.setInputs(21, 0);
                nn.setInputs(22, 1);
                nn.setInputs(23, 0);
                nn.setInputs(24, 0);

                // 0 0 0 0
                nn.setDesiredOutput(0, 0);
                nn.setDesiredOutput(1, 0);
                nn.setDesiredOutput(2, 0);
                nn.setDesiredOutput(3, 0);
                nn.setDesiredOutput(4, 0);
                nn.learn();

                // -
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setInputs(4, 0);
                nn.setInputs(5, 0);
                nn.setInputs(6, 0);
                nn.setInputs(7, 0);
                nn.setInputs(8, 0);
                nn.setInputs(9, 0);
                nn.setInputs(10, 1);
                nn.setInputs(11, 1);
                nn.setInputs(12, 1);
                nn.setInputs(13, 1);
                nn.setInputs(14, 1);
                nn.setInputs(15, 0);
                nn.setInputs(16, 0);
                nn.setInputs(17, 0);
                nn.setInputs(18, 0);
                nn.setInputs(19, 0);
                nn.setInputs(20, 0);
                nn.setInputs(21, 0);
                nn.setInputs(22, 0);
                nn.setInputs(23, 0);
                nn.setInputs(24, 0);

                // 0 0 0 1
                nn.setDesiredOutput(0, 0);
                nn.setDesiredOutput(1, 0);
                nn.setDesiredOutput(2, 0);
                nn.setDesiredOutput(3, 0);
                nn.setDesiredOutput(4, 1);
                nn.learn();

                // /
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setInputs(4, 1);
                nn.setInputs(5, 0);
                nn.setInputs(6, 0);
                nn.setInputs(7, 0);
                nn.setInputs(8, 1);
                nn.setInputs(9, 0);
                nn.setInputs(10, 0);
                nn.setInputs(11, 0);
                nn.setInputs(12, 1);
                nn.setInputs(13, 0);
                nn.setInputs(14, 0);
                nn.setInputs(15, 0);
                nn.setInputs(16, 1);
                nn.setInputs(17, 0);
                nn.setInputs(18, 0);
                nn.setInputs(19, 0);
                nn.setInputs(20, 1);
                nn.setInputs(21, 0);
                nn.setInputs(22, 0);
                nn.setInputs(23, 0);
                nn.setInputs(24, 0);

                // 0 0 0 1 0 
                nn.setDesiredOutput(0, 0);
                nn.setDesiredOutput(1, 0);
                nn.setDesiredOutput(2, 0);
                nn.setDesiredOutput(3, 1);
                nn.setDesiredOutput(4, 0);
                nn.learn();

                // x
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setInputs(4, 1);
                nn.setInputs(5, 0);
                nn.setInputs(6, 1);
                nn.setInputs(7, 0);
                nn.setInputs(8, 1);
                nn.setInputs(9, 0);
                nn.setInputs(10, 0);
                nn.setInputs(11, 0);
                nn.setInputs(12, 1);
                nn.setInputs(13, 0);
                nn.setInputs(14, 0);
                nn.setInputs(15, 0);
                nn.setInputs(16, 1);
                nn.setInputs(17, 0);
                nn.setInputs(18, 1);
                nn.setInputs(19, 0);
                nn.setInputs(20, 1);
                nn.setInputs(21, 0);
                nn.setInputs(22, 0);
                nn.setInputs(23, 0);
                nn.setInputs(24, 1);

                // 0 0 0 1 1 
                nn.setDesiredOutput(0, 0);
                nn.setDesiredOutput(1, 0);
                nn.setDesiredOutput(2, 0);
                nn.setDesiredOutput(3, 1);
                nn.setDesiredOutput(4, 1);
                nn.learn();
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetData();
            // get input data from the UI
            for (int i = 0; i < inputData.Count(); i++)
            {
                nn.setInputs(i, inputData[i]);
            }

            nn.run();

            label2.Text = "Weight #1: " + Math.Round(nn.getOuputData(0), 6);
            label3.Text = "Weight #2: " + Math.Round(nn.getOuputData(1), 6);
            label4.Text = "Weight #3: " + Math.Round(nn.getOuputData(2), 6);
            label5.Text = "Weight #4: " + Math.Round(nn.getOuputData(3), 6);
            label6.Text = "Weight #5: " + Math.Round(nn.getOuputData(4), 6);

            resetDisplay();
            Classification();
        }

        public void boxClick(PictureBox pb)
        {
            if (pb.BackColor == fill)
            {
                pb.BackColor = Color.White;
            }
            else
            {
                pb.BackColor = fill;
            }
        }

        public void resetDisplay()
        {
            outputBox1.BackColor = Color.White;
            outputBox2.BackColor = Color.White;
            outputBox3.BackColor = Color.White;
            outputBox4.BackColor = Color.White;
            outputBox5.BackColor = Color.White;
            outputBox6.BackColor = Color.White;
            outputBox7.BackColor = Color.White;
            outputBox8.BackColor = Color.White;
            outputBox9.BackColor = Color.White;
            outputBox10.BackColor = Color.White;
            outputBox11.BackColor = Color.White;
            outputBox12.BackColor = Color.White;
            outputBox13.BackColor = Color.White;
            outputBox14.BackColor = Color.White;
            outputBox15.BackColor = Color.White;
            outputBox16.BackColor = Color.White;
            outputBox17.BackColor = Color.White;
            outputBox18.BackColor = Color.White;
            outputBox19.BackColor = Color.White;
            outputBox20.BackColor = Color.White;
            outputBox21.BackColor = Color.White;
            outputBox22.BackColor = Color.White;
            outputBox23.BackColor = Color.White;
            outputBox24.BackColor = Color.White;
            outputBox25.BackColor = Color.White;
        }

        private int Identifier(PictureBox pb)
        {
            if (pb.BackColor == fill)
            {
                return 1;
            }
            return 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            boxClick(pictureBox1);
        }

        private int Threshold(double output)
        {
            if (output >= 0.5)
            {
                return 1;
            }
            return 0;
        }

        private void GetData()
        {
            inputData.Clear();
            inputData.Add(Identifier(pictureBox1));
            inputData.Add(Identifier(pictureBox2));
            inputData.Add(Identifier(pictureBox3));
            inputData.Add(Identifier(pictureBox4));
            inputData.Add(Identifier(pictureBox5));
            inputData.Add(Identifier(pictureBox6));
            inputData.Add(Identifier(pictureBox7));
            inputData.Add(Identifier(pictureBox8));
            inputData.Add(Identifier(pictureBox9));
            inputData.Add(Identifier(pictureBox10));
            inputData.Add(Identifier(pictureBox11));
            inputData.Add(Identifier(pictureBox12));
            inputData.Add(Identifier(pictureBox13));
            inputData.Add(Identifier(pictureBox14));
            inputData.Add(Identifier(pictureBox15));
            inputData.Add(Identifier(pictureBox16));
            inputData.Add(Identifier(pictureBox17));
            inputData.Add(Identifier(pictureBox18));
            inputData.Add(Identifier(pictureBox19));
            inputData.Add(Identifier(pictureBox20));
            inputData.Add(Identifier(pictureBox21));
            inputData.Add(Identifier(pictureBox22));
            inputData.Add(Identifier(pictureBox23));
            inputData.Add(Identifier(pictureBox24));
            inputData.Add(Identifier(pictureBox25));
        }
        private void Classification()
        {
            binaryEquivalent = 0;
            binaryEquivalent += 10000 * Threshold(nn.getOuputData(0));
            binaryEquivalent += 1000 * Threshold(nn.getOuputData(1));
            binaryEquivalent += 100 * Threshold(nn.getOuputData(2));
            binaryEquivalent += 10 * Threshold(nn.getOuputData(3));
            binaryEquivalent += 1 * Threshold(nn.getOuputData(4));

            switch (binaryEquivalent)
            {
                case 0:
                    boxClick(outputBox3);
                    boxClick(outputBox8);
                    boxClick(outputBox11);
                    boxClick(outputBox12);
                    boxClick(outputBox13);
                    boxClick(outputBox14);
                    boxClick(outputBox15);
                    boxClick(outputBox18);
                    boxClick(outputBox23);
                    break;
                case 1:
                    boxClick(outputBox11);
                    boxClick(outputBox12);
                    boxClick(outputBox13);
                    boxClick(outputBox14);
                    boxClick(outputBox15);
                    break;
                case 10:
                    boxClick(outputBox5);
                    boxClick(outputBox9);
                    boxClick(outputBox13);
                    boxClick(outputBox17);
                    boxClick(outputBox21);
                    break;
                case 11:
                    boxClick(outputBox1);
                    boxClick(outputBox5);
                    boxClick(outputBox7);
                    boxClick(outputBox9);
                    boxClick(outputBox13);
                    boxClick(outputBox17);
                    boxClick(outputBox19);
                    boxClick(outputBox21);
                    boxClick(outputBox25);
                    break;
                default:
                    break;
            }
        } 
    }
}
