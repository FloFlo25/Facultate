using System;

namespace ConsoleApplication
{
    class Program
    {
        
        private static void pb1(string s1,ref string s2, out string s3)
        {
            s1 = "Mara are pere";
            s2 = "Ionut a mers la mare";
            s3 = "Darius are o pisica";
        }

        static void Main(string[] args)
        {
            string s1="Mara are mere", s2="Ionut a mers la munte", s3="Darius are un caine";

            pb1(s1,ref s2, out s3);
            Console.WriteLine($"{s1} \n{s2} \n{s3}");
        }

        
    }
}
