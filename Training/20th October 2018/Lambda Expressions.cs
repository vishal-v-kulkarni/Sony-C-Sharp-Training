using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        delegate void tDel(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            //Original Delegate syntax
            tDel tdel1 = new tDel(M);

            //Anonymous function
            tDel tdel2 = delegate (string s) { Console.WriteLine(s); };

            //Lambda Expression =>

            tDel tdel3 = (x) => { Console.WriteLine(x); };

            tdel1("Hello");
            tdel2("Hi");
            tdel3("Bye");


        }
    }
}
