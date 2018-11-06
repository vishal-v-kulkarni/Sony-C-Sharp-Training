using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Exercise_FileLINQ_TypeOf
{
 
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList(File.ReadAllLines(@"D:\Dotnet\Files\typeof.txt"));
            ArrayList iList = new ArrayList();
            ArrayList fList = new ArrayList();


            foreach (string a in list)
            {
                int.TryParse(a, out int n);
                float.TryParse(a, out float f);
                iList.Add(n);
                fList.Add(f);
            }

            foreach(int i in iList)
            {
                Console.WriteLine(i);
            }

            foreach (float f in fList)
            {
                Console.WriteLine(f);
            }



            var iResult = list.OfType<int>();
            var fResult = list.OfType<float>();
            var sResult = list.OfType<string>();

            Console.Write("Reading Integers : ");
            foreach(var i in iResult)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n\n");

            Console.Write("Reading Floating Numbers : ");
            foreach (var f in fResult)
            {
                Console.Write(f+" ");
            }
            Console.WriteLine("\n\n");

            Console.Write("Reading Strings : ");
            foreach (var s in sResult)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine("\n\n");

        }
    }
}
