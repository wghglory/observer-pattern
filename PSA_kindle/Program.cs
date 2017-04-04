using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PSA_kindle
{
    class Program
    {
        static void Main(string[] args)
        {
            //subjects
            Subject newsPublisher = new NewsChannel();
            newsPublisher.Topic = "News";

            Subject sportPublisher = new SportChannel();
            sportPublisher.Topic = "Sport";

            Subject moviePublisher = new MovieChannel();
            moviePublisher.Topic = "Movie";

            //observers
            Observer vip = new VipObserver("Derek");
            Observer regularUser = new RegularObserver("Summer");

            //observer subscribe subjects
            newsPublisher.SubscribeUser(vip);
            sportPublisher.SubscribeUser(vip);
            moviePublisher.SubscribeUser(vip);

            newsPublisher.SubscribeUser(regularUser);
            //newsPublisher.UnsubscribeUser(vip);

            //publishers notify observers that subscribe successfully
            newsPublisher.Notify();
            moviePublisher.Notify();
            sportPublisher.Notify();

            //publisher repo has new article/message 
            //note: can make article not abstract and use Article directly instead of NewsArticle, I mean, Concrete class not need if article is concrete
            Article a1 = new NewsArticle
            {
                Title = "US news",
                Detail = "Trump is going to...",
                Time = DateTime.Now,
                Subject = newsPublisher
            };
            Article a2 = new NewsArticle
            {
                Title = "China news",
                Detail = "xi jin ping jiayou",
                Time = DateTime.Now,
                Subject = newsPublisher
            };
            newsPublisher.AddArticle(a1);
            newsPublisher.AddArticle(a2);

            Article a3 = new SportArticle
            {
                Title = "Wald downk",
                Detail = "welcome to watch NBA show...",
                Time = DateTime.Now,
                Subject = sportPublisher
            };
            sportPublisher.AddArticle(a3);
            moviePublisher.AddArticle(a3);  //wrong because sportnews cannot be sent thru movie channel

            Console.ReadKey();
        }
    }
}

