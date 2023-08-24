using System;
namespace Modul1
{
    public class Opgave1
    {
        public void Run() {
            Console.WriteLine("Her kommer løsningen af opgave 1");
            string input = Console.ReadLine();
            int tal = int.Parse(input);
            for (int idx = 1; idx <= tal; idx++) {
                Console.WriteLine(idx);
            }
        }
    }
}

