using System;
namespace Modul3
{
	public class Opgave3_2
	{
		public void Run() {
			Console.Write("Hvor mange karaktere:");
			int amount = Convert.ToInt32(Console.ReadLine());
			int[] grades = new int[amount];
			for (int i = 0; i < amount; i++) {
				Console.Write($"Intast karakter nr {i+1}: ");
				grades[i] = Convert.ToInt32(Console.ReadLine());
            }
			var avg = Average(grades);
			Console.WriteLine($"Gennemsnit: {avg}");
			// udskriver fordeling
			int[] allGrades = { -3, 0, 2, 4, 7, 10, 12 };

            foreach (var g in allGrades) {
				int count = CountGrades(g, grades);
				Console.WriteLine($"Antal {g}: {count}");
			}	
		}

        private int CountGrades(int aGrade, int[] grades)
        {
			int count = 0;
			foreach (int g in grades) {
				if (g == aGrade)
					count++;
			}
			return count;
			//return grades.Count(g => g == aGrade);
        }

        double Average(int[] a)
        {
			double sum = 0;
			foreach (int g in a)
				sum += g;
			return sum / a.Length;
		}

    }

}

