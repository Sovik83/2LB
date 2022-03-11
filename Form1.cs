namespace _2LB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "4000";
            textBox2.Text = "-0,875";
            textBox3.Text = "-0,000475";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double w = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Sin(y) * Math.Sin(y)) * (1 + z + z * z / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);
            textBox4.Text += Environment.NewLine + "Результат W = " + w.ToString();
        }
    }
}