using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepFor_geometrie_4
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(canvasImage);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        public static bool isPrime(int n)
        {
            // Corner case
            if (n <= 1)
                return false;

            // Check from 2 to n-1
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }


        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            float X = float.Parse(textBox1.Text);
            float Y = float.Parse(textBox2.Text);
            /*float X = rnd.Next(myGraphics.resX);
            float Y = rnd.Next(myGraphics.resY);*/

            Engine.points.Add(new myPoint(X,Y));
            

            Engine.drawPoints(myGraphics.grp);
            //Engine.drawLines(myGraphics.grp);

            //Engine.GrahamAlghoritm(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.drawLines(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private void btn_drawRandom_Click(object sender, EventArgs e)
        {
            Engine.drawRandom(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private void drawAxis_Click(object sender, EventArgs e)
        {
            Engine.squareMedians(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private void genPointsByNmb_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            myGraphics.refreshGraph();

            int nmbOfPoints = (int)(selectNmbPoints.Value);

            for (int i = 1; i <= nmbOfPoints; i++)
            {
                float X = rnd.Next(myGraphics.resX);
                float Y = rnd.Next(myGraphics.resY);
                Engine.points.Add(new myPoint(X, Y));
                Engine.drawPoints(myGraphics.grp);
                Engine.drawLines(myGraphics.grp);
                myGraphics.refreshGraph();
            }

        }
    }
}
