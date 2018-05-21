using System;
using System.Collections.Generic;
using System.Text;

namespace KATAA
{
    class KATA4
    {
        public static int Duplicates(string input)
        {
            int point = 0;
            string upperstring = input.ToUpper();
            char[] temp = new char[input.Length];
            for (int i = 0; i < upperstring.Length; i++)
            {
                var k = 0;
                for (int j = 0; j < point; j++)
                {
                    if (upperstring[i] == temp[j])
                    {
                        k = 1;
                    }
                }

                if (k == 0)
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (upperstring[i] == upperstring[j])
                        {
                            temp[point] = upperstring[i];
                            point++;
                            break;
                        }
                    }
                }


            }
            return point;
        }
    }
}
