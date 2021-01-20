using System;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Numarul a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Numarul b= ");
            b = int.Parse(Console.ReadLine());

            swap(ref a, ref b);

            Console.WriteLine($"Numerele interschimbate sunt: \na={a}\nb={b}");
        }

        private static void swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}
