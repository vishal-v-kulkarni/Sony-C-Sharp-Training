using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem
{
    partial class Bill : Sales_Report
    {
        
        public override void generateReport()
        {
            Console.WriteLine("Generated report for a single purchase");
        }
        public override void renderReport()
        {
            Console.WriteLine("Rendered report for a single purchase into a HTML file");
        }
    }
}
