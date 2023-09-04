using System;
namespace Modul3
{
    public class Arrays
    {
        public void Run() {
            int[] a = new int[1000];

            for (int i = 0; i < a.Length; i++)
                a[i] = 2 * (i + 1);

            foreach (int value in a) {
                Console.WriteLine(value);
            }

        }
    }
}

