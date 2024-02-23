using System;
namespace Modul6
{
    public class Opgave6_2
    {
        public void Run()
        {
            Console.WriteLine("Indtast karaktere - afslut med -1:");
            List<int> grades = new();
            
            int count = 0;
            while (true)
            {
                int input =  ReadInt($"Hvad er karakter nr {count + 1}:");
                if (input == -1)
                    break;
                count++;
                grades.Add(input);
            }
            Console.WriteLine($"Gennemsnit: {Average(grades)}");

            int[] theGrades = { -3, 0, 2, 4, 7, 10, 12 };

            foreach (var aGrade in theGrades)
            {
                var c = Count(grades, aGrade);
                if (c > 0)
                    Console.WriteLine($"Antal af {aGrade} er {c}");
            }
        }

        /// <summary>
        /// Returnerer gennemsnittet af tal i a som en double.
        /// Fejl hvis a er tom (længde på 0).
        /// </summary>
        double Average(List<int> a)
        {
            double sum = 0;
            foreach (int value in a)
                sum += value;
            return sum / a.Count;
        }


        int ReadInt(string pretext = "")
        {
            Console.Write(pretext);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Return the number og [key] in [a]
        /// </summary>
        int Count(List<int> a, int key)
        {
            int res = 0;
            foreach (var v in a)
                if (key == v) res++;
            return res;
        }
    }
}

