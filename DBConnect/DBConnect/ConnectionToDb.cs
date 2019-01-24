using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DBConnect
{
    internal class ConnectionToDb
    {
        public static void DBConnectAndDisplay()
        {
            using (
                var dBConnection =
                    new SqlConnection(
                        ConfigurationManager.AppSettings["ConnectionString"])
                )
            {
                dBConnection.Open();

                using (
                    var displayUsers =
                        new SqlCommand(Queries.tenUsers,
                            dBConnection))
                {
                    using (var reader = displayUsers.ExecuteReader())
                    {
                        while (reader.Read())
                            Console.WriteLine(reader.GetString(0));
                    }
                }
            }
        }
    }
}