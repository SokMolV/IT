using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR8._9._2
{
    public partial class Form1 : Form
    {
        Point[] points = new Point[50];
        Pen pen = new Pen(Color.Black, 2);
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            e.Graphics.FillEllipse(solidBrush, 180, 50, 90, 100);
            e.Graphics.FillEllipse(solidBrush, 100, 50, 90, 100);
            SolidBrush red = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            Point point1 = new Point(105, 125);
            Point point2 = new Point(184, 220);
           Point point3 = new Point(265, 125);
            Point[] curvePoints ={ point1, point2, point3};
            e.Graphics.FillPolygon(red, curvePoints);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                int xPos;
                if (i % 2 == 0)
                {
                    xPos = 10;
                }
                else
                {
                    xPos = 400;
                }
                points[i] = new Point(xPos, 10 * i);
            }
        }
    }
}
