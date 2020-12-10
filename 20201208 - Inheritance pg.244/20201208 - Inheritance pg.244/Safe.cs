using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201208___Inheritance_pg._244
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            else
                return null;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
