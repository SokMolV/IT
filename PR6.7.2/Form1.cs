using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._7._2
{
    public partial class Form1 : Form
    {
        int[,] a = new int[5, 5]; //Инициализируем массив
        int i, j;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5; //Указываем количество строк
            dataGridView1.ColumnCount = 5; //Указываем количество столбцов
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    a[i, j] = rand.Next(-100, 100);
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //max
            int max = a[0, 0];
            int stolbmax = 0;
            for (i = 0; i < a.GetLength(0); i++)//строки
            {
                for (j = 0; j < a.GetLength(1); j++)//столбцы
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        stolbmax = j;
                    }
                }
            }
            //min
            int min = a[0, 0];
            int stolbmin = 0;
            for (i = 0; i < a.GetLength(0); i++)//строки
            {
                for (j = 0; j < a.GetLength(1); j++)//столбцы
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        stolbmin = j;
                    }
                }
            }
            for (i = 0; i < 5; i++)
            {
                a[i, stolbmax] = 0;
                a[i, stolbmin] = 0;
                dataGridView1.Rows[i].Cells[stolbmax].Value = Convert.ToString(0);
                dataGridView1.Rows[i].Cells[stolbmin].Value = Convert.ToString(0);
            }
            label1.Text ="Найден минимальный элемент " + min.ToString() + " находящийся в столбце " + stolbmin.ToString();
            label2.Text = "Найден максимальный элемент " + max.ToString() + " находящийся в столбце " + stolbmax.ToString();
        }
    }
}
