using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Category
    {
        public string Name { get; set; }
        public Category Parent { get; set; }

        public List<Category> Subcategories { get; set; }

        public List<Article> Articles { get; set; }

        public Category(string name , Category _Parent)
        {
            //Här vill vi att Parent ska sättas.
            Parent = _Parent;

            Name = name;
        }

        public Category(string _Name)
        {
            Name = _Name;
        }
    }
}
