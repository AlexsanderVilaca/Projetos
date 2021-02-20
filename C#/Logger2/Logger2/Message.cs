using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger2
{
    class Message
    {
        public string date { get; set; }
        public string message { get; set; }
        public string info { get; set; }

        public Message(string date, string info, string message)
        {
            this.info = info;
            this.date = date;
            this.message = message;
        }
    }
}
