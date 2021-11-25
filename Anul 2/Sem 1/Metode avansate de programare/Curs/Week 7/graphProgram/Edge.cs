﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace graphProgram
{
    public class Edge
    {
        public static int draw_size = 4;
        public static Color draw_color = Color.Blue;

        Vertice begin_vertice;
        Vertice end_vertice;


        public Edge(string data, List<Vertice> vertices)
        {
            string[] local = data.Split(' ');
            int begin_idx = int.Parse(local[0]);
            int end_idx = int.Parse(local[1]);

            begin_vertice = vertices[begin_idx];
            end_vertice = vertices[end_idx];
        }

        public void draw(Graphics handler)
        {
            handler.DrawLine(new Pen(draw_color, draw_size), begin_vertice.map_location, end_vertice.map_location);
        }
    }
}
