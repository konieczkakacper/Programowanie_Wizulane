using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kklb2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int opt; // DYSK
        int ch1, ch2, ch3; 
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
            {
                opt = 22;
                label1.Text = (opt).ToString();
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                opt =32;
                label1.Text = (opt).ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                opt = 2;
                label1.Text = (opt).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true)
            {
                ch1 = 10;
                label1.Text = (opt + ch1).ToString();
            }
            else
            {
                ch1 = 0;
                label1.Text = (opt + ch1 + ch2 + ch3).ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                ch2 = 40;
                label1.Text = (opt + ch1 + ch2).ToString();
            }
            else
            {
                ch2 = 0;
                label1.Text = (opt + ch1 + ch2 + ch3).ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                ch3 = 300;
                label1.Text = (opt + ch1 + ch2 + ch3).ToString();
            }
            else
            {
                ch3 = 0;
                label1.Text = (opt + ch1 + ch2 + ch3).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
