using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class MyClass
    {
        public static bool IsEven(this int i)
        {
            return (i % 2 == 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            if (x.IsEven())
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
