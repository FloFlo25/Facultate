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

        public static void drawLines(Graphics grp)
        {

            for (int i = 0; i < points.Count - 1; i++)
                grp.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            grp.DrawLine(Pens.Black, points[points.Count - 1].X, points[points.Count - 1].Y, points[0].X, points[0].Y);



            /*foreach (myPoint point in points)
                point.draw(grp);*/
            
        }

        public static void squareMedians(Graphics grp)
        {
            Random rnd = new Random();
            int increaseRange = 100;
            Pen pen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));

            drawRandom(grp);

            foreach (myPoint point in points)
            {
                grp.DrawLine(Pens.Black, point.X+increaseRange/2, point.Y, point.X + increaseRange/2, point.Y+increaseRange);
                grp.DrawLine(Pens.Black, point.X, point.Y+increaseRange/2, point.X + increaseRange, point.Y + increaseRange/2);
                grp.DrawLine(Pens.Black, point.X, point.Y, point.X + increaseRange, point.Y + increaseRange);
                grp.DrawLine(Pens.Black, point.X + increaseRange, point.Y, point.X, point.Y + increaseRange);
                increaseRange += 5;
            }
        }

        public static void drawRandom(Graphics grp)
        {
            Random rnd = new Random();
            int increaseRange = 100;
            Pen pen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));


            myGraphics.clearGraph();

            for (int i = 0; i < 9; i++)
            {
                points.Add(new myPoint(rnd.Next(myGraphics.resX-150), rnd.Next(myGraphics.resY-150)));
            }

            foreach (myPoint point in points)
            {
                grp.DrawLine(pen, point.X, point.Y, point.X + increaseRange, point.Y);
                grp.DrawLine(pen, point.X + increaseRange, point.Y, point.X + increaseRange, point.Y+increaseRange);
                grp.DrawLine(pen, point.X + increaseRange, point.Y + increaseRange, point.X, point.Y+increaseRange);
                grp.DrawLine(pen, point.X, point.Y + increaseRange, point.X, point.Y);
                pen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                increaseRange += 5;
            }

        }

        public static void drawPoints(Graphics grp)
        {
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
