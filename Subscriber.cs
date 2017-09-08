using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class Subscriber
    {
        public string Name { get; set; }
        public List<Category> Subscription { get; set; } // Denna lista pekar på kategorier som prenumereras på 

        public Subscriber(string name)
        {
            Name = name;
            Subscription = new List<Category>();
        }

        public List<Article> GetUpdatedArticles()
        //Denna metod returnerar en lista av artiklar som har uppdaterats(från senaste 7 dagarna) 
        //från de kategorier som Subscriber har valt att prenumerera på
        {
            List<Article> updatedArticlesList = new List<Article>();
            foreach (Category category in Subscription)
            {
                List<Article> allArticlesList = new List<Article>();
                GetArticles(category, allArticlesList);
                foreach (Article article in allArticlesList)
                {
                    bool matchFound = (DateTime.Now - article.UpdateDate).TotalDays < 7;
                    if (matchFound)
                    {
                        updatedArticlesList.Add(article);
                    }
                }
            }
            return updatedArticlesList;
        }

        public void GetArticles(Category category, List<Article> articleList)//Rekursiv metod för att gå igenom samtliga artiklar från en kategori och dess underkategorier och returnera dessa artiklar
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
                    GetArticles(c, articleList);
                }
            }
        }

        bool CheckParents(Category cat)
        {
            if (Subscription.Contains(cat))
            {
                return true;
            }
            else if (cat.Parent != null)
            {
                return CheckParents(cat.Parent);
            }
            else
            {
                return false;
            }
        }

        void CheckChildren(Category cat)
        {
            if (Subscription.Contains(cat))
            {
                RemoveCategoryFromSubscription(cat);
                return;
            }
            else if (cat.Subcategories != null)
            {
                foreach (Category category in cat.Subcategories)
                {
                    CheckChildren(category);
                }
            }
        }

        public void AddCategoryToSubscription(Category c)//Lägger till en ny kategori om inte den eller en förälder redan finns i listan
        {
            if (CheckParents(c))
            {
                return;
            }
            else
            {
                Subscription.Add(c);
            }
            foreach (Category subcat in c.Subcategories)
            {
            CheckChildren(subcat);
            }
        }

        public void RemoveCategoryFromSubscription(Category c)//Ta bort en kategori från listan
        {
            if (!Subscription.Contains(c))
            {
                return;
            }
            else
            {
                Subscription.Remove(c);
            }
        }
    }
}
