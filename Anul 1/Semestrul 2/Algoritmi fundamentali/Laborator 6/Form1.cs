using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.graph_init(pictureBox1);
            Engine.init_sesion();
            Engine.init_demo();


            Engine.drawMap();
        }

        private void btn_battleCicle_Click(object sender, EventArgs e)
        {
            Engine.battleCicle();
            Engine.drawMap();
        }

        private void cicleBattle()
        {
            Engine.battleCicle();
            Engine.drawMap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cicleBattle();
        }
    }
}
