using System;

namespace ConsoleApp1
{
    class Stack
    {
        int[] values;
        char[] operanzi = { '+', '-', '/', '*' };

        public Stack()
        {
            values = new int[0];
        }

        public string RPN()
        {
            char[] fp;
            Stack st;

            /*((2 + 3) - 4) * 6
                          *
                -                 6
          +           4)
      ((2   3)
            */




            string toReturn;



            return toReturn;
        }

        public void Analisis(char[] expresie)
        {
            for (int i = 0; i < expresie.Length; i++)
            {
                foreach (char operand in operanzi)
                {
                    if (expresie[i] == operand)
                    {

                    }

                }
            }
        }

        public void Push(int ValueToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = ValueToAdd;
            values = temp;
        }

        public int Pop()
        {
            int toReturn = values[values.Length - 1];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
            {
                temp[i] = values[i + 1];
            }
            values = temp;
            return toReturn;
        }

        public void View()
        {
            foreach (int value in values)
            {
                Console.Write(value + " ");
            }
        }
    }
}
