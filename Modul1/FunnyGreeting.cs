using System;
namespace Modul1
{
    public class FunnyGreeting
    {
        public void Run() {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            DateTime now = DateTime.Now;

            string greetingTime = "";

            if (now.Hour < 12)
                greetingTime = "morning";
            else
            if (now.Hour < 18)
                greetingTime = "afternoon";
            else
                greetingTime = "evening";

            Console.WriteLine($"Good {greetingTime} {name} - have a nice day!");

            

            Console.WriteLine($"The hour is {now.Hour}");

        }

        private int ReadInt() {
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}

