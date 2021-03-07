using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int x1,x2,delta;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // ax^2 + bx + c = 0
            // delta = b^2 - 4ac

            delta = (int)Math.Pow(b, 2) - 4*a*c;

            if(delta < 0)
            {
                Console.WriteLine("Ecuatia nu are soltuii in R.");
            }
            else if(delta == 0)
            {
                Console.WriteLine($"Radacina ecuatiei este {-b / (2*a)}");
            }
            else
            {
                x1 = (-b - (int)Math.Sqrt(delta))/(2*a);
                x2 = (-b + (int)Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Radacinilie ecuatiei sunt {x1} si {x2}");
            }
        }
    }
}
