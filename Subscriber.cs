using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Subscriber
    {
        public string Name { get; set; }
        public List<Category> Subscription { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }
    }
}
