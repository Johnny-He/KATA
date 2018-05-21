using System;
using System.Collections.Generic;
using System.Text;

namespace KATAA
{
    class KATA22_CountCombinations
    {
        public static int findCombinationsCount(int amount, int[] coins)
        {
            return findCombinationsCount2(amount, coins, 0);
        }

        public static int findCombinationsCount2(int amount,  int[] coins, int checkFromIndex)
        {
            if (amount == 0)
            {
                return 1;
            }
            else if (amount < 0 || coins.Length == checkFromIndex)
            {
                return 0;
            }
            else
            {
                int withFirstCoin = findCombinationsCount2(amount - coins[checkFromIndex], coins, checkFromIndex);
                int withoutFirstCoin = findCombinationsCount2(amount, coins, checkFromIndex + 1);
                return withFirstCoin + withoutFirstCoin;
            }
        }
    }
}
