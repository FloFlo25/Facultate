using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sierpinski_triangle
{
    #region Graphics
    public static partial class Engine
    {

        public static Bitmap bmp;
        public static Graphics grp;
        public static Color backColor = Color.LightBlue;
        public static int resx, resy;
        public static PictureBox display;

        public static void initGraph(PictureBox T)
        {
            display = T;
            resx = display.Width;
            resy = display.Height;
            bmp = new Bitmap(resx, resy);
            grp = Graphics.FromImage(bmp);

            clearGraph();
            refreshGraph();
        }

        public static void refreshGraph()
        {
            display.Image = bmp;
        }

        public static void clearGraph()
        {
            grp.Clear(backColor);
        }

    }
    #endregion
    #region Math
    public static partial class Engine
    {
        
        float d(PointF A, PointF B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }




        
    }
    #endregion
}