using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    public enum Targets
    {
        Superhero,
        GiantFriendlyRobot,
        Alien
    }

    public class _Target
    {
        private int health;
        private int dmg;
        private int armor;

        private bool isTargeted;
        private bool isAlive;

    }
}
