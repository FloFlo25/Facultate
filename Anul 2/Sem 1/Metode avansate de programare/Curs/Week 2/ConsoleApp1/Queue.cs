using System;

namespace ConsoleApp1
{
    class Queue
    {
        int[] values;

        public Queue()
        {
            values = new int[0];
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
                temp[i] = values[i];
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
