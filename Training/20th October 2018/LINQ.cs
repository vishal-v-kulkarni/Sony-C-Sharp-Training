using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "MVC Tutorials",
                "VB.NET",
                "Java"
            };

            //Query Syntax for LINQ
            var result = from s in stringList
                         where s.Contains("Java")
                         select s;

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            //Method Syntax for LINQ
            var result1 = stringList.Where(s => s.Contains("Tutorials"));

            foreach(string s in result1)
            {
                Console.WriteLine(s);
            }

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] even = nums.Where(i => i % 2 == 0).ToArray();

            foreach(int a in even)
            {
                Console.WriteLine(a);
            }
                
          
        }
    }
}
