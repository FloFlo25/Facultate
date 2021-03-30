using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PrepFor_geometrie_4
{
    public static class myGraphics
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static int resX, resY;
        public static Color backColor = Color.LightGray;

        public static void initGraph(PictureBox Display)
        {
            display = Display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            resX = display.Width;
            resY = display.Height;
            clearGraph();
        }

        public static void clearGraph()
        {
            grp.Clear(backColor);
            Engine.points.Clear();
        }

        public static void refreshGraph()
        {
            display.Image = bmp;
        }
    }
}
