using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {

        public static string ToCheck;


        static void Main(string[] args)
        {
            
            Console.WriteLine("Wpisz tekst:");
            ToCheck = Console.ReadLine();
            CzyPalindrom(ToCheck.ToLower());
            Console.WriteLine("Wcisnij klawisz zakończyć");
            Console.ReadKey();

        }

        public static void CzyPalindrom(string ToCheck)
        {
            int lenght = ToCheck.Length;
            string Backward =null;
            int i = lenght - 1;
            while(i>=0)
            {
                Backward = Backward + ToCheck.Substring(i, 1);
                i--;
                
            }
            
            if (ToCheck == Backward)
            {
                Console.WriteLine("To jest Palindrom");
            }
            else
            {
                Console.WriteLine("To nie jest Palindrom");
            }

            
        }
    }
}
