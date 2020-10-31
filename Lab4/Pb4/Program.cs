using System;

namespace Pb4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s1, s2;
            double delta;

            //citire ecuatie
            Console.Write("Scrieti a= ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Scrieti b= ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Scrieti c= ");
            c = double.Parse(Console.ReadLine());

            Console.Clear();


            //Console.WriteLine($"{a}x^2+{b}x+{c}=0"); //afisare ecuatie


            //formula delta
            delta = (int)Math.Pow(b, 2) - (4 * a * c);

            if(delta>=0)
            {
                s1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Prima radacina a ecuatiei: {(int)s1}");

                s2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"A doua radacina a ecuatiei: {(int)s2}");
            }
        }
    }
}
