using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int liczba;
        static long wynik;

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
