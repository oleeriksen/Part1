using System;
namespace Modul4
{
    public class MafiaDice
    {
        private Dice d;
        public MafiaDice()
        {
            d = new Dice();
        }

        public void Roll() {
            d.Roll();
            if (d.Eyes != 6)
                d.Roll();
        }

        public int Eyes => d.Eyes;
    }
}

