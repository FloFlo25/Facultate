using System;
using System.Collections.Generic;

namespace Laborator_3
{
    public class Point
    {
        private double x,y;

        //TODO de facut istoric
        //tine un istoric al valorilor pe care le-a avut punctul intr-o stiva
        //Stack<> ----> stiva !!!
        Stack<Point> history = new Stack<Point>();




        #region Constructors
        public Point(): this(0.0,0.0)
        {

        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        /// <summary>
        /// Initializeaza un Point de baza unui string de forma "(3.0, 4.0)"
        /// </summary>
        /// <param name="str"></param>
        public Point(string str)
        {
            //TODO
            str = str.Trim();
        }

        
        #endregion


        public override string ToString()
        {
            return $"({x}; {y})";
        }

        public double DistanceToOrigin()
        {
            return DistanceTo(new Point());
        }
        public double DistanceTo(Point p2)
        {
            double x1, y1, x2, y2;

            x1 = this.x;
            y1 = this.y;

            x2 = p2.x;
            y2 = p2.y;
            
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public void MoveBy(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}