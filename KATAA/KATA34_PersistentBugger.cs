using System;
using System.Collections.Generic;
using System.Linq;

namespace KATAA
{
    public class KATA34_PersistentBugger
    {
        public  int Persistence(long n)
        {
            var intlist = n.ToString().Select(x => Convert.ToInt32(x.ToString())).ToList();
            var count = 0;
            while (intlist.Count>1)
            {
                var sum = intlist.Aggregate(1, (current, t) => current * t);
                count++;
                intlist = sum.ToString().Select(x => Convert.ToInt32(x.ToString())).ToList();
            }

            return count;

        }

      
    }
}
