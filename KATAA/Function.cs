using System;
using System.Collections.Generic;
using System.Linq;

namespace KATAA
{
    public class line
    {
        public line(double a,double b)
        {
            A = a;
            B = b;
        }
        public  double A{ get; set ; }
        public  double B{ get; set; }
    }
    
    public class Function
    {
        
        private static readonly List<double> responsenull = new List<double>{-99,-99};
        public static List<double> interpoint(line line1, line line2)
        {
            if (line1.A >= line2.A&&line1.B>=line2.B)
            {
                return responsenull;
            }
            if (line1.A <= line2.A && line1.B <= line2.B)
            {
                return responsenull;
            }
            var t = (-1 * (line1.B - line2.B)) / (line1.A - line2.A);
            var y1 = line1.A * t+line1.B;
            var y2 = line2.A * t+line2.B;
            Double y_1 = Math.Round(y1, 6, MidpointRounding.AwayFromZero);
            Double y_2 = Math.Round(y2, 6, MidpointRounding.AwayFromZero);
            List<double> response = new List<double> { t, y1 };
            return y_1 != y_2 ? responsenull : response;
        }

        public static int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            var interpointlist = new List<List<double>>();       //y = speed[i]*t+startposition[i];
            var list = CreateLine(StartPosition, speed);
            var max = 0;
            Getinterpoints(list, interpointlist);

            if (interpointlist.All(x => x==responsenull))    //All is parallel
            {
                return -1;
            }

            max = CheckInterpoint(interpointlist, max);
            return max == 0 ? 2 : max + 1;
        }

        private static int CheckInterpoint(List<List<double>> interpointlist, int max)
        {
            for (int i = 0; i < interpointlist.Count; i++)
            {
                var count = 0;
                for (int j = i + 1; j < interpointlist.Count; j++)
                {
                    if (interpointlist[i] == responsenull)
                    {
                        break;
                    }
                    else
                    {
                        if (interpointlist[i][0] == interpointlist[j][0]
                            && interpointlist[i][1] == interpointlist[j][1])
                        {
                            count++;
                        }
                    }
                }

                max = count > max ? count : max;
            }

            return max;
        }

        private static List<line> CreateLine(int[] StartPosition, int[] speed)
        {
            var list = new List<line>();
            for (int i = 0; i < StartPosition.Length; i++)
            {
                list.Add(new line(Convert.ToDouble(speed[i]), Convert.ToDouble(StartPosition[i])));
            }
            return list;
        }

        private static void Getinterpoints(List<line> list, List<List<double>> interpointlist)
        {
            for (int i = 0; i < list.Count; i++) //get interpoint
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    interpointlist.Add(interpoint(list[i], list[j]));
                }
            }
        }

        public static int findCombinationsCount(int amount, int[] coins)
        {
            return findCombinationsCount2(amount, coins, 0);
        }

        public static int findCombinationsCount2(int amount, int[] coins, int checkFromIndex)
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
