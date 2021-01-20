using System;
using System.IO;

namespace Sort_Capat_impare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TextReader numere = new StreamReader(@"../../../IN.txt");
            //char seps = ' ';
            //int buffer = int.Parse(numere.ReadLine());
            //int[] v = buffer.Split(seps);

            int[] v = new int[] { 12, 15, 68, 13, 17, 90, 31, 42 };
            
            bool IMP1 = false, IMP2 = false;
            int imp1=0, imp2=0;


            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 != 0 && IMP1 == false)
                {
                    imp1 = v[i];
                    IMP1 = true;
                }
                if (v[i] % 2 != 0 && IMP1 == true)
                {
                    imp2 = v[i];
                    IMP2 = true;
                }
                if (v[i] % 2 != 0 && IMP1 == true && IMP2 == true)
                {
                    imp2 = imp1;
                    imp1 = v[i];
                }    
            }
            if(imp1!=0)
                Console.Write($"{imp2} {imp1}");
            else
                Console.Write($"Numere insuficiente");
        }
    }
}
