using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitomezashi_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            var rand = new Random();
            double on_Prob = Convert.ToDouble(textBox3.Text);
            double off_Prob = Convert.ToDouble(textBox4.Text);
            Graphics g = e.Graphics;

            for (int j = 0; j < 500; j = j + 10)
            {
                double x = rand.Next(100);
                if (x < on_Prob*100)
                {
                    for (int i = 0; i < 500; i = i + 20)
                    {
                        g.DrawLine(System.Drawing.Pens.Black, i, j, i + 10, j);
                    }
                }
                else
                {
                    for (int i = 10; i < 500; i = i + 20)
                    {
                        g.DrawLine(System.Drawing.Pens.Black, i, j, i + 10, j);
                    }
                }
            }
            for (int i = 0; i < 500; i = i + 10)
            {
                int x = rand.Next(100);
                if (x < on_Prob*100)
                {
                    for (int j = 0; j < 500; j = j + 20)
                    {
                        g.DrawLine(System.Drawing.Pens.Black, i, j, i, j + 10);
                    }
                }
                else
                {
                    for (int j = 10; j < 500; j = j + 20)
                    {
                        g.DrawLine(System.Drawing.Pens.Black, i, j, i, j + 10);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            double y = 1 - Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(y);
        }
    }
}