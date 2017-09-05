using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    public class Editor
    {
        public string Name { get; set; }
        public List<Article> ArticleList { get; set; }

        public Editor(string name)
        {
            ArticleList = new List<Article>();
            Name = name;
        }

        public void AddArticleToEditorList(Article a)
        {
            ArticleList.Add(a);
        }

    }
}
