using System;
namespace Modul2
{
    public class ControlStructures
    {
        public void Run()
        {
            selection();
            iteration();
            conditionalExpressions();
        }

        void selection() {

            int x = 1;
            if (x < 6) {
                Console.WriteLine($"{x} er mindre end 6");
            }

            switch (x) {
                case 1: x++;
                    break;
                case 2: x--;
                    break;
            }
            Console.WriteLine($"Selection: x = {x}");

        }

        void iteration() {

            for (int i = 0; i < 12; i++) {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            int j = 0;
            while (j < 12) {
                Console.Write(" " + j);
                j++;
            }
            Console.WriteLine();

            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            foreach (int v in a) {
                Console.Write(" " + v);
            }
            Console.WriteLine();
        }

        void conditionalExpressions() {
            int x = 8;

            string output = x <= 5 ? "resultatet er under 6" : "Forrygende! Resultatet er over 5!!!!";

            Console.WriteLine(output);

        }
    }
}

