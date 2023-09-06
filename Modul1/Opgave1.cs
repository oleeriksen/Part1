using System;
namespace Modul1
{
    public class Opgave1
    {
        public void Run() {
            Console.WriteLine("Her kommer løsningen af opgave 1");
            Console.Write("Indtast det første tal:");
            string input = Console.ReadLine();
            int tal1 = int.Parse(input);
            Console.Write("Indtast det andet tal:");
            input = Console.ReadLine();
            int tal2 = int.Parse(input);
            int sum = tal1 + tal2;
            Console.WriteLine("Summen er " + sum);

            int[] x = { 1, 2, 3 };

        }
    }
}

