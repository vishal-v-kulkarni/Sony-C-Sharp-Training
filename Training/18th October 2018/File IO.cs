using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stints = new FileStream(@"D:\ints.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream stsquare = new FileStream(@"D:\stsquare.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int iCounter = 0; iCounter < 10; iCounter++)
            {
                stints.WriteByte((byte)(iCounter));
            }

            stints.Seek(0, SeekOrigin.Begin);


            byte[] ints = new byte[stints.Length];
            stints.Read(ints, 0, ints.Length);

            foreach(byte b in ints)
            {
                stsquare.WriteByte((byte)(b * b));

            }

            stsquare.Seek(0, SeekOrigin.Begin);

            byte[] by = new byte[stsquare.Length];
            stsquare.Read(by, 0, by.Length);

            foreach (byte b in by)
            {
                Console.WriteLine(b);

            }

            stints.Close();
            stsquare.Close();



        }
    }
}
