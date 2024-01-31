namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (x >= 1000000 && x <= 1999999)
            {
                double y = x * 0.005;
                MessageBox.Show(y.ToString(), "netga");
            }
            else if (x >= 2000000 && x <= 2999999)
            {
                double y = x * 0.0075;
                MessageBox.Show(y.ToString(), "netega");
            }
            else if (x >= 3000000 && x <= 9999999)
            {
                double y = x * 0.01;
                MessageBox.Show(y.ToString(), "netega");
            }
            else if (x >= 10 && x <= 249999)
            {
                MessageBox.Show("1000", "netega");
            }
            else if (x >= 250000 && x <= 499999)
            {
                MessageBox.Show("2500", "netega");
            }
            else if (x >= 500000 && x <= 999999)
            {
                MessageBox.Show("5000", "netega");
            }

        }
    }
}