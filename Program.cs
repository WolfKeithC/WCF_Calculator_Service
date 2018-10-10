using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Calculator_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost oServiceBase = new ServiceHost(typeof(CalculatorService));
            oServiceBase.Open();

            foreach (var e in oServiceBase.Description.Endpoints)
                Console.WriteLine(e.ListenUri);

            Console.WriteLine("Service Started");
            Console.ReadKey();
            oServiceBase.Close();
        }
    }
}
