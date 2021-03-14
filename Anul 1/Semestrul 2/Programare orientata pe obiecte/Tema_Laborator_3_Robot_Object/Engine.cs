using System;

namespace Tema_Laborator_3_Robot_Object
{

    public class Engine
    {
        
        /// <summary>
        /// Welcoming starting text
        /// </summary>
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("   ██████╗░░█████╗░██████╗░░█████╗░████████╗  ██╗░░██╗██╗██╗░░░░░██╗░░░░░███████╗██████╗");
            Console.WriteLine("   ██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝  ██║░██╔╝██║██║░░░░░██║░░░░░██╔════╝██╔══██╗");
            Console.WriteLine("   ██████╔╝██║░░██║██████╦╝██║░░██║░░░██║░░░  █████═╝░██║██║░░░░░██║░░░░░█████╗░░██████╔╝");
            Console.WriteLine("   ██╔══██╗██║░░██║██╔══██╗██║░░██║░░░██║░░░  ██╔═██╗░██║██║░░░░░██║░░░░░██╔══╝░░██╔══██╗");
            Console.WriteLine("   ██║░░██║╚█████╔╝██████╦╝╚█████╔╝░░░██║░░░  ██║░╚██╗██║███████╗███████╗███████╗██║░░██║");
            Console.WriteLine("   ╚═╝░░╚═╝░╚════╝░╚═════╝░░╚════╝░░░░╚═╝░░░  ╚═╝░░╚═╝╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello player! Welcome to the newest world destroying simulator of 2021!" +
                "In this simulation you witness the destruction of the mighty ROBOT KILLER");
            Console.WriteLine();
            Console.ResetColor();

            inputSelection();
        }

        /// <summary>
        /// Setting the value of choice for planetSelector parammeter
        /// </summary>
        public static void inputSelection()
        {
            Console.WriteLine("Choose a simulation scenario by selecting the wanted planet on which you want the simulation to happen: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Earth/");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Mars/");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cybertron");
            Console.ResetColor();

            Console.Write("Selection: "); Planets.choice = Console.ReadLine();

            if (!(Planets.choice == "Earth" || Planets.choice == "Mars" || Planets.choice == "Cybertron"))
            {
                Console.WriteLine("Wrong selections.. please try selecting one of the 3 planets");
                Console.ReadKey();
                Console.Clear();
                Welcome();
            }
        }

        public static void startFight(Target target, Robots Killer)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"So it would seam that you chose the scenario happening on the planet {Planets.choice}. \n" +
                $"In this scenario the Giant Killer Robot will fight the fearsome {Planets.target.type} and will try to take down as many as possible. \n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"INSTRUCTIONS: After every event happening you have to press SPACEBAR");
            Console.ResetColor();


        }


        public static void showHealth(Target target, Robots Killer)
        {
            //hp bar killer
            Console.Write($"[|");
            if (Killer.IsAlive)
            {
                for (int i = 0; i < Killer.HP/10; i++)
                {
                    Console.Write("█|");
                }
            }
            Console.WriteLine("]");


            //hp bar target
            Console.Write("                          [|");

            if (target.IsAlive)
            {
                for (int i = 0; i < target.health / 10; i++)
                {
                    Console.Write("█|");
                }
            }
            Console.WriteLine("]");
        }
    }



}
