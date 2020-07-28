using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Spacebar_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer1.Interval = 500;
            }
            else if(radioButton2.Checked)
            {
                timer1.Interval = 100;
            }
            else if (radioButton3.Checked)
            {
                timer1.Interval = 50;
            }
            else if (radioButton4.Checked)
            {
                timer1.Interval = 10;
            }
            SendKeys.Send(" ");
        }              

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                panel1.BringToFront();
            }
            else
            {
                timer1.Stop();
                panel2.BringToFront();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            string word = richTextBox1.Text;
            foreach(char chr in word)
            {
                Thread.Sleep(Convert.ToInt32(numericUpDown1.Value)*2);
                try
                {
                    SendKeys.Send(chr.ToString());
                }
                catch
                {
                }
            }
        }
    }
}
