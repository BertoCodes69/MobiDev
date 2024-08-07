using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;
            var result = new DataTable().Compute(equation, null);
            textBox1.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}