using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubscriptionProject;

namespace UnitTestProject1
{
    [TestClass]
    public class GetArticlesAndSendMail
    {
        [TestMethod]
        public void TestGetUpdates()
        {
            /* Mål för testet: Vi har en subscriber med en lista av kategorier. När vi 
             * kallar på GetUpdates så ska vi få alla uppdateringar de senaste sju dagarn
             * I framtiden kan vi lämna plats för möjligheten att specifiera tidsintervallet
             * som vi vill ha uppdateringar från
             */


            //Company TestCompany = new Company("Test Company");
            //TestCompany.AddCategory()
            SubscriptionProject.Subscriber.GetArticles(category, articleList);
            
        }

        [TestMethod]
        public void TestGetArticles()
        {
            /* Denna funktion ska hämta hem alla artiklar från en kategori och dess underkategorier */

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
