using System;

namespace Tema_Laborator_3_Robot_Object
{
    public class Planet
    {
        public static Random rnd = new Random();
        public static string choice;
        public static Target Target;
        public static Robot KillerRobot = new Robot();

        //HERO DMG VARIABLES
        readonly static int MIN_HERO_DMG = 3;
        readonly static int MAX_HERO_DMG = 6;

        //ALIEN DMG VARIABLES
        readonly static int MIN_ALIEN_DMG = 7;
        readonly static int MAX_ALIEN_DMG = 10;

        //ROBOT DMG VARIABLES
        readonly static int MIN_ROBOT_DMG = 8;
        readonly static int MAX_ROBOT_DMG = 12;


        public static void planetSelector()
        {
            switch (choice)
            {
                case "Earth":
                    Target = new Target("Superhero",100, rnd.Next(MIN_HERO_DMG,MAX_HERO_DMG), 3);
                    break;
                case "Mars":
                    Target = new Target("Alien", 100, rnd.Next(MIN_ALIEN_DMG,MAX_ALIEN_DMG), 5);
                    break;
                case "Cybertron":
                    Target = new Target("Giant Friendly Robot", 150, rnd.Next(MIN_ALIEN_DMG, MAX_ROBOT_DMG), 10);
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
