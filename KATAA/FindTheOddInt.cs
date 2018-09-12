using System.Collections.Generic;
using System.Linq;

namespace KATAA
{
    public class FindTheOddInt
    {
        private List<int> temp = new List<int>();

        public int find_it(int[] seq)
        {
            var list = seq.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (!temp.Contains(list[i]))
                {
                    var count = list.Count(x => x.Equals(list[i]));
                    if (count % 2 == 1)
                    {
                        return list[i];
                    }
                    temp.Add(list[i]);
                }
            }

            return -1;
        }

       
    }
}
