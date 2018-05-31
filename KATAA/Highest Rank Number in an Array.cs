using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATAA
{
    public class HighestRankNumberInAnArray
    {
        public  int HighestRank(int[] arr)
        {
            //orderby 後可以用thenby 再去篩選IOrderedEnumerable裡的東西
            //return  arr.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenByDescending(y=>y.Key).ToList().First().Key;
            var max = arr.GroupBy(x => x)
                .Max(g => g.Count());
            var query = arr.GroupBy(x => x)
                .Where(g => g.Count()>=max )
                .Select(y => y.Key).Max(z=>z);
            return query;
           
        }
    }
}