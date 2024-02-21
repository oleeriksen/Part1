using System;
namespace Modul4
{
    public class Opgave4_2
    {
        public void Run() {
            int count = ReadInt("Hvor mange karaktere er der?");
            int[] grades = new int[count];
            for (int i = 0; i < count; i++) {
                grades[i] = ReadInt($"Hvad er karakter nr {i+1}:");
            }
            Console.WriteLine($"Gennemsnit: {Average(grades)}");

            int[] theGrades = { -3, 0, 2, 4, 7, 10, 12 };

            foreach (var aGrade in theGrades) {
                var c = Count(grades, aGrade);
                if (c > 0)
                    Console.WriteLine($"Antal af {aGrade} er {c}");
            }
        }

        /// <summary>
        /// Returnerer gennemsnittet af tal i a som en double.
        /// Fejl hvis a er tom (længde på 0).
        /// </summary>
        double Average(int[] a)
        {
            double sum = 0;
            foreach (int value in a)
                sum += value;
            return sum / a.Length;
        }


        int ReadInt(string pretext = "") {
            Console.Write(pretext);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Return the number og [key] in [a]
        /// </summary>
        int Count(int[] a, int key) {
            int res = 0;
            foreach (var v in a)
                    if (key == v) res++;
            return res;
        }
    }
}

