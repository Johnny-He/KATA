using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace KATAA.KATA
{
    public class KATA19_CarEscape
    {
        public static string[] escape(int[,] carpark)
        {            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                   Console.Write(carpark[i,j]+" ");
                }
                Console.WriteLine();
            }

            int lastlength = carpark.GetLength(0) - 1;
            int begin = 0;
            var target = 0;
            var result2 = new List<string>();
            string[] result = new string[carpark.Length * 2];
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 2)
                    {
                        begin = j;
                    }
                    else if (carpark[i, j] == 1)
                    {
                        target = j;
                    }
                }

                if (lastlength == i)
                {
                    var last = carpark.GetLength(1) - 1;
                    if (last - begin > 0)
                    {
                        result2.Add("R" + (last - begin).ToString());
                    }
                    break;
                }
                if (begin - target > 0)
                {
                    result2.Add("L" + (begin - target).ToString());
                }
                else if (begin - target < 0)
                {
                    result2.Add("R" + ((begin - target) * -1).ToString());
                }
                if (result2.Last()[0]=='D')
                {
                    result2[result2.Count - 1] = "D" + (result2.Last()[1] - 48 + 1).ToString();
                }
                else
                {
                    result2.Add("D1");
                }
                begin = target;
            }
            return result2.ToArray();
        }
        
    }
  
}
