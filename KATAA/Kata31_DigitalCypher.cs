using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace KATAA
{
    public class Kata31_DigitalCypher
    {
        public int[] Encode(string str, int n)
        {
            var nums = n.ToString().ToList();
            var anslist = new List<int>();
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                anslist.Add(str[i] - 144 + nums[j]);
                j++;
                if (j == nums.Count)
                {
                    j = 0;
                }
            }
            return anslist.ToArray();
        }
        public string Decode(int[] array, int n)
        {

            return null;
        }
    }
}
