using System;
namespace Modul5
{
    public class Opgave1
    {
        public void Run() {
            MafiaDice d = new MafiaDice();
            int[] hyppighed = new int[6+1];
            for (int i = 0; i < 100000000; i++) {
                d.Roll();
                hyppighed[d.Eyes()]++;
            }
            for (int i = 1; i <= 6; i++)
                Console.WriteLine($"Antal {i} = {hyppighed[i]}");

        }
    }
}

