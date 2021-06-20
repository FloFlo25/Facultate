using System;
using System.Collections.Generic;
using System.IO;

namespace FlorutaRaul_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int n = 0, m = 0;
            List<string> data = new List<string>();

            TextReader file = new StreamReader(@"../../data01.in");

            //StreamReader file = new StreamReader(@"../../data01.in");


            while ((line = file.ReadLine()) != null)
            {
                data.Add(line);
            }
            file.Close();

            n = int.Parse(data[0]);
            m = int.Parse(data[2]);

            string s1 = data[1];

            string[] numbers1 = new string[n];
            int[] numbers2 = new int[n];

            string[] numbers3 = new string[n];
            int[] numbers4 = new int[n];

            numbers1 = data[1].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            numbers3 = data[3].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            numbers2 = stringArrayToIntArray(numbers1, n);
            numbers4 = stringArrayToIntArray(numbers3, m);

            int[] allNmbs = new int[n + m];

            numbers2.CopyTo(allNmbs, 0);
            numbers4.CopyTo(allNmbs, n);

            Array.Sort(allNmbs);
            Console.WriteLine();

            using (StreamWriter outputFile = new StreamWriter(Path.GetFullPath(@"../../data01.out")))
            {
                foreach (int item in allNmbs)
                {
                    if (item % 2 == 0)
                    {
                        outputFile.WriteLine(item);

                    }
                }

            }


            Console.ReadKey();
        }

        static int[] stringArrayToIntArray(string[] numbersString, int n)
        {
            int[] numbers2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers2[i] = int.Parse(numbersString[i]);
            }

            return numbers2;
        }
    }
}
