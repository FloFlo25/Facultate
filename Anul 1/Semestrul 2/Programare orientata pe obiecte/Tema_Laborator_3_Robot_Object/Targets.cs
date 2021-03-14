using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    public class Target
    {
        public int health;
        public int dmg;
        public int armor;
        public string type;

        private bool isTargeted;
        private bool isAlive = true;

        public bool IsAlive
        { 
            get
            {
                return isAlive;
            }
            set
            {
                isAlive = value;
            }
        }

        public Target(string TYPE, int HEALTH,int DAMAGE,int ARMOR)
        {
            health = HEALTH;
            dmg = DAMAGE;
            armor = ARMOR;
            type = TYPE;
            
            //TODO WHY IT DOESN'T WORK???
            //Console.WriteLine($"Target instantiated: HP = {Planets.tinta.health} Armour = {Planets.tinta.armor} DMG = {Planets.tinta.dmg}*");
            
        }
    }
}
