using System;
namespace Modul1
{
    public class Opgave3
    {
        public void Run() {
            Console.WriteLine("Her kommer løsningen af opgave 3");
            Console.Write("Indtast et tal:");
            string input = Console.ReadLine();
            int tal = int.Parse(input);
            int sum = 0;
            for (int idx = 1; idx <= tal; idx++)
                sum += idx;
            Console.WriteLine("Sum af tal fra 1 til " + tal + " = " + sum);
        }
    }
}

