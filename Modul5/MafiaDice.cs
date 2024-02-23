using System;
namespace Modul5
{
    public class MafiaDice
    {
        private Dice mFairDice;

        private int mEyes;

        public MafiaDice()
        {
            mFairDice = new Dice();
        }

     
        public void Roll() {
            mFairDice.Roll();
            if (mFairDice.Eyes() != 6) {
                mFairDice.Roll();
            }
        }

        public int Eyes() {
            return mFairDice.Eyes();
        }
    }
}

