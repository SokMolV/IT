using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// задача 8 и 16

namespace PR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n = Convert.ToDouble(textBox1.Text); 
            Double eps = Convert.ToDouble(textBox1.Text); 
            textBox2.Text = "Результаты работы программы ст. Соколенко М.В. " + Environment.NewLine; 
            int m = 0;
            double factorial = 1;
            double i = 1;
            for (int x = 1; x <= i; x++)
            {
                factorial = factorial * x;

            }
            if (radioButton2.Checked)
                m = 1;

            double s = 0, p = 1;
            double ch=1; 
            
            switch (m)
            {
                case 0:
                    i = 2;
                    ch = 1 / i; 
                    while (ch >= eps) 
                    {

                        factorial = 1;
                        for (int x = 1; x <= i; x++)
                        {
                            factorial = factorial * x;

                        }
                        ch = (i-1)/(2* factorial - 2);
                        //ch = (i  / (2 * factorial - 2);
                        //ch = (3 * factorial - 1) / (i + 1);
                        s += ch; 
                      i++; }
                   // s = factorial;
                    textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine; 
                    textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
                    break;
                case 1:
                    for (i = 1; i <= n; i++) 
                    {
                        factorial = 1;
                        for (int x = 1; x <= i; x++)
                        {
                            factorial = factorial * x;

                        }
                        ch = Math.Sqrt(factorial +10*i)/(3*i-2); 
                      p *= ch; 
                    }
                    textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine; 
                    textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine; 
                    break;
            }
        }
    }
}
