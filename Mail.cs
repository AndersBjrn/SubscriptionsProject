using System;
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
            foreach (Category category in Subscriber.Subscription)
            {
                Subscriber.GetUpdates();
            }
        }
    }
}
