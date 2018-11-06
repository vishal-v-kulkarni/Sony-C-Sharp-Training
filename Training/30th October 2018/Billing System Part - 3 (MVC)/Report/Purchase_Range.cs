using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem
{
    class Purchase_Range : Sales_Report
    {
        //Property : List of all sales 
        DateTime FromDate;
        DateTime ToDate;

        public void getSalesRange()
        {
            Console.WriteLine("Enter the FROM date : ");
            FromDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the TO date : ");
            ToDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Generated report from "+FromDate+" to "+ToDate);

        }

        public override void generateReport()
        {
            Console.WriteLine("Generated report on quarterly basis");
        }

        public override void renderReport()
        {
            Console.WriteLine("Rendered report based on the range given");
        }



    }
}
