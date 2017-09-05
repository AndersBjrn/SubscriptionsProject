using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class GenerateMail
    {
        public static Mail CreateMessage(Subscriber subscriber, List<Article> updatedArticles)
        {
            Mail email = new Mail(subscriber);


            //foreach (Category category in Subscriber.Subscription)
            //{
            //    newArticles = Subscriber.GetUpdatedArticles();
            //}
            if (updatedArticles.Count == 0)
            {
                email.Message = $"Dear {subscriber.Name}\n No new articles from your subscription this week.";
            }
            else
            {
                email.Message = $"Dear {subscriber.Name}\n One or more of your subscribed articles has been updated. Please read below:\n\n";


                foreach (Article article in updatedArticles)
                {
                    email.Message += article.ToString(); // Detta blir SubscriptionProject.Subscriber
                    email.Message += Environment.NewLine;
                }
            }
            //if (string.IsNullOrEmpty(Message))
            //{
            //    Console.WriteLine("No new articles");
            //}
            //else
            //{
            //SendMail(email.Message);
            //}
            return email;
        }
        //public static Mail CreateMessage(Subscriber subscriber)
        //{
        //    Mail email = new Mail(subscriber);
        //    string message = $"Dear {subscriber.Name}\n No new articles from your subscription this week.";
        //    email.Message = message;
        //    //SendMail(message);
        //    return email;
        //}

        private static void SendMail(string message)
        {
            //Console.WriteLine("Mail to " + Subscriber.Name);
            Console.WriteLine(message);
        }
    }
}
