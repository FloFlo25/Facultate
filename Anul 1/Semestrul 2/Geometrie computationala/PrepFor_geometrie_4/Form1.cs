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

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            float X = float.Parse(textBox1.Text);
            float Y = float.Parse(textBox2.Text);
            Engine.points.Add(new myPoint(X,Y));
            Engine.draw(myGraphics.grp);
            //Engine.GrahamAlghoritm(myGraphics.grp);
            myGraphics.refreshGraph();
        }
    }
}
