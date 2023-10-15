namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int calc = 0;
                if (textBox1.Text.Contains("+"))
                {
                    calc = textBox1.Text.IndexOf("+");
                }
                else if (textBox1.Text.Contains("-"))
                {
                    calc = textBox1.Text.IndexOf("-");
                }
                else if (textBox1.Text.Contains("*"))
                {
                    calc = textBox1.Text.IndexOf("*");
                }
                else if (textBox1.Text.Contains("/"))
                {
                    calc = textBox1.Text.IndexOf("/");
                }
                string x = textBox1.Text.Substring(calc, 1);
                double x1 = Convert.ToDouble(textBox1.Text.Substring(0, calc));
                double x2 = Convert.ToDouble(textBox1.Text.Substring(calc + 1, textBox1.Text.Length - calc - 1));
                if (x == "+")
                {
                    History.Items.Add(textBox1.Text + " = " + (x1 + x2));
                    textBox1.Text = (x1 + x2).ToString();
                }
                else if (x == "-")
                {
                    History.Items.Add(textBox1.Text + " = " + (x1 - x2));
                    textBox1.Text = (x1 - x2).ToString();
                }
                else if (x == "*")
                {
                    History.Items.Add(textBox1.Text + " = " + (x1 * x2));
                    textBox1.Text = (x1 * x2).ToString();
                }
                else if (x == "/")
                {
                    if (x2 == 0)
                    {
                        textBox1.Text = "Error: Division by zero";
                    }
                    else
                    {
                        History.Items.Add(textBox1.Text + " = " + (x1 / x2));
                        textBox1.Text = (x1 / x2).ToString();
                    }
                }
            }
            catch (FormatException)
            {
                textBox1.Text = "Error: Invalid Input";
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }
    }
}