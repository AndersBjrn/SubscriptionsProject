using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriptionProject;


namespace UnitTestProject1
{
   
    public class TestManagingCategoriesAndArticles
    {
        
        public static Company CreateCompanyCategoriesAndArticles()
        {
            Company company = new Company("Test Company");
            company.AddCategory(company, "", "News");
            company.AddCategory(company, "News", "Bad news");
            company.AddCategory(company, "News", "Good news");
            company.AddCategory(company, "", "About us");
            company.AddCategory(company, "About us", "Careers");
            company.AddCategory(company, "About us", "Environment");
            company.AddCategory(company, "", "Test1");
            company.AddCategory(company, "Test1", "Test2");
            company.AddCategory(company, "Test2", "Test3");
            company.AddCategory(company, "Test3", "Test3-1");
            company.AddCategory(company, "Test3", "Test3-2");

            Editor Håkan = new Editor("Håkan");
            Editor Bengt = new Editor("Bengt");
            Editor Lina = new Editor("Lina");

            company.SubscriptionableCategories["Good news"].AddArticle("Vackert väder idag igen", "Solen sken", "Mycket mycket solsken", Bengt);
            company.SubscriptionableCategories["Bad news"].AddArticle("Dåliga nyheter", "Dåliga saker", "Dåliga saker hände", Lina);
            company.SubscriptionableCategories["Careers"].AddArticle("Testartikel 9", "nio", "jag orkar inte mer", Bengt);
            company.SubscriptionableCategories["Environment"].AddArticle("En enviromentartikel", "Miljön", "Jag gillar träd", Lina);
            company.SubscriptionableCategories["Test3-1"].AddArticle("Svenska landskapsapor", "Du kommer aldrig att tro detta, att...", "... det finns egentligen inga landskapsapor. De är bara påhittade", Håkan);
            return company;
        }
    }
}
