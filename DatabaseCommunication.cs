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
        private static void CallDb(string table)
        {
            var connstr = "Server = (localdb)\\mssqllocaldb; Database = SupscriptionDB";
            using (var con = new SqlConnection(connstr))
            using (var com = new SqlCommand($"Select * From {table};", con))
            {
                con.Open();
                var reader = com.ExecuteReader();
            }
        }
        internal static void SearchForInfo(string connstr, string table)
        {
            string column;
            string input;
            //DecideParameter("Vad vill du söka på", "Sökord", out column, out input);

            using (var con = new SqlConnection(connstr))
            using (var com1 = new SqlCommand($"Select * from Customer Where ", con))
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
