﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //HardCoding(); 
        }
        /*
        private static void HardCoding()
        {
            string companyName = "TidningsBudet";
            Company company = new Company(companyName);
            company.AddCategory(company, "", "News");
            company.AddCategory(company, "News", "Bad news");
            company.AddCategory(company, "News", "Good news");
            Category news = company.SubscriptionableCategories["News"];
            Category badNews = company.SubscriptionableCategories["Bad news"];
            Category goodNews = company.SubscriptionableCategories["Good news"];


            company.AddCategory(company, "", "About us");
            company.AddCategory(company, "About us", "Careers");
            company.AddCategory(company, "About us", "Environment");

            Category aboutUs = company.SubscriptionableCategories["About us"];
            Category career = company.SubscriptionableCategories["Careers"];
            Category environment = company.SubscriptionableCategories["Environment"];


            Editor Håkan = new Editor("Håkan");
            Editor Bengt = new Editor("Bengt");
            Editor Lina = new Editor("Lina");
            Article a1 = new Article("Vackert väder idag igen", "Solen sken", "Mycket mycket solsken", Bengt);
            Article a2 = new Article("Vi bryr oss om miljön", "Vi gör saker för att miljön ska må bra", "Chefen cyklade till jobbet", Bengt);
            Article a3 = new Article("Inget att rapportera", "Intet nytt under solen", "Inget speciell har hänt", Bengt);
            Article a4 = new Article("En till artikel i career", "sök ett jobb", "Detta kan du jobba med hos oss", Lina);
            Article a5 = new Article("En enviromentartikel", "Miljön", "Jag gillar träd", Lina);
            Article a6 = new Article("Dåliga nyheter", "Dåliga saker", "Dåliga saker hände", Lina);
            Article a7 = new Article("Jättedåliga nyheter", "Katastrof", "Inte alls bra", Håkan);
            Article a8 = new Article("Info om oss", "Rubrik om ost", "Text som handlar om företaget", Håkan);
            Article a9 = new Article("Testartikel 9", "nio", "jag orkar inte mer", Bengt);
            goodNews.Articles.Add(a1);
            environment.Articles.Add(a2);
            goodNews.Articles.Add(a3);
            career.Articles.Add(a4);
            environment.Articles.Add(a5);
            badNews.Articles.Add(a6);
            badNews.Articles.Add(a7);
            environment.Articles.Add(a8);
            goodNews.Articles.Add(a9);

            Subscriber subs1 = new Subscriber("Kalle");
            subs1.Subscription.Add(news);
            subs1.Subscription.Add(career);
            Subscriber subs2 = new Subscriber("Lisa");
            subs2.Subscription.Add(goodNews);
            subs2.Subscription.Add(aboutUs);

            List<Article> listaSubs1 = new List<Article>(subs1.GetUpdatedArticles());
            if (listaSubs1.Count == 0)
                GenerateMail.CreateMessage(subs1);
            else
                GenerateMail.CreateMessage(subs1, listaSubs1);

            List<Article> listaSubs2 = new List<Article>(subs2.GetUpdatedArticles());
            if (listaSubs2.Count == 0)
                GenerateMail.CreateMessage(subs2);
            else
                GenerateMail.CreateMessage(subs2, listaSubs2);


            List<Article> lista = new List<Article>(subs1.GetUpdatedArticles());
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            subs1.AddCategoryToSubscription(environment);
        }
        */
    }
}
