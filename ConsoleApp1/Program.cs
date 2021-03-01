using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    class Program
    {

        public static void PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            pinger = new Ping();
            bool x = true;
            while (x == true)
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
                if (pingable == true)
                {
                    Console.WriteLine(nameOrAddress + " is replying");
                }
                else
                {
                    Console.WriteLine(nameOrAddress + " is not replying");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PingHost("192.168.1.24");
        }
    }
}
