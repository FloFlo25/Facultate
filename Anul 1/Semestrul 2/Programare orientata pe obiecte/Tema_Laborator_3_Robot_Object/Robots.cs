using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Tema_Laborator_3_Robot_Object
{
    public class Robots
    {
        private int hp = 150;
        private int dmg = 10;
        private int armor = 5;
        private int laserIntensity=0;
        private bool isAlive = true;

        public Robots()
        {
        }

        public bool IsAlive 
        {
            get
            {
                return isAlive;
            }
            
        }

        public int HP 
        {
            get
            {
                return hp;
            }

            set 
            {
            } 
        }
    }
}
