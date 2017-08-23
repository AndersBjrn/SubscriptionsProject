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

        static void AddCategory()
        {
            Category News = new Category();


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
