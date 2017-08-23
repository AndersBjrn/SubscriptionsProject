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
                foreach (Article article in category.Articles)
                {
                    bool matchFound = (DateTime.Now -article.CreationDate).TotalDays < 7;
                    if (matchFound)
                    {
                        articleList.Add(article);
                    }
                }
            }
            return articleList;
        }
    }
}
