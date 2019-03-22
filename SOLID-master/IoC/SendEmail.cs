using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class SendEmail : ISenderMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending e-mail");
        }
    }
}
