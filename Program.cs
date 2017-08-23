using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //FrontEnd frontEnd = new FrontEnd();
            //string companyName = frontEnd.GetCompanyName();
            //Company company = new Company(companyName);

            //frontEnd.UserInterface(company);


            Category news = new Category("News");
            Category badNews = new Category("Bad news");
            Category goodNews = new Category("Good news");
            news.Subcategories.Add(badNews);
            news.Subcategories.Add(goodNews);
            Category aboutUs = new Category("About us");
            Category career = new Category("Careers");
            Category enviroment = new Category("Enviroment");
            aboutUs.Subcategories.Add(career);
            aboutUs.Subcategories.Add(enviroment);
            Editor Håkan = new Editor("Håkan");
            Editor Bengt = new Editor("Bengt");
            Editor Lina = new Editor("Lina");
            Article a1 = new Article("Vackert väder idag igen", "Solen sken", "Mycket mycket solsken", Bengt);
            goodNews.Articles.Add(a1);

        }
    }
}
