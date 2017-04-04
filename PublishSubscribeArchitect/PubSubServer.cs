using System.Collections.Generic;

namespace PublishSubscribeArchitect
{
    public class PubSubServer
    {
        public Queue<Message> MSQ = new Queue<Message>();
        public List<Subscriber> Subscribers = new List<Subscriber>();

        public void Forward()
        {
            while (MSQ.Count > 0)
            {
                Message tempMessage = MSQ.Dequeue();
                foreach (Subscriber s in Subscribers)
                {
                    foreach (string t in s.Topics)
                    {
                        if (tempMessage.Topic == t)
                        {
                            s.Messages.Enqueue(tempMessage);
                        }
                    }
                }
            }
        }
    }
}