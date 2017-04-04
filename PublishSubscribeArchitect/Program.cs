using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeArchitect
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher dogPublisher = new Publisher();
            Publisher catPublisher = new Publisher();

            Subscriber animalSubscriber = new Subscriber();
            Subscriber catSubscriber = new Subscriber();

            PubSubServer server = new PubSubServer();

            Message dogMessage = new Message
            {
                Topic = "Dogs",
                Detail = "Dogs are best friends"
            };


            Message catMessage = new Message
            {
                Topic = "Cats",
                Detail = "Cats take care of themselves"
            };


            dogPublisher.Send(dogMessage, server);
            catPublisher.Send(catMessage, server);

            animalSubscriber.Listen("Dogs");
            animalSubscriber.Listen("Cats");

            catSubscriber.Listen("Cats");

            server.Subscribers.Add(animalSubscriber);
            server.Subscribers.Add(catSubscriber);

            server.Forward();

            Console.WriteLine("AnimalSubscriber has subscribed to the following messages:");
            animalSubscriber.Print();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("CatSubscriber has subscribed to the following messages:");
            catSubscriber.Print();

            Console.ReadKey();
        }
    }
}
