using BankService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(ServiceBank)))
            {
                serviceHost.Open();
                foreach (var endPoint in serviceHost.Description.Endpoints)
                    endPoint.EndpointBehaviors.Add(new MyBehavior());
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }
    }
}
