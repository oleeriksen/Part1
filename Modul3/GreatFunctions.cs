using System;
namespace Modul3
{
    public class GreatFunctions
    {

        public void Run() {
            int a = ReadInt("Indtast tal: ");
            int b = ReadInt();
        }

        public bool IsValid(string cpr) {
            return true;
        }

        public int GetFitnessLevel(int age, int rest) {
            return 0;
        }

        public int ReadInt(string leadingText ="") {
            return 0;
        }

        public DateTime GetSunrise(DateOnly date, double lat, double lgd) {
            return DateTime.Now;
        }
    }
}

