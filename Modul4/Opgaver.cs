using System;
namespace Modul4
{
    public class Opgaver
    {

        public void Run() {
            int[] data = { 1, 3, 5,7 };
            var avg = Average(data);
            Console.WriteLine($"Gennemsnit er {avg}");
        }

        /// <summary>
        /// Returnerer gennemsnittet af tal i a som en double.
        /// Fejl hvis a er tom (længde på 0).
        /// </summary>
        double Average(int[] a) {
            return 0;
        }

        /// <summary>
        /// Returnerer gennemsnittet af tal i a som en double.
        /// Fejl hvis a er tom (længde på 0). Undgår at beregne
        /// summen af alle tallene - brug derfor denne, hvis der
        /// er mange tal eller store tal
        /// </summary>
        double Average2(int[] a) {
            double res = a[0];

            for (int i=1; i < a.Length; i++)
            {
                double f = i;
                res = (f / (f + 1)) * res + (1 / (f + 1)) * a[i];
            }
            return res;
        }


    }
}

