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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Label labelpass;
        public Label labelpass2;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
            labelpass = label1;
            labelpass2 = label1;
          
        }
        // komputer
        private void button1_Click(object sender, EventArgs e)
        {
            Form win2 = new Form2();

            win2.Show();
        }
        // monitor
        private void button2_Click(object sender, EventArgs e) 
        {
            Form win3 = new Form3();
            win3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
