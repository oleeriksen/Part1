using System;
namespace Modul2
{
    public class Frankering
    {
        public void Run()
        {

            for (int amount = 8; amount < 100; amount++)
            {
                var stamps = FindHowManyV2(amount);
                Console.WriteLine($"Amount {amount}  3cent: {stamps[0]}, 5cent: {stamps[1]}");
            }

        }

        /// <summary> will return how many 3 and 5 cents are needed to
        /// frank amount cents. result[0] is the number of 3 cents,
        /// and result[1] is the number of 5 cents. Based on using
        /// 3cent primary</summary> 
        int[] FindHowMany(int amount)
        {
            int antal3 = 0, antal5 = 0;
            antal3 = amount / 3;
            var rest = amount % 3;
            switch (rest)
            {
                case 1:
                    // remove 3 3cent, and add 2 5cent
                    antal3 -= 3;
                    antal5 = 2;
                    break;
                case 2:
                    // remove 1 3cent, and add 1 5cent
                    antal3--;
                    antal5 = 1;
                    break;
            }
            return new int[] { antal3, antal5};
        }

        /// <summary> will return how many 3 and 5 cents are needed to
        /// frank amount cents. result[0] is the number of 3 cents,
        /// and result[1] is the number of 5 cents. Based on using
        /// 5 cent primary</summary> 
        int[] FindHowManyV2(int amount)
        {
            int antal3 = 0, antal5 = 0;
            antal5 = amount / 5;
            var rest = amount % 5;
            switch (rest)
            {
                case 1:
                    // remove 1 5cent, and add 2 3cent
                    antal5--;
                    antal3 = 2;
                    break;
                case 2:
                    // remove 2 5cent, and add 4 3cent
                    antal3 = 4;
                    antal5 -= 2;
                    break;
                case 3:
                    // add 1 3 cent
                    antal3 = 1;
                    break;
                case 4:
                    // remove 1 5cent, and add 3 3cent
                    antal5--;
                    antal3 = 3;
                    break;
            
            }
            return new int[] { antal3, antal5 };
        }
    }
}

