using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Selection_sort
{
    public class Engine
    {
        public static List<int> numbers = new List<int>();
        



        static void printArr(int[] arr)
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

                int aux = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = aux;
            }


        }
    }
}
