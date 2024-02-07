using System;
namespace Modul2
{
    public class Palindrom
    {
        public void Run() {
            
            Console.WriteLine("Indtast ord:");
            var ord = Console.ReadLine();
            if (IsPalindrome(ord))
                Console.WriteLine($"{ord} er et palindrom");
            else
                Console.WriteLine($"{ord} er IKKE et palindrom");
        }

        bool IsPalindrome(string s) {
            return s.Equals(Reverse(s));
        }

        string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

