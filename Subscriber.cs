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

        public List<Article> GetArticles(Category category, List<Article> articleList)
        {
            if (category.Articles.Count != 0)
            {
                return articleList;
            }
            else
            {
                foreach (Category c in category.Subcategories)
                {
                    foreach (Article article in c.Articles)
                    {
                        articleList.Add(article);
                    }
                    return GetArticles(c, articleList);
                }
            }
            return articleList;
        }
    }
}
