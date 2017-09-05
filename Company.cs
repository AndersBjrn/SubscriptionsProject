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
         */

        public Company(string name)
        {
            Name = name;
            SubscriptionableCategories = new Dictionary<string, Category>();
        }

        public void AddCategory(Company company, string parentCategory, string categoryName)
        {
            bool isOrphan;
            if (parentCategory == "")
                isOrphan = true;
            else
                isOrphan = false;

            if (isOrphan)
            {
                company.SubscriptionableCategories.Add(categoryName, new Category(categoryName));
            }
            else
            {
                Category parent = company.SubscriptionableCategories[parentCategory];
                company.SubscriptionableCategories.Add(categoryName, new Category(categoryName, parent));
            }


        }
    }
}
