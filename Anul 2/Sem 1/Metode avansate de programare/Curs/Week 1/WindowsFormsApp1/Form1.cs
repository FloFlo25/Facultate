using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region Properties
        

        #endregion

        #region Methods
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            PointCollection A = new PointCollection(100);
            PointCollection B = new PointCollection(@"..\..\Puncte.txt",false);

            //A.draw();
            B.draw();
        }
        
        

        #endregion
    }
}
