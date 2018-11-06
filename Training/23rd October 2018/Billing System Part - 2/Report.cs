using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem
{

    abstract public class Report
    {
        List<Report_Entry> reportList = new List<Report_Entry>();

        public abstract void generateReport();
 
        public abstract void renderReport();
    }
}
