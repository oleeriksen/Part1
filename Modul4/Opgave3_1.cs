using System;
namespace Modul4
{
    public class Opgave3_1
    {

        public void Run() {
            int[] data = { 3, 3, 5, 5 };
            var avg = Average(data);
            Console.WriteLine($"Gennemsnit er {avg}");
            Console.WriteLine($"Varians er {Varians(data)}");

        }

        /// <summary>
        /// Returnerer gennemsnittet af tal i a som en double.
        /// Fejl hvis a er tom (længde på 0).
        /// </summary>
        double Average(int[] a) {
            double sum = 0;
            foreach (int value in a)
                sum += value;
            return sum/a.Length;
        }

        double Varians(int[] a) {
            double sum = 0;
            var avg = Average(a);
            foreach (int value in a)
                sum += Math.Pow(value- avg, 2);
            return sum / a.Length;
        }

        double Derivation(int[] a) {
            return Math.Sqrt(Varians(a));
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

