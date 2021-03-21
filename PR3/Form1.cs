using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//выражение 16
namespace PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox1.Text);
            textBox4.Text = "Результаты работы программы ст. Соколенко М.В. " + Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;

            double value = 1;
            double u=1;
            int n = 0;
            //checked - включено.
            if (checkBox1.Checked)
            {
                n = 4;
                if (radioButton1.Checked) n = 0;
                else if (radioButton2.Checked) n = 1;
                else if (radioButton3.Checked) n = 2;
                // double u;
                switch (n)
                {
                    case 0:
                        value = Math.Sinh(x);
                        break;
                    case 1:
                        value = Math.Cosh(x);
                        break;
                    case 2:
                        value = Math.Exp(x);
                        break;
                    default:
                        textBox4.Text += "Решение не найдено" + Environment.NewLine;
                        break;

                }
            }
            else
            {
                value = x;
            }

            if (x > 2) 
            {
                u = Math.Log(value); 
            }
            else if ((-3 < x) && (x <= 2))
            {
                u = 3 * value - 2;
            }
             else if (x <= -3)
            {
                u = 2 + Math.Abs(value);
            }
            if( n!= 4)
            {
                textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Включено f(x)";
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
            }
            else
            {
                checkBox1.Text = "Отключено f(x)";
                groupBox1.Enabled = false;
                groupBox1.Visible = false;
            }
        }
    }
}
