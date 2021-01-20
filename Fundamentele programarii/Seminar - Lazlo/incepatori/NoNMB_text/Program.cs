using System;

namespace NoNMB_text
{
    class Program
    {
        //NETERMINAT
        static void Main(string[] args)
        {
            int[] v = new int[] { 12, 2345, 123, 67, 989, 6, 99, 123, 67, 989, 999 };
            int[] vOpus = new int[999] ;
            int max1, max2;

            max1 = v[0];
            max2 = v[1];

            for (int i = 0; i < vOpus.Length; i++)
            {
                vOpus[i] = i + 1;
            }

            for (int i = 0; i < v.Length; i++)
            {
                //for(int j = 0;j<vOpus.Length;j++)
                //{
                 //   if (vOpus[j] == v[i])
                        vOpus =Array.FindAll(vOpus,(System.Predicate<int>)v[i]);
               // }
            }

            foreach (var item in vOpus)
            {
                Console.Write($"{item} ");
            }

            /*for (int i = 2; i < v.Length; i++)
            {
                if (v[i] > 999 || v[i]<100)
                    i++;
                if (max1 < v[i])
                {
                    max2 = max1;
                    max1 = v[i];
                }
            }*/

            //Console.Write($"{max2} {max1}");
        }
    }
}
