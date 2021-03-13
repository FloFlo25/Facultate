using System;

namespace Tema_Laborator_3_Robot_Object
{

    public class Engine
    {
        public static string choice;
        public static Planets planet;

        /// <summary>
        /// Welcoming starting text
        /// </summary>
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████╗░░█████╗░██████╗░░█████╗░████████╗  ██╗░░██╗██╗██╗░░░░░██╗░░░░░███████╗██████╗");
            Console.WriteLine("██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝  ██║░██╔╝██║██║░░░░░██║░░░░░██╔════╝██╔══██╗");
            Console.WriteLine("██████╔╝██║░░██║██████╦╝██║░░██║░░░██║░░░  █████═╝░██║██║░░░░░██║░░░░░█████╗░░██████╔╝");
            Console.WriteLine("██╔══██╗██║░░██║██╔══██╗██║░░██║░░░██║░░░  ██╔═██╗░██║██║░░░░░██║░░░░░██╔══╝░░██╔══██╗");
            Console.WriteLine("██║░░██║╚█████╔╝██████╦╝╚█████╔╝░░░██║░░░  ██║░╚██╗██║███████╗███████╗███████╗██║░░██║");
            Console.WriteLine("╚═╝░░╚═╝░╚════╝░╚═════╝░░╚════╝░░░░╚═╝░░░  ╚═╝░░╚═╝╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello player! Welcome to the newest world destroying simulator of 2021!" +
                "In this simulation you witness the destruction of the mighty ROBOT KILLER");
            Console.WriteLine();
            Console.ResetColor();
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

            Console.Write("Selection: "); choice = Console.ReadLine();

            if (!(choice == "Earth" || choice == "Mars" || choice == "Cybertron"))
            {
                Console.WriteLine("Wrong selections.. please try selecting one of the 3 planets");
                Console.ReadKey();
                inputSelection();
            }
        }

        /// <summary>
        /// A switch_case function that is connected with Selection()
        /// </summary>
        /// <param name="choice"></param>
        public static void planetSelector(string choice)
        {

            switch (choice)
            {
                case "Earth":
                    planet = Planets.Earth;
                    break;
                case "Mars":
                    planet = Planets.Mars;
                    break;
                case "Cybertron":
                    planet = Planets.Cybertron;
                    break;
                default:
                    break;
            }
        }
    }



}
