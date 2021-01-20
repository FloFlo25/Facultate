using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Selectati programul dorit: ");
            Console.WriteLine("1. Prob1");
            Console.WriteLine("2. Prob4");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    {
                        Console.Clear();
                        Prob1();
                        break;
                        
                    }
                case 2:
                    Console.Clear();
                    Prob4();
                    break;
            }
            
        }

        private static void Prob4()
        {
            Console.WriteLine("Problema 4");

            int n,ghici,incercari=0;
            Random rand = new Random();

            n = rand.Next(1000);

            do
            {
                ghici = int.Parse(Console.ReadLine());
                if (ghici < n)
                    Console.WriteLine("Mai mare");
                if(ghici>n)
                    Console.WriteLine("Mai mic");
                incercari++;

            } while (ghici!=n);

            Console.WriteLine($"Ai ghicit numarul din {incercari} incercari!");
        }

        private static void Prob1()
        {
            Console.WriteLine("Problema 1");

            int i;
            string sir; //marcel - 

            sir = Console.ReadLine();

            for(i=0;i<sir.Length;i++)
            {
                if (Char.IsWhiteSpace(sir[i]))
                {
                    if (i == 0 || !Char.IsWhiteSpace(sir[i - 1]))
                        Console.WriteLine();
                }
                else
                    Console.Write(Char.ToLower(sir[i]));
            }
        }
    }
}
