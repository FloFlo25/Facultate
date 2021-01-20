using System;
using System.IO;

namespace Sir_frecv
{
    class Program
    {
        static void Main(string[] args)
        {   
            //metoda 2 - citire din fisier
            TextReader load = new StreamReader(@"../../../IN.txt");
            string buffer = load.ReadLine();
            char seps = ' ';

            string[] v = buffer.Split(seps);
            //int[] v = new int[] {1,1,1,2,2,3,3,3,3,3,4,5,6,8,8};  //metoda 1
            bool nrDiferite = true;
            int nrApar = 1;
            

            
            for (int i = 0; i < v.Length-1; i++)
            {
                if (v[i] == v[i + 1])
                    nrApar++;
                else
                {
                    nrDiferite = false;
                }

                if (nrDiferite == false || i+1==v.Length-1)
                {
                    Console.Write($"{v[i]} {nrApar} ");
                    nrApar = 1;
                    nrDiferite = true;
                }
            
            }
        }
    }
}
