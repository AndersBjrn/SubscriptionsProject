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
        /*Detta dictionary pekar på kategorier med nyckeln som är namnet på kategorien. 
         * Denna fylls på från konstruktorn i FrontEnd. Kanske borde flyttas till
         * Category? 
         * /

        public Company(string name)
        {
            Name = name;
            SubscriptionableCategories = new Dictionary<string, Category>();
        }
    }
}
