using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Selection_sort
{
    public class Rectangles
    {
        public static Graphics grp;

        public static void drawRectangle(myGraphics myGrp)
        {
            for (int i = 0; i < Engine.numbers.Count; i++)
            {
                grp.DrawRectangle(Pens.Black, myGraphics.resX, myGraphics.resY, Engine.numbers.Count, Engine.numbers[i]);

            }
        }
    }
}
