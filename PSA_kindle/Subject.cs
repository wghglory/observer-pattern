using System;
using System.Collections.Generic;

namespace PSA_kindle
{
    public abstract class Subject
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        protected readonly List<Article> ArticleRepo = new List<Article>();  //keep old articles

        protected readonly Queue<Article> ArticleQueue = new Queue<Article>(); //new article added, then dequeue

        private readonly List<Observer> _observers = new List<Observer>();

        public void SubscribeUser(Observer observer)
        {
            _observers.Add(observer);
        }

        public void UnsubscribeUser(Observer observer)
        {
            _observers.Remove(observer);
        }

        //notify subscription sucessfully
        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.SubscribeNotify(this);
            }
        }

        //auto push new article to user who subscribe relative subject
        public virtual void AddArticle(Article article)
        {
            if (this.GetType() == article.Subject.GetType())
            {
                ArticleRepo.Add(article);
                ArticleQueue.Enqueue(article);
                PushArticle();
            }
            else
            {
                WrongArticle(article);
            }
        }


        //push new article to subscribe user
        protected void PushArticle()
        {
            Article art = ArticleQueue.Dequeue();

            foreach (Observer o in _observers)
            {
                //foreach (var art in ArticleRepo)
                //{
                //    if (!art.HasRead)
                //    {
                //        o.ReadArticle(art);
                //    }
                //    art.HasRead = true;
                //}

                o.ReadArticle(art);
            }
        }

        protected void WrongArticle(Article article)
        {
            Console.WriteLine($"{article.Title} doesn't belong to {this.Topic} channel...");
        }
    }

}
