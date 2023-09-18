using System;
namespace Modul7
{
    public class Dice : IComparable<Dice>
    {
        private int size;
        private int eyes;
        private Random random;
        public Dice(int size = 6)
        {
            this.size = size;
            random = new Random();
           
        }

        public virtual void Roll()
        {
            eyes = random.Next(1, size + 1);
        }

        public int CompareTo(Dice? other)
        {
            if (other == null) return 1;
            return -Eyes.CompareTo(other.Eyes);
        }

        public virtual int Eyes
        {
            get
            {
                return eyes;
            }
        }
    }
}

