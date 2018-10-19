using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2_Convert
{
    class Convert
    {

        public string Converter(int iNum, int base1)
        {
            string sconv = "";

            while (iNum > 0)
            {
                if(iNum%base1 == 10)
                {
                    sconv = sconv + "A";
                }else if(iNum % base1 == 11)
                {
                    sconv = sconv + "B";
                }else if (iNum % base1 == 12)
                {
                    sconv = sconv + "C";
                }else if (iNum % base1 == 13)
                {
                    sconv = sconv + "D";
                }else if (iNum % base1 == 14)
                {
                    sconv = sconv + "E";
                }
                else if (iNum % base1 == 15)
                {
                    sconv = sconv + "F";
                }
                else
                {
                    sconv = sconv + iNum % base1;
                }
                
                iNum = iNum / base1;
            }

            char[] charArray = sconv.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public void convertToBinary(int iNum)
        {
            string numArray = Converter(iNum, 2);

            Console.WriteLine("Binary : " + numArray);

        }

        public void convertToOctal(int iNum)
        {

            string numArray = Converter(iNum, 8);

            Console.WriteLine("Octal : "+numArray);

        }

        public void convertToHex(int iNum)
        {

            string numArray = Converter(iNum, 16);

            Console.WriteLine("Hex : "+numArray);

        }


    }


    class MainClass
    {
        public static void Main(String[] args)
        {

           // Console.WriteLine("Enter the number to be converted : ");

            //int iNum = int.Parse(Console.ReadLine());
            Convert convert = new Convert();

            convert.convertToBinary(int.Parse(args[0]));
            Console.WriteLine();

            convert.convertToOctal(int.Parse(args[0]));
            Console.WriteLine();

            convert.convertToHex(int.Parse(args[0]));
            Console.WriteLine();

        }


    }
}
