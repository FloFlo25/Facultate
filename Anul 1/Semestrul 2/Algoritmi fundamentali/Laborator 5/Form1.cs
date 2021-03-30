using point;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PointF centruGreutate;
        PointF eg;


        private void Form1_Load(object sender, EventArgs e)
        {
            myGraphics.initGraph(pictureBox1);
            Engine.init();
            Engine.draw();

            centruGreutate = Engine.poligon.cg();

            myGraphics.drawPoint(centruGreutate, Color.Red, Color.Black, 5);
            myGraphics.refreshGraph();
        }
    }
}
