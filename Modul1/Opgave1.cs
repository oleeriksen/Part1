using System;
namespace Modul1
{
    public class Opgave1
    {
        public void Run() {
            Console.WriteLine("Her kommer løsningen af opgave 1");
            Console.Write("Indtast det første tal:");
            int tal1 = ReadInt();
            Console.Write("Indtast det andet tal:");
            int tal2 = ReadInt();
            int sum = tal1 + tal2;
            Console.WriteLine("Summen er " + sum);
        }

        private int ReadInt()
        {
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}

