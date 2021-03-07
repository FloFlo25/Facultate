using System;
using System.IO;

namespace Curs1_PB_TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int baza = 1;
            int tmp;

            for (int i = 0; i < 20; i++)
            {
                v[i] = baza;
                baza = baza * 2;
                Console.WriteLine(baza + " ");
            }

            TextReader load = new StreamReader(@"E:\Visual Studio\Teme\FloFlo25\Teme\Semestrul 2\Algoritmi fundamentali\Curs1_PB_TextReader\date.in");
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local = buffer.Split(' ');
                foreach (string s in local)
                {
                    Console.WriteLine(s);
                    tmp = int.Parse(s);
                }
            }
        }
    }
}
