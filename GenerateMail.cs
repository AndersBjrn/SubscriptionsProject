using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class GenerateMail
    {
        public static void CreateMessage(Subscriber subscriber, List<Article> updatedArticles)
        {
            Mail email = new Mail(subscriber);
            
            //foreach (Category category in Subscriber.Subscription)
            //{
            //    newArticles = Subscriber.GetUpdatedArticles();
            //}
            foreach (Article article in updatedArticles)
            {
                email.Message += article.ToString(); // Detta blir SubscriptionProject.Subscriber
                email.Message += Environment.NewLine;
            }
            //if (string.IsNullOrEmpty(Message))
            //{
            //    Console.WriteLine("No new articles");
            //}
            //else
            //{
            SendMail(email.Message);
            //}
        }
        public static void CreateMessage(Subscriber subscriber)
        {
            string message = $"Dear {subscriber.Name}\n No new articles from your subscription this week.";
            SendMail(message);
        }

        private static void SendMail(string message)
        {
            //Console.WriteLine("Mail to " + Subscriber.Name);
            Console.WriteLine(message);
        }
    }
}
