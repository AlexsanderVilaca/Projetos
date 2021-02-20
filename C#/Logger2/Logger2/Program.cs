using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger a = new Logger();
            a.SetConfigFile(@"C:\Documents and Settings\Administrator\My Documents\config.xml");
            a.MessageBuilder("teste modbus", "teste");
            Console.ReadKey();
        }
    }
}
