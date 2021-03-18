using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace PR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №2 УРАВНЕНИЕ 11 Соколенко М.В.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y = корень(3 + lnx + 15 - x)/(1 + sin((2 + x*x)/1 +x)) ";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox2.Text += Environment.NewLine +
            "При x = " + x.ToString();
            // Вычисляем арифметическое выражение
            double y = Math.Sqrt(3+Math.Log(x)+15-x)/(1+ Math.Sin((2+ Math.Pow(x, 2))/(1+x)));

            // Выводим результат в окно
            textBox2.Text += Environment.NewLine +
            "Результат y = " + y.ToString();
        }
    }
}
