using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using point;

namespace Laborator_5
{
    public class Polygon
    {
        PointF[] points;
        public Polygon(int nr_of_points)
        {
            points = new PointF[nr_of_points];
            for (int i = 0; i < nr_of_points; i++)
            {
                points[i] = Engine.getRndPoint();
            }
        }

        public void draw(Graphics grp)
        {
            grp.DrawPolygon(Pens.Black, points);
        }





        public PointF cg()
        {
            float X = 0;
            float Y = 0;
            for (int i = 0; i < points.Length; i++)
            {
                X += points[i].X;
                Y += points[i].Y;
            }
            return new PointF(X / points.Length, Y / points.Length);
        }
    }
}
