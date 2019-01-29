using System;

namespace Palindrom
{
    internal class IfPalindrome
    {
        public static void If_Palindrome(string ToCheck)
        {
            var lenght = ToCheck.Length;
            var fromEnd = lenght - 1;
            var sentense = ToCheck.ToCharArray();

            var half = lenght/2;


            for (var j = 0; j < half; j++)
            {
                if (sentense[j] == sentense[fromEnd])
                {
                }
                else
                {
                    Console.WriteLine("To nie jest palindrom");
                    return;
                }
                ;
                fromEnd--;
            }

            Console.WriteLine("To jest palindrom");


            //old version
            /*
             *          string Backward = null;
                        int a = 0;
                        foreach (var single in Backward)
                        {
                            single = sentense[a];
                        }

                        /* while (i >= 0)
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
                        */
        }
    }
}