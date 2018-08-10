using System;

namespace KATAA
{
    public class Kata30_MaximumLengthDifference
    {
        public int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1 == null || a2 == null)
            {
                return -1;
            }
            var max = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    max = max < Math.Abs(a1[i].Length - a2[j].Length) ? Math.Abs(a1[i].Length - a2[j].Length) : max;
                }
            }

            return max;
        }
    }
}
