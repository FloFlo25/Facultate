using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _Ex3
{
    public class myPoint
    {
        public static int size = 4;
        public float X, Y;
        public Color fillColor;
        public Color drawColor;
        public string nume;

        public myPoint(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = Color.Red;
            this.drawColor = Color.Black;
        }

        public myPoint(float X, float Y, Color fillColor, Color drawColor)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = fillColor;
            this.drawColor = drawColor;
        }

        /*public myPoint(Random rndX, Random rndY, Color fillColor, Color drawColor)
        {
            this.X = rndX.Next(myGraphics.resX);
            this.Y = rndY.Next(myGraphics.resY);
            this.fillColor = fillColor;
            this.drawColor = drawColor;
        }*/

        public void draw(Graphics grp)
        {
            Pen pen = new Pen(drawColor);
            SolidBrush sBrush = new SolidBrush(fillColor);
            grp.FillEllipse(sBrush, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            grp.DrawEllipse(pen, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            grp.DrawString(nume, new Font("Arial", 10, FontStyle.Regular), sBrush, X, Y);
        }
    }
}
