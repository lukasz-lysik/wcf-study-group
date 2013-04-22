using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace ConsoleServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(HelloWorldService.HelloWorldService));

            try
            {
                host.Open();
                PrintEndpoints(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                host.Abort();
            }

            Console.ReadLine();
        }

        static void PrintEndpoints(ServiceHost host)
        {
            Console.WriteLine(host.Description.ServiceType);
            Console.WriteLine("--------------------------------------");
            foreach (var se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
