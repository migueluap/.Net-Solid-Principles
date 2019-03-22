﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class SendShortMessage : ISenderMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending short message");
        }
    }
}
