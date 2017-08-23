using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class FrontEnd
    {
        static void SplashScreen()
        {
            //Skriva ut alla val
            Console.WriteLine("vill);
        }

        static void AddCategory(Company company , string parentCategory , string categoryName)
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

        static void AddArticle()
        {

        }

        public string GetCompanyName()
        {
            return "Hogia";
        }

        public void UserInterface(Company company)
        {
            AddCategory(company);
        }
    }
}
