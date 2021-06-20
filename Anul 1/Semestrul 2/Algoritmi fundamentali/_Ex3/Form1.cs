using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myGraphics.initGraph(pictureBox1);
        }

        private void btn_refresh_Click_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click_Click(object sender, EventArgs e)
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
            /*for (int i = 0; i < myGraphics.resX; i++)
            {
                for (int j = 0; j < myGraphics.resY; j++)
                {
                    if (isPrime(i) && isPrime(j))
                    {

                    }
                }
            }*/


            for (int i = 0; i < myGraphics.resX; i++)
            {
                for (int j = 0; j < myGraphics.resY; j++)
                {
                    Engine.points.Add(new myPoint(i, j,Color.Blue,Color.Gray));
                }
            }
            //Engine.points.Add(new myPoint(X, Y));


            Engine.drawPoints(myGraphics.grp);
            //Engine.drawLines(myGraphics.grp);

            //Engine.GrahamAlghoritm(myGraphics.grp);
            myGraphics.refreshGraph();
        }
    }
}
