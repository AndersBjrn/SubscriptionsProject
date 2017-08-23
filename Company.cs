using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Company
    {
        public string Name { get; set; }
        public Dictionary<string, Category> SubscriptionableCategories { get; set; }

        public Company(string name)
        {
            Name = name;
        }
    }
}
