using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Subscriber 
    {
        public string Name { get; set; }
        public List<Category> Subscription { get; set; }

        public Subscriber(string name)
        {
            Name = name;
            Subscription = new List<Category>();
        }

        public List<Article> GetUpdatedArticles()//Denna metod returnerar en lista av artiklar som har uppdaterats från de kategorier som Subscriber har valt att prenumerera på
        {
            List<Article> allArticlesList = new List<Article>();
            List<Article> updatedArticlesList = new List<Article>();
            foreach (Category category in Subscription)
            {
                allArticlesList = GetArticles(category, allArticlesList);
                foreach (Article article in allArticlesList)
                {
                    bool matchFound = (DateTime.Now - article.CreationDate).TotalDays < 7;
                    if (matchFound)
                    {
                        updatedArticlesList.Add(article);
                    }
                }
            }
            return allArticlesList;
        }

        public List<Article> GetArticles(Category category, List<Article> articleList)//Rekursiv metod för att gå igenom samtliga artiklar från en kategori och dess underkategorier och returnera dessa artiklar
        {
            if (category.Articles.Count != 0)
            {
                foreach (var article in category.Articles)
                {
                    articleList.Add(article);
                }
            }
            else
            {
                foreach (Category c in category.Subcategories)
                {
                    List<Article> temp = GetArticles(c, articleList);
                    temp.ForEach(article => articleList.Add(article));
                }
            }
            return articleList;
        }
    }
}
