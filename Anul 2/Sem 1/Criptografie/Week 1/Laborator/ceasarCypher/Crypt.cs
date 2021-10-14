using System;
using System.Text;

namespace ceasarCypher
{
    public static class Crypt
    {
        
        static string cypherName;
        static Random _random = new Random();

        public static StringBuilder MonoalphabeticCypher()
        {
            StringBuilder result = new StringBuilder();
            cypherName = "MonoalphabeticCypher";
            string text = inputModerator(cypherName);

            char[] characters = text.ToCharArray();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //              MNQDEGWRXUVLPZASIOTKBCFHYJ
            //              Raul = Hmjl
            char[] alphaCopy = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();



            Shuffle<char>(alphaCopy);

            foreach (var item in alphaCopy)
            {
                Console.Write(item);

            }
            Console.WriteLine();

            for (int i = 0; i < characters.Length; i++)
            {
                //Console.WriteLine(characters[i]);
                for (int j = 0; j < alpha.Length; j++)
                {
                    //if ((int)characters[i] >=97)
                    if (char.IsLower(characters[i]))
                    {
                        if (characters[i] == alpha[j])
                        {
                            characters[i] = (char)((int)alphaCopy[j] - 32);
                        }
                    }
                    else
                    {
                        if (characters[i] == alpha[j])
                        {
                            characters[i] = alphaCopy[j];
                        }
                    }
                }
            }

            for (int i = 0; i < characters.Length; i++)
            {
                result.Append(characters[i]);
            }



            Console.WriteLine($"Crypted text: {result}");

            return result;
        }

        public static StringBuilder NCypher()
        {
            StringBuilder result = new StringBuilder();
            cypherName = "NCypher";
            string text = inputModerator(cypherName);
            Console.Write("Write the encryption key: ");
            int cheie = int.Parse(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] + cheie - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] + cheie - 97) % 26 + 97);
                    result.Append(ch);
                }
            }

            Console.WriteLine($"Crypted text: {result}");

            return result;

        }

        public static StringBuilder Decrypt()
        {
            StringBuilder result = new StringBuilder();
            cypherName = "Decypher";
            string text = inputModerator(cypherName);
            Console.Write("Write the encryption key: ");
            int cheie = int.Parse(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] - cheie - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] - cheie - 97) % 26 + 97);
                    result.Append(ch);
                }
            }

            Console.WriteLine($"Decrypted text: {result}");

            return result;

        }

        public static StringBuilder CaesarCypher()
        {

            int cheie = 3;
            StringBuilder result = new StringBuilder();
            cypherName = "Caesar Encryption";

            string text = inputModerator(cypherName);

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] + cheie - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    if (text[i] == ' ')
                    {
                        result.Append(text[i]);
                        continue;
                    }
                    char ch = (char)(((int)text[i] + cheie - 97) % 26 + 97);
                    result.Append(ch);
                }
            }

            Console.WriteLine($"Crypted text: {result}");

            return result;

        }

        private static string inputModerator(string name)
        {
            Console.Clear();
            //Console.WriteLine($"---------/{name}\\---------");
            Console.Write("Enter the text: ");
            string userInput = Console.ReadLine();

            return userInput;
        }

        /*public static void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }*/

        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < (n - 1); i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
    }
}
