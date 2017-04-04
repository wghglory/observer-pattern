using System;

namespace PSA_kindle
{
    public abstract class Observer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public abstract void SubscribeNotify(Subject subject);
        //public abstract void ReadArticle(Article article);

        protected Observer(string observerName)
        {
            Name = observerName;
        }

        public virtual void SubscribeNotify(Subject subject)
        {
            Console.WriteLine($"Observer {Name}'s subscribed {subject.Topic}\n");
        }

        public virtual void ReadArticle(Article article)
        {
            Console.WriteLine($"Observer {Name} is reading {article.Title}: {article.Detail}\n");
        }
    }
}