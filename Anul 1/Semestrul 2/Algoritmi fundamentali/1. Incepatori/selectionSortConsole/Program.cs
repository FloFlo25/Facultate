using System;

namespace selectionSortConsole
{
    class Program
    {
        public static int[] arr = new int[] { 23, 23, 5, 123, 6, 1, 124, 14, 12, 31, 5124, 5 };
        //public static int n = arr.Length;

        static void Main(string[] args)
        {
            int[] arr = { 23, 23, 5, 123, 6, 1, 124, 14, 12, 31, 5124, 5 };

            printArr(arr);

            SelectionSort(arr);
            Console.WriteLine("Sorted array");
            printArr(arr);

        }

        public static void Swap(int a, int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        static void printArr(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int min_index;

            for (int i = 0; i < n - 1; i++)
            {
                min_index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }
                //Swap(arr[min_index], arr[i]);

                int aux = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = aux;
            }


        }
    }
}
