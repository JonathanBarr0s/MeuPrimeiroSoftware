namespace App001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textBox1.Text);

            num2 = Convert.ToDouble(textBox2.Text);

            resultado = num1 + num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textBox1.Text);

            num2 = Convert.ToDouble(textBox2.Text);

            resultado = num1 - num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textBox1.Text);

            num2 = Convert.ToDouble(textBox2.Text);

            resultado = num1 * num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textBox1.Text);

            num2 = Convert.ToDouble(textBox2.Text);

            resultado = num1 / num2;

            if(num2 == 0)
            {
                label4.Text = "Não é possível dividir por zero.";
            }

            else
            {
                label4.Text = label4.Text = Convert.ToString(resultado);
            }
        }
    }
}