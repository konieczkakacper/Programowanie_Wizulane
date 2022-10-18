using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kklb2
{
    public partial class Form3 : Form
    {
        public static Form3 inst;
        public class CBRefresh
        {
            private readonly string name;
            public string Name
            {
                get { return this.name; }
            }

            private readonly decimal price;
            public decimal Price
            {
                get { return this.price; }
            }
            public CBRefresh(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }

            public override string ToString()
            {
                return this.name;
            }
        }

        public class CBsize
        {
            private readonly string name;
            public string Name
            {
                get { return this.name; }
            }

            private readonly decimal price;
            public decimal Price
            {
                get { return this.price; }
            }
            public CBsize(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
        public Form3()
        {
            InitializeComponent();
            inst = this; 
            comboBox1.Items.Add(new CBRefresh("60 hz", 100.00m));
            comboBox1.Items.Add(new CBRefresh("120 hz", 200.00m));

            comboBox2.Items.Add(new CBsize("27\"", 400.00m));
            comboBox2.Items.Add(new CBsize("24\"", 300.00m));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBRefresh selectedItem = (CBRefresh)comboBox1.SelectedItem;
            label1.Text = selectedItem.Price.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBsize selectedItem = (CBsize)comboBox2.SelectedItem;
            label2.Text = selectedItem.Price.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
    
        }
        private void button1_Click(object sender, EventArgs e) //potwierdz
        {
            // Form1.instance.labelpass2.Text = ; 
        }
    }
}
