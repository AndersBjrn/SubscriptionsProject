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

            Category aboutUs = company.SubscriptionableCategories["About us"];
            Category career = company.SubscriptionableCategories["Careers"];
            Category environment = company.SubscriptionableCategories["Environment"];
            return company;
        }
    }
}
