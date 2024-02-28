using System;
namespace Modul6
{
    public class Opgave6_3
    {
        public void Run() {
            DiceCup dc = new(5);

            for (int i = 0; i < 10; i++) {
                dc.Shake();
                var res = dc.Eyes();
                foreach (int eye in res)
                    Console.Write($"{eye} ");
                Console.WriteLine();
            }

        }
    }
}

