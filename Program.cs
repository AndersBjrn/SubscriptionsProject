using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontEnd frontEnd = new FrontEnd();
            string companyName = frontEnd.GetCompanyName();
            Company companty = new Company(companyName);
        }
    }
}
