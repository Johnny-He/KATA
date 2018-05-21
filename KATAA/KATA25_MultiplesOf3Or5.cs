using System;
using System.Collections.Generic;
using System.Text;

namespace KATAA
{
    class KATA25_Multiples_of3or5
    {
        public static int Solution(int  value)
        {
            int sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
