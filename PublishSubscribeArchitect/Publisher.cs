using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeArchitect
{
    public class Publisher
    {
        public void Send(Message newMessage, PubSubServer server)
        {
            server.MSQ.Enqueue(newMessage);
        }
    }
}
