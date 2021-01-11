using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---WCF Host---");

            using(var host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine("Service started");
                WriteInfo(host);
                Console.ReadLine();
            }
        }

        public static void WriteServiceWorkInfo(string info) =>
            Console.WriteLine($"------\n{info}");

        static void WriteInfo(ServiceHost host)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("*INFO*");
            Console.WriteLine($"Name : {host.Description.ConfigurationName}");
            Console.WriteLine($"Port : {host.BaseAddresses[0].Port}");
            Console.WriteLine($"LocalPath : {host.BaseAddresses[0].LocalPath}");
            Console.WriteLine($"Uri : {host.BaseAddresses[0].AbsoluteUri}");
            Console.WriteLine($"Scheme : {host.BaseAddresses[0].Scheme}");
            Console.WriteLine("******");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
