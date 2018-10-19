using System;

namespace Delegate
{
    class Program
    {
        delegate int Mathop(int x, int y);
        static void Main(string[] args)
        {
            Mathop mop = Sub;
            mop += Add;
            mop += Mul;
            int res = mop(5, 6);
            Console.WriteLine("Calling the mop function : res = " + res);

        }

        static int Add(int x,int y)
        {
            int res = x + y;
            Console.WriteLine("Calling Add Function : res = " + res);
            return res;
        }

        static int Sub(int x, int y)
        {
            int res = x - y;
            Console.WriteLine("Calling Sub Function : res = " + res);
            return res;
        }

        static int Mul(int x, int y)
        {
            int res = x * y;
            Console.WriteLine("Calling Mul Function : res = " + res);
            return res;
        }
    }
}
