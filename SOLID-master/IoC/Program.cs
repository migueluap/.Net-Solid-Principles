using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var senderSMS = new SendShortMessage();

            var senderMessage = new SenderMessage(senderSMS);

            senderMessage.SendMessage("some message to send");
            Console.Read();
             
        }
    }
}
