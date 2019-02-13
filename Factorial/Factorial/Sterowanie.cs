using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Sterowanie
    {
        public static string sterowanie;

        public static void Control()
        {
            Console.WriteLine("Wcisnij 1 by obliczyć silnię lub E by wyjść");
            sterowanie = Console.ReadLine().ToString();
            
            if (sterowanie == "1")
            {
                Silnia.EterValues();
                Silnia.GetLoopValue(Silnia.liczba);
                Console.WriteLine(Silnia.wynik);
                Silnia.GetRecursiveValue(Silnia.liczba);
                Console.WriteLine(Silnia.wynik);
                Sterowanie.Control();
            }
            else if (sterowanie.ToLower() == "e")
            {

            }
            else
            {
                Console.WriteLine("Wybierz tylko jedną z opcji");
                Sterowanie.Control();
            }
            {

            }
        }
    }
}
