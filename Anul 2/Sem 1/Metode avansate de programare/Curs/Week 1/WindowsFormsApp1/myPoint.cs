using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class myPoint
    {
        static int radius = 5;
        float X, Y;
        //Color fillColor;
        //Color drawColor;
        Pen draw_;
        SolidBrush fill_;

        public myPoint(PointF A)
        {
            X = A.X;
            Y = A.Y;
            draw_ = new Pen(Color.Black);
            fill_ = new SolidBrush(Color.White);
        }

        public void setColor(Color drawColor, Color fillColor)
        {
            //this.drawColor = drawColor;
            //this.fillColor = fillColor;
            draw_ = new Pen(drawColor);
            fill_ = new SolidBrush(fillColor);

        }

        public void draw(Graphics graphics)
        {
            graphics.DrawEllipse(draw_, X - radius, Y - radius, 2 * radius + 1, 2 * radius + 1);
            graphics.FillEllipse(fill_, X - radius, Y - radius, 2 * radius + 1, 2 * radius + 1);
        }
    }
}
