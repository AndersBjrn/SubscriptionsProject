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
            Company company = new Company(companyName);

            frontEnd.UserInterface(company);

            Subscriber subs1 = new Subscriber("Kalle");
            subs1.Subscription
            Subscriber subs2 = new Subscriber("Lisa");

        }
    }
}
