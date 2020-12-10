using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201208___Inheritance_pg._244
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            JewerlThief jewelThief = new JewerlThief();
            jewelThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
