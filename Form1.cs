
// 1. По указанию преподавателя выберите индивидуальное задание
// из нижеприведенного списка. В качестве f(x) использовать по выбору: x^2, e^x.
// Отредактируйте вид формы и текст программы, в соответствии с полученным заданием. 

using System;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                textBox4.Text += "При X = " + textBox1.Text +
                        Environment.NewLine;
                textBox4.Text += "При Y = " + textBox2.Text +
                        Environment.NewLine;
                double u;
                int n = 0;
                if (radioButton2.Checked)
                    n = 1;
                else if (radioButton3.Checked)
                    n = 2;
                switch (n)
                {
                    case 1:
                        if (x * y > 0)
                            u = Math.Pow((Math.Pow(x, 2) + y), 2) - Math.Sqrt((Math.Pow(x, 2) * y));
                        else
                        if (x * y < 0)
                            u = Math.Pow((Math.Pow(x, 2) + y), 2) + Math.Sqrt(Math.Abs((Math.Pow(x, 2) * y)));
                        else
                            u = Math.Pow((Math.Pow(x, 2) + y), 2) + 1;
                        textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
                        break;
                    case 2:
                        if (x * y > 0)
                            u = Math.Pow((Math.Exp(x) + y), 2) - Math.Sqrt((Math.Exp(x) * y));
                        else
                        if (x * y < 0)
                            u = Math.Pow((Math.Exp(x) + y), 2) + Math.Sqrt(Math.Abs((Math.Exp(x) * y)));
                        else
                            u = Math.Pow((Math.Exp(x) + y), 2) + 1;
                        textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
                        break;
                    default:
                        textBox4.Text += "Error" + Environment.NewLine;
                        break;
                }
            }

            catch 
            {
                textBox4.Text = "Ошибка. Введите числа ещё раз!";
            }

         }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
