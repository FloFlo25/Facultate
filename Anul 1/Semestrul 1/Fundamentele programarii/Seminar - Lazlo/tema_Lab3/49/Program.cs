using System;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar, fact=1, i;

            Console.Write("Introduceti numarul: ");
            numar = int.Parse(Console.ReadLine());

            for (i = 1; i <= numar; i++)
                fact *= i;

            Console.WriteLine($"{numar}! = {fact}");
        }
    }
}
