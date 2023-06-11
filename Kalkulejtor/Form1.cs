using System;
using System.Windows.Forms;

namespace Kalkulejtor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddToTextBox(Button sender)
        {
            textBox1.Text += sender.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                bSin.Hide();
                bCos.Hide();
                bLn.Hide();
                bPi.Hide();
                bSilnia.Hide();
                bE.Hide();
                bTan.Hide();
                bExp.Hide();
                bXdoy.Hide();
                bAns.Hide();
                bLog.Hide();
            }
            else
            {
                bSin.Show();
                bCos.Show();
                bLn.Show();
                bPi.Show();
                bSilnia.Show();
                bE.Show();
                bTan.Show();
                bExp.Show();
                bXdoy.Show();
                bAns.Show();
                bLog.Show();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bPerc_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bBckS_Click(object sender, EventArgs e)
        {
            // backspace
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void bDziel_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bPierwzX_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sqrt(";
        }

        private void bxkw_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b1nax_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bMn_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            // znak równoœci
            string expression = textBox1.Text;
            // Wykonaj obliczenia lub analizuj wyra¿enie i wyœwietl wynik
            double result;
            if (double.TryParse(expression, out result))
            {
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bComa_Click(object sender, EventArgs e)
        {
            // kropka/przecinek
            AddToTextBox((Button)sender);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bZmianaZnaku_Click(object sender, EventArgs e)
        {
            // zmiana znaku
            if (textBox1.Text.Length > 0 && textBox1.Text[0] != '-')
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text[0] == '-')
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
        }

        private void bSin_Click(object sender, EventArgs e)
        {
            // sinus
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Sin(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bLn_Click(object sender, EventArgs e)
        {
            // logarytm naturalny
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Log(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            // logarytm
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Log10(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            // cosinus
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Cos(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bE_Click(object sender, EventArgs e)
        {
            // e
            textBox1.Text += Math.E.ToString();
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            // pi
            textBox1.Text += Math.PI.ToString();
        }

        private void bTan_Click(object sender, EventArgs e)
        {
            // tangens
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                double result = Math.Tan(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bAns_Click(object sender, EventArgs e)
        {
            // Ans
            // ...
        }

        private void bExp_Click(object sender, EventArgs e)
        {
            // Exp
            // ...
        }

        private void bXdoy_Click(object sender, EventArgs e)
        {
            // x do potêgi y
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                double result = Math.Pow(x, y);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private void bSilnia_Click(object sender, EventArgs e)
        {
            // silnia
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                int result = CalculateFactorial(value);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("B³¹d w wyra¿eniu!");
            }
        }

        private int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }

        private void blewy_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }

        private void bprawy_Click(object sender, EventArgs e)
        {
            AddToTextBox((Button)sender);
        }
    }
}
