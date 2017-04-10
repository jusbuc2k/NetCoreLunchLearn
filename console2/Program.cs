using System;
using Dapper;

namespace console2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost; Initial Catalog=WebsiteProjectSkeleton_vNext; User ID=justin;password=DemoP@ssword;";
            
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                var results = conn.Query<dynamic>("SELECT UserID, EmailAddress FROM dbo.[User] ORDER BY [EmailAddress];");

                Console.WriteLine("Listing of users in webskel:");
                Console.WriteLine("UserID\tEmail Address");

                foreach (var result in results)
                {
                    Console.WriteLine($"{result.UserID}\t{result.EmailAddress}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
