using System;
using System.Collections.Generic;
using System.Text;

namespace KATAA
{
    public class KATA24_FindMissing
    {
        public int FindMissing(List<int> list)
        {

            var perdifferent = (list[list.Count - 1]- list[0]) / (list.Count + 1 - 1);
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] + perdifferent != list[i + 1])
                {
                    return list[i] + perdifferent;
                }
            }
            return -99;
        }
    }
}
