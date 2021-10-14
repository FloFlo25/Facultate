using System;
using System.Text;
using static ceasarCypher.Crypt;

namespace ceasarCypher
{
    class Program
    {
        #region Indicatie
        /*1. Cifrul lui Cezar.
        Scrieti un program care implementeaza cifrul lui Cezar.
        Cifrul lui Cezar inlocuieste fiecare litera din textul clar cu a treia litera care urmeaza in alfabet.
        Criptare: "+3"
        Decriptare: "-3". 
        Obs.orice alt caracter diferit de litera ramane nemodificat. 
        se vor implementa operatiile de criptare/decriptare
        
        2. Cifrul "+n"
        Scrieti un program care implementeaza cifrul "+n".
        Cifrul "+n" inlocuieste fiecare litera din textul clar cu a n-a litera care urmeaza in alfabet.
        Criptare: "+n"
        Decriptare: "-n". 
        Obs.orice alt caracter diferit de litera ramane nemodificat. 
        n este un numar natural.
        Spatiul cheilor este format din 26 de chei distincte (0..25)
        se vor implementa operatiile de criptare/decriptare/criptanaliza
        
        Criptanaliza = incercarea de a decripta un mesaj criptat fara a cunoaste cheia folosita la criptare.
        
        Ex.n = 5 
        ABCDEFGHIJKLMNOPQRSTUVXYZ
        FGHIJKLMNOPQRSTUVXYZABCDE
        
        plaintext:  HELLO
        ciphertext: MJQQT
        
        
        CRIPTANALIZA: se da doar textul criptat MJQQT si trebuie gasit plaintextul(fara a cunoaste de la inceput cheia - n).
         
        
        3. Substitutie monoalfabetica.
        Cheia de criptare este o permutare aleatorie a alfabetului
        
        ABCDEFGHIJKLMNOPQRSTUVXYZ
        MIPODSQ................FV
        
        Trebuie implementat: criptare/decriptare/criptanaliza.Criptanaliza se bazeaza pe frecventa de aparitie a literelor intr-o anumita limba.
        Frecventa de aparitie a literelor se pastreaza prin substitutie monoalfabetica. */
        #endregion

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            string menuReturn = "Press any key to return to Menu...";

            Console.Clear();
            Console.WriteLine("Cypher Encrypter - by Floruta Raul");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Caesar Cypher");
            Console.WriteLine("2) 'N' Cypher");
            Console.WriteLine("3) Decrypt");
            Console.WriteLine("4) MonoAlphabetic Cypher");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");


            switch (Console.ReadLine())
            {
                case "1":
                    CaesarCypher();
                    Console.WriteLine(menuReturn);
                    Console.ReadKey();
                    return true;
                case "2":
                    NCypher();
                    Console.WriteLine(menuReturn);
                    Console.ReadKey();
                    return true;
                case "3":
                    Decrypt();
                    Console.WriteLine(menuReturn);
                    Console.ReadKey();
                    return true;
                case "4":
                    MonoalphabeticCypher();
                    Console.WriteLine(menuReturn);
                    Console.ReadKey();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    }
}
