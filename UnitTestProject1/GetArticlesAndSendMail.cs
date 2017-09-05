using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubscriptionProject;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class GetArticlesAndSendMail
    {
        [TestMethod]
        public void TestGetUpdates1()
        {
            /* Mål för testet: Vi har en subscriber med en lista av kategorier. När vi 
             * kallar på GetUpdates så ska vi få alla uppdateringar de senaste sju dagarn
             * I framtiden kan vi lämna plats för möjligheten att specifiera tidsintervallet
             * som vi vill ha uppdateringar från
             */


            //Company TestCompany = new Company("Test Company");
            //TestCompany.AddCategory()
            
            // Prepare
            Company company = TestManagingCategoriesAndArticles.CreateCompanyCategoriesAndArticles();

            //Execute
            Subscriber subscriber = new Subscriber("Bertil");
            subscriber.AddCategoryToSubscription(company.SubscriptionableCategories["Good news"]);
            subscriber.AddCategoryToSubscription(company.SubscriptionableCategories["About us"]);
            List<Article> listOfArticles = subscriber.GetUpdatedArticles();

            Subscriber subscriber2 = new Subscriber("Anna");
            subscriber2.AddCategoryToSubscription(company.SubscriptionableCategories["Environment"]);
            subscriber2.AddCategoryToSubscription(company.SubscriptionableCategories["Test1"]);
            List<Article> listOfAnnasArticles = subscriber2.GetUpdatedArticles();
            Mail bertilsEmail = GenerateMail.CreateMessage(subscriber, listOfArticles);
            Mail annasEmail = GenerateMail.CreateMessage(subscriber2, listOfAnnasArticles);
            Mail emptyEmail = GenerateMail.CreateMessage(subscriber , new List<Article>());
            

            // Assert
            Assert.AreEqual(3, listOfArticles.Count);
            Assert.AreEqual(2, listOfAnnasArticles.Count);
            
        }

        public void TestGetUpdates2()
        {

        }



        [TestMethod]
        public void TestCreateMail()
        {
            /* Denna funktion ska, utifrån en subscriber:
             * samla in artiklar som subscribern har efterfrågat,
             * sätta samman ett mail som innehåller efterfrågad information, samt
             * skicka ut mailet */

            
        }

        
    }
}
