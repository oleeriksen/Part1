using System;
namespace Modul5
{
    public class DiceApp
    {
        public void Run() {
            Dice d = new Dice(8);

       

            for (int i = 0; i < 100; i++)
            {
                d.Roll();
                var e = d.Eyes();
                Console.WriteLine($"{e}");
            }
        }
    }
}

