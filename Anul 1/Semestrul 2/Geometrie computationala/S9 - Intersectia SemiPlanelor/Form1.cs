using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S9___Intersectia_SemiPlanelor
{
    public partial class Form1 : Form
    {
        private bool m_ShowTriangle = false;
        public List<PointF> points;
        public PointF[] puncte;

        public Form1()
        {
            InitializeComponent();
        }

        public void DrawPolygonPointF(PaintEventArgs e)
        {
            using (Pen blackPen = new Pen(Color.Black,3))
            {
                // Create points.
                PointF point1 = new PointF(50.0F, 50.0F);
                PointF point2 = new PointF(100.0F, 25.0F);
                PointF point3 = new PointF(200.0F, 200.0F);
                PointF point4 = new PointF(250.0F, 220.0F);

                PointF[] points =
                {
                    point1,
                    point2,
                    point3,
                    point4
                };



                e.Graphics.DrawPolygon(blackPen, points);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (m_ShowTriangle)
            {
                DrawPolygonPointF(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_ShowTriangle = true;
            Invalidate();
            Update();
        }

        /*private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new PointF(e.X, e.Y));
            puncte = points.ToArray();
        }*/
    }
}
