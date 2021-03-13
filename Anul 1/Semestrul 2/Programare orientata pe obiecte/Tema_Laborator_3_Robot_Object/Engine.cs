using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    
    public class Engine
    {
        public static string choice;
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
        public static void Selection()
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
                Selection();
            }
        }


        public static void planetSelector(string choice)
        {
            switch (choice)
            {
                case "Earth":
                    Planets.Earth();
                    break;
                case "Mars":
                    Planets.Mars();
                    break;
                case "Cybertron":
                    Planets.Cybertron();
                    break;
                default:
                    break;
            }
        }
    }


    
}
