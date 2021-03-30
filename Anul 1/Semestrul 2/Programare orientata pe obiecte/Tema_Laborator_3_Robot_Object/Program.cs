using System;

namespace Tema_Laborator_3_Robot_Object
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Engine.Welcome();
            Planet.planetSelector();
            Engine.startFight(Planet.Target, Planet.KillerRobot);
            //Engine.showHealth(Planet.target, Planet.KillerRobot);
            //starts the round
            //Engine.statsAndRounds(Planet.Target, Planet.KillerRobot);

            //round repeater
            Engine.repeatRounds(Planet.Target, Planet.KillerRobot);
        }

    }
}
