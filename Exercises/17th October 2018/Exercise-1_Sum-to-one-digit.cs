using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number  : ");
            int iNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            

            while(iNumber > 0 || sum > 9)
            {
                if( iNumber == 0)
                {
                    iNumber = sum;
                    sum = 0;
                }
                sum = sum + iNumber % 10;
                iNumber = iNumber / 10;
            }

            Console.WriteLine(sum);

        }
    }
}
