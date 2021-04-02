using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laborator_6
{
    public static partial class Engine
    {

        public static List<Unit> army1 = new List<Unit>();
        public static List<Unit> army2 = new List<Unit>();

        public static Random rnd = new Random();
        public static int resolution_width;
        public static int resolution_height;
        public static System.Drawing.Bitmap bitmap;
        public static System.Drawing.Graphics graphics;
        public static System.Drawing.Color backColor;
        public static System.Windows.Forms.PictureBox display;


        public static void init_demo()
        {
            for (int i = 0; i < 10; i++)
            {
                //soldier
                Unit a = new Unit(10, 15, 100, 10, 15);
                a.setColor(Color.Aquamarine, Color.Black);
                a.setMapLocation(getRndPoint());
                army1.Add(a);
            }

            for (int i = 0; i < 10; i++)
            {
                //ork
                Unit a = new Unit(30, 10, 500, 20, 5);
                a.setColor(Color.Green, Color.Black);
                a.setMapLocation(getRndPoint());
                army2.Add(a);

                //set Unit#4 name=ChiefKeanu
                /*if (i == 4)
                {
                    a.setName("ChiefKeanu");
                }*/
            }
        }

        //check who wins a/b
        public static bool amc2(int a, int b)
        {
            int r = rnd.Next(a + b);
            if (r < a)
                return true;
            return false;
        }



        public static void battle(Unit A, Unit D)//A - attack | B - deffender
        {
            if (amc2(A.Attack, D.Deffense))
            {
                int firePower = A.FirePower;
                int arm = D.Armor;

                while (firePower != 0 && arm != 0)
                {
                    int r = Engine.rnd.Next(2);
                    if (r == 0)
                    {
                        firePower--;
                    }
                    else
                    {
                        arm--;
                    }
                }

                if (firePower != 0)
                {
                    D.HP -= firePower;
                    if (D.HP < 0)
                    {
                        D.Destroyed = true;
                    }
                }
                //else armor is to high
            }
            //else Miss Attack

        }


        public static void battleWave(List<Unit> A, List<Unit> B)
        {
            if (B.Count != 0)
            {
                foreach (Unit attackers in A)
                {
                    int target = rnd.Next(B.Count);

                    battle(attackers, B[target]);
                }

            }



        }

        public static void battleCicle()
        {
            battleWave(army1, army2);
            battleWave(army2, army1);

            army1 = army1.FindAll((delegate (Unit u) { return !u.Destroyed; }));
            army2 = army2.FindAll((delegate (Unit u) { return !u.Destroyed; }));
        }


        public static void init_sesion()
        {
            army1 = new List<Unit>();
        }

        public static void drawMap()
        {
            graph_clear();
            foreach (Unit unit in army1)
            {
                unit.draw(graphics);
            }

            foreach (Unit unit in army2)
            {
                unit.draw(graphics);
            }

            graph_refresh();
        }





        public static void graph_init(System.Windows.Forms.PictureBox T)
        {

            display = T;
            resolution_width = display.Width;
            resolution_height = display.Height;
            backColor = System.Drawing.Color.Gray;
            bitmap = new System.Drawing.Bitmap(resolution_width, resolution_height);
            graphics = System.Drawing.Graphics.FromImage(bitmap);
            graph_clear();
            graph_refresh();
        }

        public static void graph_clear()
        {
            graphics.Clear(backColor);
        }

        public static void graph_refresh()
        {
            display.Image = bitmap;
        }

        public static PointF getRndPoint()
        {
            return new PointF(rnd.Next(resolution_width), rnd.Next(resolution_height));
        }
    }
}
