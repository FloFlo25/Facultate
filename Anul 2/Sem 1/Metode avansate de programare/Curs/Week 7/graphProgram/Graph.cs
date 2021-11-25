using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace graphProgram
{
    public class Graph
    {
        public List<Vertice> vertices;
        public List<Edge> edges;

        public Graph()
        {
            vertices = new List<Vertice>();
            edges = new List<Edge>();
        }

        public void load(string file_name)
        {
            TextReader data_load = new StreamReader(@"..\..\" + file_name);
            int n = int.Parse(data_load.ReadLine());
            for (int i = 0; i < n; i++)
            {
                vertices.Add(new Vertice(data_load.ReadLine()));
            }

            string buffer;
            while ((buffer = data_load.ReadLine()) != null)
            {
                edges.Add(new Edge(buffer, vertices));
            }
        }

        public void draw(Graphics handler)
        {
            foreach (Edge edge in edges)
            {
                edge.draw(handler);
            }
            foreach (Vertice vertice in vertices)
            {
                vertice.draw(handler);
            }
        }


    }
}
