using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021__EXP_MAP_Floruta_Raul_03_
{
    public class Stack<T> : IEnumerable
    {
        private T[] values;

        public int Count { get; internal set; }

        public T this[int i]
        {
            get
            {
                return values[i];
            }
            set
            {
                values[i] = value;
            }
        }

        public Stack()
        {
            values = new T[0];
            Count = 0;
        }

        public void Push(T ValueToAdd)
        {
            T[] temp = new T[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
                temp[i + 1] = values[i];
            temp[0] = ValueToAdd;
            values = temp;
            Count++;
        }

        public T Pop()
        {
            T toReturn = values[0];
            T[] temp = new T[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
                temp[i] = values[i + 1];
            values = temp;
            Count--;
            return toReturn;
        }

        public void view()
        {
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i] + " ");
        }

        public IEnumerator GetEnumerator()
        {
            return values.GetEnumerator();
        }

        internal T Peek()
        {
            return values[0];
        }
    }
}
