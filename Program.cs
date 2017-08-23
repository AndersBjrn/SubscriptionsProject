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
            Category badNews = new Category("Bad news", news);
            Category goodNews = new Category("Good news", news);
            news.Subcategories.Add(badNews);
            news.Subcategories.Add(goodNews);
            Category aboutUs = new Category("About us");
            Category career = new Category("Careers", aboutUs);
            Category enviroment = new Category("Enviroment", aboutUs);
            aboutUs.Subcategories.Add(career);
            aboutUs.Subcategories.Add(enviroment);
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
            enviroment.Articles.Add(a2);
            goodNews.Articles.Add(a3);
            career.Articles.Add(a4);
            enviroment.Articles.Add(a5);
            badNews.Articles.Add(a6);
            badNews.Articles.Add(a7);
            enviroment.Articles.Add(a8);
            goodNews.Articles.Add(a9);
            Subscriber subs1 = new Subscriber("Kalle");
            subs1.Subscription.Add(news);
            subs1.Subscription.Add(career);
            Subscriber subs2 = new Subscriber("Lisa");
            subs2.Subscription.Add(goodNews);
            subs2.Subscription.Add(aboutUs);

        }
    }
}
