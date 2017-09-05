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
            Message = $"Dear {subscriber}\n One or more of your subscribed articles has been updated. Please read below:";
        }

    }
}
