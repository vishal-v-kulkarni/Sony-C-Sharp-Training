using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Sort_Generics
{
    class Sort
    {
        public static List<T> sort<T>(T[] array)
        {
            List<T> list = array.OfType<T>().ToList();

            list.Sort();

            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = { 6, 5, 7, 4, 8, 3, 9, 2, 0, 1 };
            float[] fArray = { 6.2f, 5.3f, 6.1f, 4.5f, 8.1f, 6.3f, 9.1f, 2.2f, 0, 1 };
            string[] sArray = { "mango", "apple", "pineapple", "grapes" };

            List<int> iList = Sort.sort(iArray);
            List<float> fList = Sort.sort(fArray);
            List<string> sList = Sort.sort(sArray);

            Console.Write("Sorted integers : ");
            foreach(var i in iList)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n\n");

            Console.Write("Sorted floating numbers : ");
            foreach (var f in fList)
            {
                Console.Write(f+" ");
            }
            Console.WriteLine("\n\n");

            Console.Write("Sorted strings : ");
            foreach (var s in sList)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
