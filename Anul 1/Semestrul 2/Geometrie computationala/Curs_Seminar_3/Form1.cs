using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_Seminar_3
{
    public partial class Form1 : Form
    {

        public Graphics gfx;
        public Pen pen = new Pen(Color.Black);
        //public PointF[] points = new PointF[3];
        private List<point> puncte = new List<point>();

        

        public Form1()
        {
            InitializeComponent();
        }


        public class point
        {
            public int x, y;
        }


        public void readTextBox()
        {
            point A = new point();
            point B = new point();
            point C = new point();

            A.x = int.Parse(textBox1.Text);
            A.y = int.Parse(textBox2.Text);

            B.x = int.Parse(textBox3.Text);
            B.y = int.Parse(textBox4.Text);

            C.x = int.Parse(textBox5.Text);
            C.y = int.Parse(textBox6.Text);

            puncte.Add(A);
            puncte.Add(B);
            puncte.Add(C);
        }

        public void createLabel()
        {
            gfx.DrawString("A", Font, Brushes.Black, puncte[0].x - 3, puncte[0].y - 3);
            gfx.DrawString("B", Font, Brushes.Black, puncte[1].x + 3, puncte[1].y - 3);
            gfx.DrawString("C", Font, Brushes.Black, puncte[2].x - 3, puncte[2].y + 3);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            /*int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            int x3 = int.Parse(textBox5.Text);
            int y3 = int.Parse(textBox6.Text);*//*

            int x1 = 50;
            int y1 = 250;
            int x2 = 450;
            int y2 = 250;
            int x3 = 250;
            int y3 = 10;*/

            readTextBox();

            /* PointF[] points = new PointF[]
             {
                     new PointF(x: x1, y: y1),
                     new PointF(x: x2, y: y2),
                     new PointF(x: x3, y: y3),
             };*/



            //gfx.DrawPolygon(pen, points);

            //draw first 2 lines
            for (int i = 1; i < puncte.Count; i++)
            {
                gfx.DrawLine(Pens.Black, puncte[i].x, puncte[i].y, puncte[i - 1].x, puncte[i - 1].y);
            }

            //draw third line
            int countPuncte = puncte.Count;
            gfx.DrawLine(Pens.Black, puncte[countPuncte - 1].x, puncte[countPuncte - 1].y, puncte[0].x, puncte[0].y);

            createLabel();
            //gfx.DrawString("A", Font, Brushes.Black, puncte[0].x - 2, puncte[0].y - 2);

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //redLine
            gfx.FillEllipse(new SolidBrush(Color.Red), (puncte[0].x + puncte[1].x) / 2 - 5, (puncte[0].y + puncte[1].y) / 2 - 5, 10, 10);
            gfx.DrawLine(new Pen(Color.Red), (puncte[0].x + puncte[1].x) / 2, (puncte[0].y + puncte[1].y) / 2, puncte[2].x, puncte[2].y);

            //greenLine
            gfx.FillEllipse(new SolidBrush(Color.Green), (puncte[0].x + puncte[2].x) / 2 - 5, (puncte[0].y + puncte[2].y) / 2 - 5, 10, 10);
            gfx.DrawLine(new Pen(Color.Green), (puncte[0].x + puncte[2].x) / 2, (puncte[0].y + puncte[2].y) / 2, puncte[1].x, puncte[1].y);

            //yellowLine
            gfx.FillEllipse(new SolidBrush(Color.Yellow), (puncte[1].x + puncte[2].x) / 2 - 5, (puncte[1].y + puncte[2].y) / 2 - 5, 10, 10);
            gfx.DrawLine(new Pen(Color.Yellow), (puncte[1].x + puncte[2].x) / 2, (puncte[1].y + puncte[2].y) / 2, puncte[0].x, puncte[0].y);
        }
    }
}
