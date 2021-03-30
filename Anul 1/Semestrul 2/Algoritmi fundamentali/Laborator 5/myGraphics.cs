using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace point
{
    public class myGraphics 
    {
        //GDI / GDI+
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static int resx, resy;
        public static Color backColor = Color.LightSkyBlue;

        public static void initGraph(PictureBox Display) 
        {
            display = Display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            resx = display.Width;
            resy = display.Height;
            clearGraph();
        }

        public static void clearGraph()
        {
            grp.Clear(backColor);
        }
        public static void refreshGraph()
        {
            display.Image = bmp;
        }
        
        public static void drawPoint(PointF A, Color fillColor, Color drawColor, int radius)
        {
            Pen draw = new Pen(drawColor);
            SolidBrush fill = new SolidBrush(fillColor);
            grp.FillEllipse(fill, A.X - radius, A.Y - radius, radius * 2 + 1, radius * 2 + 1);
            grp.DrawEllipse(draw, A.X - radius, A.Y - radius, radius * 2 + 1, radius * 2 + 1);
        }
    }
}
