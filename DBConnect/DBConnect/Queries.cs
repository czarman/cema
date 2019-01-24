namespace DBConnect
{
    internal class Queries
    {
        public static string tenUsers = "SELECT TOP(10)[LOGIN_NAME] FROM[ICLEAR_CENTRALDB].[dbo].[USER_ACCOUNTS]";
    }
}