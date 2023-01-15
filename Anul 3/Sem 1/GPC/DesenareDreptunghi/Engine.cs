using DesenareDreptunghi.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenareDreptunghi
{

    interface IEngine
    {
        void Draw(GeometricFigures geometricFigure);
        void Clear();
    }
    public class Engine : IEngine
    {
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Draw(GeometricFigures geometricFigure)
        {
            
        }
    }
}
