﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Mail
    {
        public Subscriber Subscriber { get; set; }
        public string Message { get; set; }

        public Mail(Subscriber subscriber)
        {
            Subscriber = subscriber;
        }

        public void CreateMessage()
        {
            Message = "";
            List<Article> newArticles = new List<Article>();
            foreach (Category category in Subscriber.Subscription)
            {
                newArticles = Subscriber.GetUpdatedArticles();
            }
            foreach (Article article in newArticles)
            {
                Message += article.ToString();
                Message += Environment.NewLine;
            }
            if (string.IsNullOrEmpty(Message))
            {
                Console.WriteLine("No new articles");
            }
            else
            {
                SendMail();
            }
        }

        private void SendMail()
        {
            Console.WriteLine("Mail to " + Subscriber.Name);
            Console.WriteLine(Message);
        }
    }
}
