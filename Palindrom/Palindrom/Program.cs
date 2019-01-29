using System;

//TODO Zamien pętle while na np for - w algorytmach o liniowej złożoności raczej sie nie powinno stosować while
//TODO TE SAME UWAGI JAK DO KODU Z SILNIA
//TODO Algorytm działa, ale pomyśl czy nie możnaby go przyspieszyć trochę. W tym momencie wykona tyle operacji ile damy mu znaków, czy to aby konieczne? :)
//TODO Jak commitujesz zmiany w jakims projekcie, to staraj sie nie dołączać projektów BIN/Object

namespace Palindrom
{
    internal class Program
    {
        public static string ToCheck;


        private static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst:");
            ToCheck = Console.ReadLine();
            IfPalindrome.If_Palindrome(ToCheck.ToLower());
            Console.WriteLine("Wcisnij klawisz zakończyć");
            Console.ReadKey();
        }
    }
}