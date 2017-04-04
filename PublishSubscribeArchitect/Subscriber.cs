using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeArchitect
{
    public class Subscriber
    {
        public List<string> Topics = new List<string>();
        public  Queue<Message> Messages  = new Queue<Message>();

        public void Listen(string newTopic)
        {
            Topics.Add(newTopic);
        }

        public void Print()
        {
            for (int i = 0; i < Topics.Count; i++)
            {
                while (Messages.Count > 0)
                {
                    Message newMessage = Messages.Dequeue();
                    Console.WriteLine($"topic: {newMessage.Topic}, detail: {newMessage.Detail}");
                }
            }
        }
    }
}
