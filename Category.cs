﻿using System;
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
        public Dictionary<string,Category> Subcategories { get; set; }
        public List<Article> Articles { get; set; }

        public Category()
        {

        }
    }
}