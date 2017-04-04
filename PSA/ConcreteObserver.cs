using System;

namespace PSA
{
    public class ConcreteObserver : Observer
    {
        private string _observerName;
        private string _topic;
        private ConcreteSubject _subject;

        // Constructor
        public ConcreteObserver(ConcreteSubject subject, string observerName)
        {
            this._subject = subject;
            this._observerName = observerName;
        }

        public override void Update()
        {
            _topic = _subject.Topic;
            Console.WriteLine($"Observer {_observerName}'s subscribed {_topic}");
        }

    }
}