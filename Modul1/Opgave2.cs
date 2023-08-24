using System;
namespace Modul1
{
    public class Opgave2
    {
        public void Run()
        {
            Console.WriteLine("Her kommer løsningen af opgave 2");
            Console.Write("Indtast et tal:");
            string input = Console.ReadLine();
            int tal = int.Parse(input);
            if (tal % 2 == 0)
                 Console.Write("Tallet er LIGE");
            else
                Console.Write("Tallet er ULIGE");

        }
    }
}

