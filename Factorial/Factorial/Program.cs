using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO Zawsze usuwaj nieuzywane usingi - jak masz R# to skrot Ctrl + E + C i wyczysci wszystko


namespace Factorial
{
    class Program
    {
        static int liczba;
        static long wynik;

        //TODO Trochę tu trzeba posprzątać. To jest prosta aplikacja ale mimo wszystko standardy trzeba zachowywać i tak.
        //TODO Stworz klasę Silnia ktora będzie miała 2 metody. GetRecursiveValue i GetLoopValue, ktore to będą liczyć tą silnie.
        //TODO Lub też patrząc bardziej obiektowo. Interfejs IFactorial z metodą CountFactorial i dwie implementacje tego interfejsu LoopFactorial i RecursiveFactorial.
        //TODO W metodzie main skoro już jesteśmy w konsolowej aplikacji powinno być sterowanie, tworzenie potrzebnych obiektów.
        //TODO Kod powinien być samodokumentujący się. Popraw nazwy zmiennych i metod - method2/liczba to nie są dobre nazwy. Już lepiej byłoby PoliczSilnięRekurencyjnie i wynikCzesciowy
        //TODO Formatuj kod - jak wyżej CTRL + E + C sformatuje ci ładnie kod.
        //TODO Wprowadz te poprawki co pisalem i sprawdze jeszcze raz :)
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę ");
            var read = Console.ReadLine();
            int.TryParse(read,out liczba);

            if (liczba==0)
            {
                Console.WriteLine("wynik silni: 1");
                return;
            }
            Method1(liczba);
            Console.WriteLine(wynik);
            Console.ReadKey();
            

        }

        static long Method1(int liczba)
        {
            Console.WriteLine("Pętla");
            wynik = liczba;
            while (liczba > 1)
            {
                
                liczba--;
                wynik = wynik * liczba;

            }

                return wynik;
            

        }
        static bool first = true;

        static long Method2(int liczba)
        {
            if(first)
            {
                Console.WriteLine("rekurencja");
                wynik = liczba;
                first = false;
            }

            
            liczba--;
            if(liczba>0)
            {
                wynik = wynik * liczba;
            }
            
            
            if (liczba<1)
            {
                return wynik;
            }
            else
            {
      
                Method2(liczba);
            }






            return wynik;
        }
    }
}
