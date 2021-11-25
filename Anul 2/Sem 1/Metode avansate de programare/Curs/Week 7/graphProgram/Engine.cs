﻿using System.Drawing;
using System.Windows.Forms;

namespace graphProgram
{
    public static class Engine
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static Color backColor = Color.AliceBlue;



        public static void init_graph(PictureBox _display)
        {
            display = _display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(backColor);
            display.Image = bmp;
        }

        public static void refresh()
        {
            display.Image = bmp;
        }
    }
}
