using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar,indx=1,suma=0;
            string line;

            line = Console.ReadLine();

            numar = int.Parse(line);

            do
            {
                if (indx % 2 != 0)
                    suma = suma + indx;
                else
                    suma = suma - indx;
                indx++;
            } while (indx <= numar);

            Console.WriteLine(suma);
        }
    }
}
