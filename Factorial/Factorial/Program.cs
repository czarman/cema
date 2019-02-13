using System;
using System.Runtime.InteropServices;

//TODO Zawsze usuwaj nieuzywane usingi - jak masz R# to skrot Ctrl + E + C i wyczysci wszystko

namespace Factorial
{
    internal class Program
    {



        //TODO Trochę tu trzeba posprzątać. To jest prosta aplikacja ale mimo wszystko standardy trzeba zachowywać i tak.
        //TODO Stworz klasę Silnia ktora będzie miała 2 metody. GetRecursiveValue i GetLoopValue, ktore to będą liczyć tą silnie.
        //TODO Lub też patrząc bardziej obiektowo. Interfejs IFactorial z metodą CountFactorial i dwie implementacje tego interfejsu LoopFactorial i RecursiveFactorial.
        //TODO W metodzie main skoro już jesteśmy w konsolowej aplikacji powinno być sterowanie, tworzenie potrzebnych obiektów.
        //TODO Kod powinien być samodokumentujący się. Popraw nazwy zmiennych i metod - method2/liczba to nie są dobre nazwy. Już lepiej byłoby PoliczSilnięRekurencyjnie i wynikCzesciowy
        //TODO Formatuj kod - jak wyżej CTRL + E + C sformatuje ci ładnie kod.
        //TODO Wprowadz te poprawki co pisalem i sprawdze jeszcze raz :)



        private static void Main(string[] args)
        {
            Sterowanie.Control();

        }


    }
}