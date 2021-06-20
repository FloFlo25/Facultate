using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.numbers.Add(10);
            Engine.numbers.Add(9);
            Engine.numbers.Add(15);
            Engine.numbers.Add(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
            myGraphics.clearGraph();
        }
    }
}
