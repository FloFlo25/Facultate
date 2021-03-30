using PrepFor_geometrie_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jarvis_Graham_Algh
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);

        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
            int rndX;
            int rndY;
            int n = 10;
            Point[] points = new Point[n];


            for (int i = 0; i < n; i++)
            {
                rndX = rnd.Next(0, myGraphics.resX - 100);
                rndY = rnd.Next(0, myGraphics.resY - 100);

                points[i] = new Point(rndX, rndY);
                Engine.pointDrawer(myGraphics.grp);
                myGraphics.refreshGraph();
            }

            
            
            myGraphics.refreshGraph();
            //Point.GFG.convexHull(points, n);
            
        }
    }
}
