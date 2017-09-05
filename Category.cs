using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class Category
    {
        public string Name { get; set; }
        public Category Parent { get; set; }

        public List<Category> Subcategories { get; set; }

        public List<Article> Articles { get; set; }

        public Category(string name , Category _Parent)
        {
            // denna konstruktorn åkallas när det finns en förälder
            Articles = new List<Article>();
            Subcategories = new List<Category>();
            Parent = _Parent;
            Parent.Subcategories.Add(this);
            Name = name;
        }

        public Category(string _Name)
        {
            // denna konstruktorn åkallas när ingen förälder finnes
            Articles = new List<Article>();
            Subcategories = new List<Category>();
            Name = _Name;
        }

        public void AddArticle(string title, string summary, string text, Editor editor)
        {
            Articles.Add(new Article(title, summary, text, editor));
        }

        public void AddArticle(Article a)
        {
            Articles.Add(a);
        }
    }
}
