using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_Duplicate_Files
{
    class Program
    {
        static bool FileDuplicate(string path1, string path2)
        {
            if(path1 == path2)
            {
                return false;
            }
           
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            string[] array = Directory.GetFiles(@"D:\Dotnet\Files");

            foreach(string a in array)
            {
               foreach(string b in array)
                {
                    //Console.WriteLine(a, b);
                    if (FileDuplicate(a,b))
                    {
                        Console.WriteLine("{0} and {1} are duplicate files",a,b);
                    }
                }
            }
            

        }
    }
}
