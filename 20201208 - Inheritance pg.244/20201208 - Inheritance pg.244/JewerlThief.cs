using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201208___Inheritance_pg._244
{
    class JewerlThief:Locksmith
    {
        private Jewels stotlenJewels = null;
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stotlenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stotlenJewels.Sparkle());
        }
    }
}
