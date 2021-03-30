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
    public static class Engine
    {
        #region Random

        public static Random rnd = new Random();
        public static PointF getRndPoint()
        {
            float X = rnd.Next(myGraphics.resx);
            float Y = rnd.Next(myGraphics.resy);
            return new PointF(X, Y);
        }

        #endregion

        #region App

        public static Polygon poligon;

        public static void init()
        {
            poligon = new Polygon(10);
        }
        public static void draw()
        {
            poligon.draw(myGraphics.grp);
            myGraphics.refreshGraph();
        }
        #endregion
    }
}
