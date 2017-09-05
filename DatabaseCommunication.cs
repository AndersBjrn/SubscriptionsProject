using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionProject
{
    class DatabaseCommunication
    {
        private static void SelectAllSubscribers(List<string> listOfSubscribers)
        {
            var connstr = "Server = (localdb)\\mssqllocaldb; Database = SupscriptionDB";
            using (var con = new SqlConnection(connstr))
            using (var com = new SqlCommand($"Select Name From Subscribers;", con))
            {
                con.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                    listOfSubscribers.Add(reader[1].ToString());
            }
        }

        internal static void SearchForArticles(List<string> listOfSubscribers, Dictionary<string, DateTime> listOfArticles)
        {
            var connstr = "Server = (localdb)\\mssqllocaldb; Database = SupscriptionDB";
            using (var con = new SqlConnection(connstr))
            using (var com1 = new SqlCommand($"Select Article.Name, Article.Date from Customer Where ", con))
            {
                con.Open();
                var reader = com1.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount - 1; i++)
                    {
                        Console.Write($"{reader[(i + 1)].ToString().PadRight(reader[(i + 1)].ToString().Length + 3)}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}
