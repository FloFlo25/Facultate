using System;

namespace Curs_Seminar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, z1, z2, x3, y3, z3;
            Console.Write("x1 = "); x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = "); y1 = int.Parse(Console.ReadLine());
            Console.Write("z1 = "); z1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = "); x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = "); y2 = int.Parse(Console.ReadLine());
            Console.Write("z2 = "); z2 = int.Parse(Console.ReadLine());
            Console.Write("x3 = "); x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 = "); y3 = int.Parse(Console.ReadLine());
            Console.Write("z3 = "); z3 = int.Parse(Console.ReadLine());
            Console.Clear();

            afisareVector(x1, x2, y1, y2, z1, z2, x3, y3, z3);
            Console.WriteLine();
            /*Console.WriteLine();
            produsScalar(x1, y1, z1, x2, y2, z2);
            Console.WriteLine();
            perpedincularitate(x1, y1, z1, x2, y2, z2);
            Console.WriteLine();
            marime_vectori(x1, y1, z1, x2, y2, z2);
            Console.WriteLine();*/
            //produsVectorialColin(x1, y1, z1, x2, y2, z2);
            produsMixt(x1, x2, y1, y2, z1, z2, x3, y3, z3);
            Console.WriteLine();
        }

        private static void afisareVector(int x1, int x2, int y1, int y2, int z1, int z2, int x3, int y3, int z3)
        {
            char v1Semn1, v1Semn2, v1Semn3;
            char v2Semn1, v2Semn2, v2Semn3;
            char v3Semn1, v3Semn2, v3Semn3;

            v1Semn1 = x1 >= 0 ? ' ' : ' ';
            v1Semn2 = y1 >= 0 ? '+' : ' ';
            v1Semn3 = z1 >= 0 ? '+' : ' ';

            v2Semn1 = x2 >= 0 ? ' ' : ' ';
            v2Semn2 = y2 >= 0 ? '+' : ' ';
            v2Semn3 = z2 >= 0 ? '+' : ' ';

            v3Semn1 = x3 >= 0 ? ' ' : ' ';
            v3Semn2 = y3 >= 0 ? '+' : ' ';
            v3Semn3 = z3 >= 0 ? '+' : ' ';

            Console.WriteLine($"v1 = {v1Semn1}{x1}i{v1Semn2}{y1}j{v1Semn3}{z1}k");
            Console.WriteLine($"v2 = {v2Semn1}{x2}i{v2Semn2}{y2}j{v2Semn3}{z2}k");
            Console.WriteLine($"v3 = {v3Semn1}{x3}i{v3Semn2}{y3}j{v3Semn3}{z3}k");
        }

        private static void produsMixt(int x1, int x2, int y1, int y2, int z1, int z2, int x3, int y3, int z3)
        {
            int prodMix = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 - x3 * y2 * z1 - x1 * y3 * z2 - x2 * y1 * z3;
            Console.WriteLine($"Produsul mixt al vectorilor este {prodMix}");
            Console.WriteLine();

            if (prodMix == 0)
                Console.WriteLine("Vectorii sunt coplanari");
            else
                Console.WriteLine("Vectorii NU sunt coplanari");
            Console.WriteLine();

            Console.WriteLine($"Volumul paralelogramului este {Math.Abs(prodMix)}");
        }

        private static void produsVectorialColin(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            int prodScal1 = y1 * z2 - y2 * z1;
            int prodScal2 = x2 * z1 - x1 * z2;
            int prodScal3 = x1 * y2 - x2 * y1;
            char semn2 = ' ', semn3 = ' ';


            if (prodScal2 > 0)
                semn2 = '+';
            if (prodScal3 > 0)
                semn3 = '+';

            Console.WriteLine($"Produsul vectorial: {prodScal1}i{semn2}{prodScal2}j{semn3}{prodScal3}k");
            Console.WriteLine();

            if (prodScal1 == 0 && prodScal2 == 0 && prodScal3 == 0)
                Console.WriteLine("Vectorii sunt colineari");
            else
                Console.WriteLine("Vectorii NU sunt colineari");
            Console.WriteLine();

            if (prodScal1 < 0)
                prodScal1 = -prodScal1;
            if (prodScal2 < 0)
                prodScal2 = -prodScal2;
            if (prodScal3 < 0)
                prodScal3 = -prodScal3;
            double arie = Math.Sqrt(prodScal1 * prodScal1 + prodScal2 * prodScal2 + prodScal3 * prodScal3);

            Console.WriteLine($"Aria paralelogramului este {arie}");
        }

        private static void perpedincularitate(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            if (x1 * x2 + y1 * y2 + z1 * z2 == 0)
                Console.WriteLine("Vectorii sunt perpendiculari");
            else
                Console.WriteLine("Vectorii NU sunt perpendiculari");
        }

        private static void produsScalar(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Console.WriteLine($"Produsul scalar: {x1 * x2 + y1 * y2 + z1 * z2}");
        }

        private static void afisareVector(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            char v1Semn1, v1Semn2, v1Semn3;
            char v2Semn1, v2Semn2, v2Semn3;

            v1Semn1 = x1 >= 0 ? ' ' : ' ';
            v1Semn2 = y1 >= 0 ? '+' : ' ';
            v1Semn3 = z1 >= 0 ? '+' : ' ';

            v2Semn1 = x2 >= 0 ? ' ' : ' ';
            v2Semn2 = y2 >= 0 ? '+' : ' ';
            v2Semn3 = z2 >= 0 ? '+' : ' ';

            Console.WriteLine($"v1 = {v1Semn1}{x1}i{v1Semn2}{y1}j{v1Semn3}{z1}k");
            Console.WriteLine($"v2 = {v2Semn1}{x2}i{v2Semn2}{y2}j{v2Semn3}{z2}k");
        }

        private static void marime_vectori(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double marimeV1, marimeV2;
            marimeV1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            marimeV2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);

            Console.WriteLine($"Marimea vectorului 1: {marimeV1}");
            Console.WriteLine($"Marimea vectorului 2: {marimeV2}");
        }

    }
}
