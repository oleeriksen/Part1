using System;
namespace Modul2
{
    public class Palindrom
    {

        public void Run() {

            while (true)
            {
                Console.WriteLine("Indtast ord (tast q for stop): ");
                string ord = Console.ReadLine();
                if (ord == "q")
                    break;

                if (IsPalindrom(ord))
                    Console.WriteLine($"{ord} er et palindrom");
                else
                    Console.WriteLine($"{ord} er IKKE et palindrom");
            }

        }

        bool IsPalindrom(string s) {
            int first = 0;
            int last = s.Length - 1;
            while (first < last) {
                if (s[first] == s[last])
                {
                    first++;
                    last--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}

