using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class MyArray<T>
    {
        T[] arr = new T[10];
        
        public MyArray(T ini)
        {
            int i = 0;
            while (i < 10)
            {
                arr[i++] = ini;
            }
        }
    }
    class Program
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            MyArray<int> ma = new MyArray<int>(5);
            int x = 20, y = 50;
            Swap(ref x, ref y); //Implicit typecast
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
