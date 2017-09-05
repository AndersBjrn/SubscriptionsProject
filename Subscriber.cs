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

        public List<Article> GetUpdatedArticles()
        //Denna metod returnerar en lista av artiklar som har uppdaterats(från senaste 7 dagarna) 
        //från de kategorier som Subscriber har valt att prenumerera på
        {
            List<Article> allArticlesList = new List<Article>();
            List<Article> updatedArticlesList = new List<Article>();
            foreach (Category category in Subscription)
            {
                GetAllArticlesFromCategory(category, allArticlesList);
                foreach (Article article in allArticlesList)
                {
                    bool matchFound = (DateTime.Now - article.CreationDate).TotalDays < 7;
                    if (matchFound)
                    {
                        updatedArticlesList.Add(article);
                    }
                }
            }
            return updatedArticlesList;
        }

        public void GetAllArticlesFromCategory(Category category, List<Article> articleList)
        //Rekursiv metod för att gå igenom samtliga artiklar från en kategori 
        //och dess underkategorier och returnera dessa artiklar
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
                    GetAllArticlesFromCategory(c, articleList);
                }
            }
        }

        public void AddCategoryToSubscription(Category c)//Lägger till en ny kategori om inte den eller en förälder redan finns i listan
        {
            if (Subscription.Contains(c) || Subscription.Contains(c.Parent))
            {
                return;
            }
            else
            {
                Subscription.Add(c);
            }
            List<Category> subcats = c.Subcategories;
            foreach (var cat in subcats)//Om kategorien som lades till redan hade subcategories i listan tas dessa bort
            {
                if (Subscription.Contains(cat))
                {
                    RemoveCategoryFromSubscription(cat);
                }
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
