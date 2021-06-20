using System;

namespace Curs_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Testare2 test = new Testare2();
            test.hello_world();
        }
    }

    public abstract class Testare
    {
        public abstract void hello_world();
    }

    public class Testare2:Testare
    {
        public override void hello_world()
        {
            Console.WriteLine("Hello World");
        }
    }

}
