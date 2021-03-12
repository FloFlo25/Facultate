using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrepFor_geometrie_4
{
    public static class Engine
    {
        public static List<myPoint> points = new List<myPoint>();
        public static Stack<myPoint> stack = new Stack<myPoint>();
        public static myPoint lowestYpoint;

        public static void draw(Graphics grp)
        {
            
            for (int i = 0; i < points.Count-1; i++)
                grp.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            grp.DrawLine(Pens.Black, points[points.Count-1].X, points[points.Count-1].Y, points[0].X, points[0].Y);

            foreach (myPoint point in points)
                point.draw(grp);

        }

        public static void GrahamAlghoritm(Graphics grp)
        {
            //int degree = Math.Atan2();
            lowestYpoint = new myPoint(0, 0);
            foreach (myPoint point in points)
            {
                if (lowestYpoint.Y < point.Y)
                {
                    lowestYpoint.Y = point.Y;
                }
            }



            
        }

    }
}
