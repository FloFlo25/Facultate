using System;

namespace Tema_Laborator_3_Robot_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantFriendlyRobot goodBot = new GiantFriendlyRobot();
            GiantKillerRobot badBot = new GiantKillerRobot();
            

            #region Variables


            #endregion

            
            //TODO make an enum of Targets {Aliens, Humans, GiantFriendlyRobot, Superheroes}


            Wellcome();

            
        }

        

        private static void Wellcome()
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
            Console.WriteLine("Hello player! Wellcome to the newest world destroying simulator of 2021!" +
                "In this simulation you witness the destruction of the mighty ROBOT KILLER");

            Console.ResetColor();
        }
    }
}
