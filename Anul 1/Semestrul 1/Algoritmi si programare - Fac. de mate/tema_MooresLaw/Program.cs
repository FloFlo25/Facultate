using System;

namespace tema_MooresLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Console.Read();
            int Luni = 0;
            int putere = 1;

            do
            {
                Luni += 18;
                putere *= 2;
            } while (putere<=n);

            Console.WriteLine(Luni);
        }
    }
}
