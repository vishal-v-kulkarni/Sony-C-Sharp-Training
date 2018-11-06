using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial1
{

    public class Factorial
    {
        public static int GetFactorial(int number)
        {
            int fact = 1;
            if (number < 0)
                return 0;
            while (number > 0)
            {
                fact = fact * number;
                number--;

            }
            return fact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of " + n + " is " + Factorial.GetFactorial(n));
       
        }
    }
}
