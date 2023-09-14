using System;
namespace Modul5
{
    public class DiceCupV2
    {
        private List<Dice> mDices;
        public DiceCupV2(int amount = 2)
        {
            mDices = new List<Dice>();
            for (int i = 0; i < amount; i++)
                mDices.Add(new Dice());
        }

        public void Twist()
        {
            foreach (Dice d in mDices)
                d.Roll();
        }

        public int[] Eyes
        {
            get
            {
                var res = mDices.Select(d => d.Eyes);
                return res.ToArray();
            }
        }
    }
}

