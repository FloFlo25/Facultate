using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partea_practica
{
    class Program
    {
        static void Main(string[] args)
        {
            StivaFixa test = new StivaFixa();

            test.Push(23);
            test.Peek();
            Console.WriteLine();

            test.Alice(@"/i/love\you\");

            Console.ReadKey();
        }
    }
}
