using System;

namespace Factorial
{
    internal class Silnia
    {
        public static int liczba;
        public static long wynik;
        public static bool first = true;
        public static void EterValues()
        {
            Console.WriteLine("Podaj liczbę ");
            var read = Console.ReadLine();
            int.TryParse(read, out liczba);

            if (liczba == 0)
            {
                Console.WriteLine("wynik silni: 1");
                return;
            }
            
        }
        public static long GetLoopValue(int liczba)
        {
            Console.WriteLine("Pętla");
            wynik = liczba;
            while (liczba > 1)
            {
                liczba--;
                wynik = wynik*liczba;
            }

            return wynik;
        }


        public static long GetRecursiveValue(int liczba)
        {
            if (first)
            {
                Console.WriteLine("Rekurencja");
                wynik = liczba;
                first = false;
            }


            liczba--;
            if (liczba > 0)
            {
                wynik = wynik*liczba;
            }


            if (liczba < 1)
            {
                return wynik;
            }
            GetRecursiveValue(liczba);


            return wynik;
        }
    }
}