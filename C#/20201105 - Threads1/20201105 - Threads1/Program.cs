using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace _20201105___Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Thread thread1 = new Thread(mostraThread1);
            Thread thread2 = new Thread(mostraThread2);
            Thread thread3 = new Thread(mostraThread3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            for (int i = 0; i < 3; i++) Console.WriteLine("Thread Principal");
            System.Threading.Thread.Sleep(200);
            
            Console.ReadKey();

        }

        static void mostraThread1()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine("1");
            System.Threading.Thread.Sleep(200);
        }

        static void mostraThread2()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine("2");
            System.Threading.Thread.Sleep(200);
        }

        static void mostraThread3()
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine("3");
            System.Threading.Thread.Sleep(200);
        }
    }
}
