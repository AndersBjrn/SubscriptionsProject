using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Article
    {
        public string Title { get; set; }
        public Editor Editor { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }

        public Article(string title, string summary, string text, Editor editor)
        {
            Title = title;
            Summary = summary;
            Text = text;
            Editor = editor;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
