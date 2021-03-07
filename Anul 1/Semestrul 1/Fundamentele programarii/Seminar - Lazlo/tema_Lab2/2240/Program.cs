using System;

namespace _2240
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaini, pisici, caini;

            caini = int.Parse(Console.ReadLine());

            pisici = 2 * caini;
            gaini = 2 * pisici;

            Console.WriteLine(caini + pisici + gaini);
        }
    }
}
