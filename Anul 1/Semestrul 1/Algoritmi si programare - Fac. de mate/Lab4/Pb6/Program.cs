using System;

namespace Pb6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar;

            Console.Write("Introduceti numarul: ");
            numar = int.Parse(Console.ReadLine());
            Console.Clear();

            if (Math.Sqrt(numar) == (int)Math.Sqrt(numar))
            {
                Console.WriteLine("Numarul este patrat perfect.");
            }
            else
                Console.WriteLine("Numarul nu este patrat perfect.");



            //if (sqrt(a) == int(sqrt(a)))
        }
    }
}
