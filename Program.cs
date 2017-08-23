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
            FrontEnd frontEnd = new FrontEnd();
            string companyName = frontEnd.GetCompanyName();
            Company company = new Company(companyName);

            //frontEnd.UserInterface(company);

            frontEnd.AddCategory(company, "" , "News");
            frontEnd.AddCategory(company, "News", "Bad news");
            frontEnd.AddCategory(company, "News", "Good news");
            Category news = company.SubscriptionableCategories["News"];
            Category badNews = company.SubscriptionableCategories["Bad news"];
            Category goodNews = company.SubscriptionableCategories["Good news"];
            
            
            frontEnd.AddCategory(company, "", "About us");
            frontEnd.AddCategory(company, "About us", "Careers");
            frontEnd.AddCategory(company, "About us", "Environment");

            Category aboutUs = company.SubscriptionableCategories["About us"];
            Category career = company.SubscriptionableCategories["Careers"];
            Category environment = company.SubscriptionableCategories["Environment"];

            
            Editor Håkan = new Editor("Håkan");
            Editor Bengt = new Editor("Bengt");
            Editor Lina = new Editor("Lina");
            Article a1 = new Article("Vackert väder idag igen", "Solen sken", "Mycket mycket solsken", Bengt);
            goodNews.Articles.Add(a1);

            Subscriber subs1 = new Subscriber("Kalle");
            subs1.Subscription.Add(news);
            subs1.Subscription.Add(career);
            Subscriber subs2 = new Subscriber("Lisa");
            subs2.Subscription.Add(goodNews);
            subs2.Subscription.Add(aboutUs);

        }
    }
}
