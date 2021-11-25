using System;
using System.Drawing;

namespace graphProgram
{
    public class Vertice
    {
        public static int size = 10;
        public string name;
        public Point map_location { get; set; }
        public Color fill_color { get; set; }


        public Vertice(string data)
        {
            string[] local = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = local[0];

            string[] point_data = local[1].Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            map_location = new Point(int.Parse(point_data[0]), int.Parse(point_data[1]));

            string[] color_data = local[2].Split(new char[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);

            int r = int.Parse(color_data[0]);
            int g = int.Parse(color_data[1]);
            int b = int.Parse(color_data[2]);
            fill_color = Color.FromArgb(r, g, b);


        }

        public void draw(Graphics handler)
        {
            handler.FillEllipse(new SolidBrush(fill_color), map_location.X - size, map_location.Y - size, 2 * size + 1, 2 * size + 1);
            handler.DrawEllipse(new Pen(Color.Black), map_location.X - size, map_location.Y - size, 2 * size + 1, 2 * size + 1);
            handler.DrawString(name, new Font("Comic Sans MS", 10, FontStyle.Italic), new SolidBrush(Color.Black), new Point(map_location.X - size, map_location.Y - size));
        }
    }
}
