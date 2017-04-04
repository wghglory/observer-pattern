using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSA
{
    class Program
    {
        static void Main(string[] args)
        {
   
            ConcreteSubject travelSubject = new ConcreteSubject();
            travelSubject.Topic = "Travel";

            var observer1 = new ConcreteObserver(travelSubject, "Mike");
            var observer2 = new ConcreteObserver(travelSubject, "John");

            travelSubject.Attach(observer1);
            travelSubject.Attach(observer2);



            ConcreteSubject movieSubject = new ConcreteSubject();
            movieSubject.Topic = "Moive";

            var observer3 = new ConcreteObserver(movieSubject, "Derek");

            movieSubject.Attach(observer3);

         
            travelSubject.Notify();
            movieSubject.Notify();

            Console.ReadKey();
        }
    }
}
