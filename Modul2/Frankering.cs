using System;
namespace Modul2
{
    public class Frankering
    {
        public void Run() {

            for (int amount = 8; amount < 200; amount++) {
                var stamps = FindHowMany(amount);
                Console.WriteLine($"Amount {amount}  3cent: {stamps[0]}, 5cent: {stamps[1]}");
            }

        }

        // will return how manuy 3 and 5 cents are needed to
        // frank amount cents. result[0] is the number of 3 cents,
        // and result[1] is the number of 5 cents.
        int[] FindHowMany(int amount) {
            var res = new int[2];
            res[0] = amount / 3;
            res[1] = 0;
            var rest = amount % 3;
            switch (rest) {
                case 1:
                    // remove 3 3cent, and add 2 5cent
                    res[0] = res[0] - 3;
                    res[1] = 2;
                    break;
                case 2:
                    // remove 1 3cent, and add 1 5cent
                    res[0]--;
                    res[1] = 1;
                    break;
            }
            return res;
        }
    }
}

