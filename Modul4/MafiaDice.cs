using System;
namespace Modul4
{
    public class MafiaDice
    {
        private Dice d;
        private int counter;
        public MafiaDice()
        {
            d = new Dice();
        }

        public void Roll() {
            d.Roll();
            counter++;
            if (counter == 10)
            {
                counter = 0;
                if (d.Eyes != 6)
                    d.Roll();
            }
        }

        public int Eyes => d.Eyes;
    }
}

