using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PerformanceCounter cpuCounter = new PerformanceCounter();
                cpuCounter.CategoryName = "Processor";
                cpuCounter.CounterName = "% Processor Time";
                cpuCounter.InstanceName = "_Total";
                PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

                var unused = cpuCounter.NextValue(); // first call will always return 0
                System.Threading.Thread.Sleep(1000); // wait a second, then try again
                Console.WriteLine("Cpu usage: " + cpuCounter.NextValue() + "%");
                Console.WriteLine("Free ram : " + ramCounter.NextValue() + "MB");
            }

            Console.ReadKey();
        }
    }
}
