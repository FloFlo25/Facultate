using System;

namespace Numere_Complexe
{
    class Program
    {
        static void Main(string[] args)
        {

            var complex1 = new Complex(2, 3);
            var complex2 = new Complex(5, 4);


            Console.WriteLine("Adunare: " + complex1.adunare(complex2));
            Console.WriteLine("Scadere: " + complex1.scadere(complex2));
            Console.WriteLine("Inmultire: " + complex1.inmultire(complex2));
            Console.WriteLine("Impartire: " + complex1.impartire(complex2));

            Console.ReadKey();

        }
    }
}
