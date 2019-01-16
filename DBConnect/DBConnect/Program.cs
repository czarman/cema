using System;
using System.Data.SqlClient;

namespace DBConnect
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Top 10 users from Iclrear Central DB \r\n");
            DBConnectAndDisplay();

            Console.WriteLine("\r\n Press any key to exit");
            Console.ReadKey();
        }

        private static void DBConnectAndDisplay()
        {
            using (
                var dBConnection =
                    new SqlConnection(
                        "Server=DTGQN1VDSQL0006.infosolco.com; Database = ICLEAR_CENTRALDB ;user id =tmp_test; password=PleaseConnect;")
                )
            {
                dBConnection.Open();

                using (
                    var displayUsers =
                        new SqlCommand("SELECT TOP(10)[LOGIN_NAME] FROM[ICLEAR_CENTRALDB].[dbo].[USER_ACCOUNTS]",
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