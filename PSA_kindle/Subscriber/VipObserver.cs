using System;

namespace PSA_kindle
{
    public class VipObserver : Observer
    {
        public VipObserver(string observerName) : base(observerName)
        {
        }

        public override void SubscribeNotify(Subject subject)
        {
            Console.WriteLine($"Vip {Name}'s subscribed {subject.Topic}\n");
        }

        public override void ReadArticle(Article article)
        {
            Console.WriteLine($"Vip {Name} is reading {article.Title}: {article.Detail} at {article.Time}\n");
        }
    }
}