using System;

namespace Tema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] autori = { "Ion Vasile", "Cotut Raul", "Paul Frez" };
            string[] subiecte = { "masini electrice", "centrale hidraulice", "reducere inflatie" };
            
            int nrRapoarte = 10;
            Raport_Sedinta[] rapoarte = new Raport_Sedinta[nrRapoarte];

            for (int i = 0; i < nrRapoarte; i++)
            {
                rapoarte[i] = new Raport_Sedinta($"Motiv#{i+1}", subiecte, autori);
            }

            //Raport_Sedinta raport1 = new Raport_Sedinta("");
            //Raport_Sedinta raport2 = new Raport_Sedinta("Poluare",subiecte,autori);


            
        }
    }

}
