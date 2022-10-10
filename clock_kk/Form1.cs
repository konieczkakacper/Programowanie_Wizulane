using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clock_kk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                label1.Text = DateTime.Now.ToString("HH:mm:ss");
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();
        }
    }
}