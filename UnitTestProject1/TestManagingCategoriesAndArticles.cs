using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriptionProject;

namespace UnitTestProject1
{
    class TestManagingCategoriesAndArticles
    {
        public Company CreateCompanyCategoriesAndArticles()
        {
            Company company = new Company("Test Company");
            company.AddCategory(company, "", "News");
            company.AddCategory(company, "News", "Bad news");
            company.AddCategory(company, "News", "Good news");
            company.AddCategory(company, "", "About us");
            company.AddCategory(company, "About us", "Careers");
            company.AddCategory(company, "About us", "Environment");

            Editor Håkan = new Editor("Håkan");
            Editor Bengt = new Editor("Bengt");
            Editor Lina = new Editor("Lina");

            company.SubscriptionableCategories["Good news"].AddArticle("Vackert väder idag igen", "Solen sken", "Mycket mycket solsken", Bengt);
            company.SubscriptionableCategories["Bad news"].AddArticles("Dåliga nyheter", "Dåliga saker", "Dåliga saker hände", Lina);
            company.SubscriptionableCategories["Careers"].AddArticle("Testartikel 9", "nio", "jag orkar inte mer", Bengt);
            company.SubscriptionableCategories["Environment"].AddArticle("En enviromentartikel", "Miljön", "Jag gillar träd", Lina);
            return company;
        }
    }
}
