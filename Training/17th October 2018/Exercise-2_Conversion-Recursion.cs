using System;

namespace Exercise_2_Convert_Recursion
{

    class Radix
    {
        public static void DisplayInBase(int iNum,int base1)
        {
            int tmp = 0;
            if (iNum > 0)
            {
                tmp = iNum % base1;
                DisplayInBase(iNum / base1, base1);
            }
            else
                return;
            Console.Write(Convert.ToChar((tmp < 10) ? tmp + 48 : tmp + 55));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, b = 0 ;

           

            try
            {
                n = Convert.ToInt32(args[0]);
                b = Convert.ToInt32(args[1]);
                Radix.DisplayInBase(n,b);
                Console.WriteLine();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("No arguments passed");
            }
        }
    }
}
