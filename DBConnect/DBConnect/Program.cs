using System;

//TODO - tu ladnie kodzik sformatowany:)
//TODO ale wydziel to do klas, connection stringa przenieś do pliku app.config. 
//Komendę Select możesz przenieść do jakiejś klasy SQLCommands(w tym przypadku może być statyczne :))

namespace DBConnect
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Top 10 users from Iclrear Central DB \r\n");
            ConnectionToDb.DBConnectAndDisplay();

            Console.WriteLine("\r\n Press any key to exit");
            Console.ReadKey();
        }
    }
}