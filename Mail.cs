using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class Mail
    {
        public Subscriber Subscriber { get; set; }
        public string Message { get; set; }

        public Mail(Subscriber subscriber)
        {
            Subscriber = subscriber;
        }

    }
}
