using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//11 выражение

namespace PR8._9
{
    public partial class Form1 : Form
    {
        Chart chart;
        ChartArea area;
        // Левая граница графика
        private double XMin = -Math.PI;
        // Правая граница графика
        private double XMax = Math.PI;
        private double PointsCount;
        private double Step = (Math.PI * 2) / 10;
        // Массив значений X - общий для обоих графиков
        private double[] x;
        // Два массива Y - по одному для каждого графика
        private double[] y;

        // Расчѐт значений графика
        private void CalcFunction()
        {
            // Количество точек графика
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            // Создаѐм массивы нужных размеров
            x = new double[count];
            y = new double[count];
            // Расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = XMin + Step * i;
                // Вычисляем значение функций в точке X
                y[i] = Math.Sqrt(3 + Math.Log(x[i]) + 15 - x[i]) / (1 + Math.Sin((2 + Math.Pow(x[i], 2)) / (1 + x[i])));
            }
        }

        // Создаѐм элемент управления Chart и настраиваем его
        private void CreateChart()
        {
            // Создаѐм новый элемент управления Chart
            chart = new Chart();
            // Помещаем его на форму
            chart.Parent = this;
            // Задаѐм размеры элемента
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 100);
            // Создаѐм новую область для построения графика
            area = new ChartArea();
            // Даѐм ей имя (чтобы потом добавлять графики)
            area.Name = "myGraph";
            // Задаѐм левую и правую границы оси X
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            // Определяем шаг сетки
            area.AxisX.MajorGrid.Interval = Step;
            // Добавляем область в диаграмму
            chart.ChartAreas.Add(area);
            // Создаѐм объект для первого графика
            Series series1 = new Series();
            // Ссылаемся на область для построения графика
            series1.ChartArea = "myGraph";
            // Задаѐм тип графика - сплайны
            series1.ChartType = SeriesChartType.Spline;
            // Указываем ширину линии графика
            series1.BorderWidth = 3;
            // Название графика для отображения в легенде
            series1.LegendText = "f(x)";
            // Добавляем в список графиков диаграммы
            chart.Series.Add(series1);
      
            // Создаѐм легенду, которая будет показывать названия
             Legend legend = new Legend();
            chart.Legends.Add(legend);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMin = float.Parse(textBox1.Text);
            XMax = float.Parse(textBox2.Text);
            PointsCount = float.Parse(textBox3.Text);
            Step = (XMax - XMin) / PointsCount;
            if (chart == null)
            {
                // Создаѐм элемент управления
                CreateChart();
            }
            // Задаѐм левую и правую границы оси X
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            // Расчитываем значения точек графиков функций
            CalcFunction();
            // Добавляем вычисленные значения в графики
            chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}
