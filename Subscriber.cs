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
        public List<Category> Subscription { get; set; } // Denna lista pekar på kategorier som prenumereras på 

        public Subscriber(string name)
        {
            Name = name;
            Subscription = new List<Category>();
        }

        public List<Article> GetUpdates()
        {
            List<Article> articleList = new List<Article>();
            foreach (Category category in Subscription)
            {
                articleList = GetArticles(category, articleList);
                foreach (Article article in articleList)
                {
                    bool matchFound = (DateTime.Now - article.CreationDate).TotalDays < 7;
                    if (matchFound)
                    {
                        articleList.Add(article);
                    }
                }
            }
            return articleList;
        }

        // todo: Anders, skriv vad dessa gör (vad de får in och vad de gör)!
        public List<Article> GetArticles(Category category, List<Article> articleList)
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
                    temp.ForEach(x => articleList.Add(x));
                }
            }
            return articleList;
        }

        //Vi borde ha en AddCategoryToSubscription-metod här
    }
}
