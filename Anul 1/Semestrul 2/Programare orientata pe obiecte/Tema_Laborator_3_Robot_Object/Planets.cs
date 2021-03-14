using System;

namespace Tema_Laborator_3_Robot_Object
{
    public class Planets
    {
        public static string choice;
        public static Target target;
        public static Robots KillerRobot = new Robots();

        public static void planetSelector()
        {
            switch (choice)
            {
                case "Earth":
                    target = new Target("Superhero",100, 5, 3);
                    break;
                case "Mars":
                    target = new Target("Alien", 100, 10, 5);
                    break;
                case "Cybertron":
                    target = new Target("Giant Friendly Robot", 150, 10, 10);
                    break;
                default:
                    break;
            }
        }

        public string getChoice
        {
            get
            {
                return choice;
            }
        }

    }
}
