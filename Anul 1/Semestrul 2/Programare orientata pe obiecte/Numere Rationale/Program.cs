using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_Rationale
{
    class Program
    {
        static void Main(string[] args)
        {


            var rational1 = new Rational(2, 3);
            var rational2 = new Rational(2, 3);
            var rational3 = new Rational(2, 4);

            Console.WriteLine(rational1.adunare(rational2));
            Console.WriteLine(rational1.adunare(rational3));

            Console.ReadKey();

        }
    }
}
