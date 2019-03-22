using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class SenderMessage
    {
        private ISenderMessage _senderMessage;

        public SenderMessage(ISenderMessage senderMessage)
        {
            this._senderMessage = senderMessage;
        }

        public void SendMessage(string message)
        {
            this._senderMessage.SendMessage(message);
        }
    }
}
