using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNOW_Reporting_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceNowReporting.SNOWReportingLibraryClient snow = new ServiceNowReporting.SNOWReportingLibraryClient();

            string result = snow.GetStatus();
            var result01 = snow.GetApplicationList("SOS");

            Console.WriteLine(result + Environment.NewLine + result01.Count());

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
