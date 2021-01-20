using System;

namespace _813
{
    class Program
    {
        static void Main(string[] args)
        {
            int albe, rosii, verzi;

            albe = int.Parse(Console.ReadLine());

            rosii = albe * 2;
            verzi = rosii - 3;

            Console.WriteLine(albe + rosii + verzi);
        }
    }
}
