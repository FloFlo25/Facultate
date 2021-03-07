using System;

namespace Initiere_geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double xA, yA, xB, yB, xC, yC;

            Console.Write("xA: ");
            xA = double.Parse(Console.ReadLine());
            Console.Write("yA: ");
            yA = double.Parse(Console.ReadLine());
            Console.Write("xB: ");
            xB = double.Parse(Console.ReadLine());
            Console.Write("yB: ");
            yB = double.Parse(Console.ReadLine());
            Console.Write("xC: ");
            xC = double.Parse(Console.ReadLine());
            Console.Write("yC: ");
            yC = double.Parse(Console.ReadLine());

            showABC(xA, yA, xB, yB, xC, yC);
            ecuatia_drepteiAB(xA, yA, xB, yB);
            lungimea_drepteiAB(xA, yA, xB, yB);
            colinearitate(xA, yA, xB, yB, xC, yC);*/
            drepte_concurente();
        }

        private static void drepte_concurente()
        {
            //Console.Clear();
            double a1, a2, a3, b1, b2, b3, c1, c2, c3;

            Console.Write("a1 = "); a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 = "); b1 = double.Parse(Console.ReadLine());
            Console.Write("c1 = "); c1 = double.Parse(Console.ReadLine());
            Console.Write("a2 = "); a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 = "); b2 = double.Parse(Console.ReadLine());
            Console.Write("c2 = "); c2 = double.Parse(Console.ReadLine());
            Console.Write("a3 = "); a3 = double.Parse(Console.ReadLine());
            Console.Write("b3 = "); b3 = double.Parse(Console.ReadLine());
            Console.Write("c3 = "); c3 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"d1: {a1}x + {b1}y + {c1} = 0");
            Console.WriteLine($"d2: {a2}x + {b2}y + {c2} = 0");
            Console.WriteLine($"d3: {a3}x + {b3}y + {c3} = 0");

            if (a1 * b2 * c3 + a2 * b3 * c1 + b1 * c2 * a3 - c1 * b2 * a3 - b3 * c2 * a1 - b1 * a2 * c3 == 0)
                Console.WriteLine("Dreptele sunt concurente");
            else
                Console.WriteLine("Dreptele NU sunt concurente");
        }

        private static void showABC(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            Console.Clear();
            Console.WriteLine($"A({xA},{yA})");
            Console.WriteLine($"B({xB},{yB})");
            Console.WriteLine($"C({xC},{yC})");
        }

        private static void colinearitate(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            if (xA * yB + xB * yC + xC * yA - xC * yB - xB * yA - xA * yC == 0)
                Console.WriteLine($"ABC sunt coliniare");
            else
                Console.WriteLine($"ABC nu sunt coliniare");
        }

        private static void ecuatia_drepteiAB(double xA, double yA, double xB, double yB)
        {
            
            double coefX, coefY, coefC;
            char semnX = ' ', semnY = '+', semnC = '+';


            coefX = yA - yB;
            coefY = xA - xB;
            coefC = xA * yB - xB * yA;


            if (coefX<0)
            {
                semnX = '-';
            }

            if (coefY > 0)
            {
                semnY = '-';
            }

            if (coefC < 0)
            {
                semnC = '-';
            }

            coefX = coefX < 0 ? -coefX : coefX;
            coefY = coefY < 0 ? -coefY : coefY;
            coefC = coefC < 0 ? -coefC : coefC;



            Console.WriteLine($"AB: {semnX}{coefX}x {semnY}{coefY}y {semnC}{coefC} = 0 ");
            Console.WriteLine();
        }

        private static void lungimea_drepteiAB(double xA, double yA, double xB, double yB)
        {
            double putere1, putere2,putereMinus,distAB;
            double coefX, coefY, coefC;


            coefX = yA - yB;
            coefY = xA - xB;
            coefC = xA * yB - xB * yA;

            putere1 = xB - xA;
            putere2 = yB - yA;
            putereMinus = (putere1*putere1 + putere2*putere2) < 0 ? -(putere1 * putere1 + putere2 * putere2) : (putere1 * putere1 + putere2 * putere2);

            putere1 = putere1 < 0 ? -putere1 : putere1;
            putere2 = putere2 < 0 ? -putere2 : putere2;

            distAB = Math.Sqrt(putereMinus);
            Console.WriteLine($"|AB| = {distAB}");
            Console.WriteLine();
        }
    }
}
