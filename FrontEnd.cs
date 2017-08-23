using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class FrontEnd
    {
        void SplashScreen()
        {
            //Skriva ut alla val
            PrintOptions();
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
            SplashScreen();
            AddCategory(company);
        }

        private void PrintOptions()
        {
            Console.WriteLine($"Vill du{Environment.NewLine}(1) Skapa en ny kategori{Environment.NewLine}(2) Skapa en ny artikel");
        }
    }
}
