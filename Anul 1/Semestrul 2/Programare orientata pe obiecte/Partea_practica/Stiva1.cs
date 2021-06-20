using System;
using System.Collections.Generic;

namespace Partea_practica

{
    class StivaFixa : IStack
    {
        static readonly int MAX = 100;
        int top;


        public int Capacity
        {
            get
            {
                return Count;
            }
            set
            {

            }
        }
        public int Count { get; set; }

        public int[] Stack = new int[MAX];


        public StivaFixa()
        {
            top = -1;
            Count = 0;
        }

        public int Peek()
        {

            try
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
                Console.ReadKey();
            }
            catch (StackOverflowException ex)
            {

                throw new ArgumentException("Nu sunt elemente in stiva!", nameof(top), ex);
            }



            /*if (top < 0)
            {
                Console.WriteLine("Stack Overflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
            }*/
        }

        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = Stack[top--];
            }
        }

        public void Push(int item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Stack[++top] = item;
                Count++;
            }
        }

        public void Alice(string structuraInitiala)
        {
            //  /u/love\i\  --->  /uevoli\  --->  iloveu

            char[] litereStruct = structuraInitiala.ToCharArray();

            bool foundStart = false;
            bool foundStartFlag = false;
            bool foundEnd = false;

            int nrChar = litereStruct.Length;
            char[] containing = new char[nrChar];
            int poz = 0;
            int poz2 = 0;

            while (nrChar > 0)
            {
                if (litereStruct[poz] == '/')
                {
                    foundStart = true;
                }

                if (foundStart == true)
                {
                    containing[poz2] = litereStruct[poz];
                    poz2++;
                    Array.Clear(containing)
                }

                poz++;
            }


            for (int i = 0; i < litereStruct.Length; i++)
            {
                Console.WriteLine(litereStruct[i]);
            }
        }
    }

    class StivaRedimensionabila : IStack
    {
        static readonly int MAX = 100;
        int top;
        public int Capacity { get; set; }
        public int Count { get; set; }

        public int[] Stack = new int[MAX];


        public StivaRedimensionabila()
        {
            top = -1;
            Count = 0;
        }

        public int Peek()
        {

            try
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
            }
            catch (StackOverflowException ex)
            {

                throw new ArgumentException("Nu sunt elemente in stiva!", nameof(top), ex);
            }



            /*if (top < 0)
            {
                Console.WriteLine("Stack Overflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
            }*/
        }

        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = Stack[top--];
            }
        }

        public void Push(int item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Stack[++top] = item;
                Count++;
            }
        }
    }

    class StivaList<T> : IStack
    {
        static readonly int MAX = 100;
        int top;
        List<T> lista = new List<T>();

        public int Capacity
        {
            get
            {
                return Count;
            }
            set
            {

            }
        }
        public int Count { get; set; }

        public int[] Stack = new int[MAX];


        public StivaList()
        {
            top = -1;
            Count = 0;
        }

        public int Peek()
        {

            try
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
                Console.ReadKey();
            }
            catch (StackOverflowException ex)
            {

                throw new ArgumentException("Nu sunt elemente in stiva!", nameof(top), ex);
            }



            /*if (top < 0)
            {
                Console.WriteLine("Stack Overflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Elementul din varful stivei este {Stack[top]}");
                return Stack[top];
            }*/
        }

        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = Stack[top--];
            }
        }

        public void Push(int item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Stack[++top] = item;
                Count++;
            }
        }
    }

    class Stiva3<T> : IStack
    {
        public int Capacity { get ; set; }
        public int Count { get; set; }
        List<T> lista = new List<T>();


        public Stiva3()
        {
            Count = 0;
        }


        public T Peek()
        {
            return lista[lista.Count - 1];
        }

        public void Pop()
        {
            lista.Remove(lista[lista.Count - 1]);
        }

        public void Push(T item)
        {
            lista.Add(item);
        }
    }
}
