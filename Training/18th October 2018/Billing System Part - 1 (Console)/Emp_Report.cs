using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem
{
    class Emp_Report : Report
    {
        int eid;
        
        public override void generateReport(Sales_DB saleList)
        {
            Console.Write("Enter the Employee ID : ");
            eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Generated Employee Report");
        }

        public override void renderReport()
        {
            Console.WriteLine("Rendered Employee report into a Text File");
        }
    }
}
