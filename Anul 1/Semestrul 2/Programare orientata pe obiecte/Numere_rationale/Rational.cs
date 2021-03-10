using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Numere_rationale
{
    class Rational
    {
        private int numarator;
        private int numitor;

        public Rational(int numarator, int numitor)
        {
            if (numitor == 0)
                throw new ArgumentException("Numitorul nu poate fi 0.", nameof(numitor));

            this.numarator = numarator;
            this.numitor = numitor;

            Console.WriteLine("A fost creata o noua fractie");

        }




        public void Add(Rational fractie2)
        {

        }


    }
}
