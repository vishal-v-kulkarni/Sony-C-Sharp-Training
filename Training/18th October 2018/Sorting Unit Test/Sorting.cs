using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Test
{
    public class Sort
    {
        public static void bubble_sort(int[] array)
        {
            int n = array.Length;
            for (int iCounter = 0; iCounter < n - 1; iCounter++)
                for (int jCounter = 0; jCounter < n - iCounter - 1; jCounter++)
                    if (array[jCounter] > array[jCounter + 1])
                    {
                        
                        int temp = array[jCounter];
                        array[jCounter] = array[jCounter + 1];
                        array[jCounter + 1] = temp;
                    }
         
        }

        public static void selection_sort(int[] array)
        {
            int n = array.Length;

           
            for (int iCounter = 0; iCounter < n - 1; iCounter++)
            {
               
                int min = iCounter;
                for (int jCounter = iCounter + 1; jCounter < n; jCounter++)
                    if (array[jCounter] < array[min])
                        min = jCounter;

           
                int temp = array[min];
                array[min] = array[iCounter];
                array[iCounter] = temp;
            }
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 7, 8, 1, 3, 2 };

            Sort.bubble_sort(array);

            int[] array1 = { 6, 2, 9, 8, 1, 4, 3 };

            Sort.selection_sort(array1);

            Console.WriteLine("Bubble sort : ");

            for(int iCounter = 0; iCounter < array.Length; iCounter++)
            {
                Console.Write(array[iCounter]+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Selection sort : ");

            for (int iCounter = 0; iCounter < array1.Length; iCounter++)
            {
                Console.Write(array1[iCounter] + " ");
            }

        }
    }
}
