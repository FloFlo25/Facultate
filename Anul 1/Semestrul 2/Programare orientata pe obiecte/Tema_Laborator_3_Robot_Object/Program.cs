using System;

namespace Tema_Laborator_3_Robot_Object
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Engine.Welcome();
            Planets.planetSelector();
            Engine.startFight(Planets.target, Planets.KillerRobot);
            Engine.showHealth(Planets.target, Planets.KillerRobot);
        }

    }
}
