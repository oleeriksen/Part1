using System;
namespace Modul7
{
    public class MafiaDice : Dice
    {
        private Dice d;
        private int counter;
        public MafiaDice()
        {
            d = new Dice();
        }

        public override void Roll() {
            d.Roll();
            counter++;
            if (counter == 1)
            {
                counter = 0;
                if (d.Eyes != 6)
                    d.Roll();
            }
        }

        public override int Eyes => d.Eyes;
    }
}

