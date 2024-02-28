using System;
namespace Modul6
{
    public class DiceCup
    {
        private List<Dice> mDices;

        public DiceCup(int amount = 2)
        {
            mDices = new List<Dice>();
            for (int i=0; i < amount; i++)
                 mDices.Add(new Dice());
        }

        public void Shake() {
            foreach (Dice aDice in mDices)
                aDice.Roll();
        }

        public List<int> Eyes() {
            List<int> result = new();
            foreach (Dice aDice in mDices)
                  result.Add(aDice.Eyes());
         
            return result;

        }
    }
}

