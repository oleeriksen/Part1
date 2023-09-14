using System;
namespace Modul5
{
    public class Opgave5_2
    {
        public void Run()
        {
            DiceCupV2 dc = new DiceCupV2(7);
            for (int i = 0; i < 10; i++) {
                dc.Twist();
                var eyes = dc.Eyes;
                Console.WriteLine("[" + string.Join(",", eyes.Select(e => "" + e))+"]");
            }
        }
    }
}

