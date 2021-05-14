using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR10
{
    public partial class Form1 : Form
    {
        private int x=50, y=90, z=100, k=180, l=100;
        private int a = 105, b = 184, c = 265, d = 125, r = 220;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            e.Graphics.FillEllipse(solidBrush, k, x, y, z);// 180/50/90/100
            e.Graphics.FillEllipse(solidBrush, l, x, y, z);// 100/50/90/100
            SolidBrush red = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            Point point1 = new Point(a, d);// 105/125
            Point point2 = new Point(b, r);// 184/220
            Point point3 = new Point(c, d);// 265/125
            Point[] curvePoints = { point1, point2, point3 };
            e.Graphics.FillPolygon(red, curvePoints);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = +50;
            y = +50;
            z = +50;
            k = +50;
            l = +50;
            a = +50;
            b = +50;
            c = +50;
            d = +50;
            r = +50;

            Invalidate(); //вынудительный вызов перерисовки (Paint)
        }
    }
}
