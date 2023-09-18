using System;
namespace Modul7
{
    public class DiceCup
    {
        private List<Dice> mDices;
        public DiceCup()
        {
            mDices = new List<Dice>
            {
                new Dice(),
                new Dice()
            };
        }

        public void Twist() {
            foreach (Dice d in mDices)
                d.Roll();
        }

        public int[] Eyes {
            get {
                return new int[2] { mDices[0].Eyes, mDices[1].Eyes };
            }
        }
    }
}

