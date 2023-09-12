using System;
namespace Modul4
{
    public class Opgave4_1
    {
        public void Run(){
            int[] count = new int[6];
            // bruges til tælle - antal i'ere ligger i index i-1

            var d = new MafiaDice();
            int N = 1000000;
            for (int i = 0; i < N; i++)
            {
                d.Roll();
                int eyes = d.Eyes;
                int index = eyes - 1;
                count[index]++;
            }
            foreach (int c in count)
                Console.WriteLine($"{c} {(double)c*100/N}");

        }
    }
}

