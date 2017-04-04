using System;

namespace PSA_kindle
{
    public class RegularObserver : Observer
    {
        public RegularObserver(string observerName) : base(observerName)
        {
        }

        public override void SubscribeNotify(Subject subject)
        {
            Console.WriteLine($"RegularUser {Name}'s subscribed {subject.Topic}\n");
        }
        public override void ReadArticle(Article article)
        {
            Console.WriteLine($"RegularUser {Name} is reading {article.Title}: {article.Detail} at {article.Time}");
        }
    }
}