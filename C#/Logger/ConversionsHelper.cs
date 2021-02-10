using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger
{
    public static class ConversionsHelper
    {
        public static string ConvertToBaseAndAlign(byte[] vector, int baseToConvert)
        {
            string data = String.Empty;

            foreach (byte value in vector)
                text += "0x" + Convert.ToString(value, baseToConvert) + " ";

            return data;
        }

        public static string ConvertToBaseAndAlign(short[] vector, int baseToConvert)
        {
            string data = String.Empty;

            foreach (short value in vector)
                text += "0x" + Convert.ToString(value, baseToConvert) + " ";

            return data;
        }
    }
}
