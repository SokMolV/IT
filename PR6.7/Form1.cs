using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Указать номера элементов массива, которые больше "2", но меньше "5". 6 практика

namespace PR6._7
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                Mas[i] = rand.Next(-10, 10);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                    + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] fmas = new int[15];
            textBox2.Text = "";
            for (int i = 0; i < 15; i++)
            {
                if ((Mas[i] > 2) && (Mas[i] < 5))
                {
                    textBox2.Text += Convert.ToString(i) + Environment.NewLine;
                }
            }
        }
    }
}
