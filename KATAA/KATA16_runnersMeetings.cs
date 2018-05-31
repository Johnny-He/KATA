using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace KATAA
{
    class KATA16_runnersMeetings
    {
        public class Runner
        {
            public Runner(double rate, double originPos)
            {
                Rate = rate;
                OriginPos = originPos;
            }
            public double Rate { get; set; }
            public double OriginPos { get; set; }
        }

        public class MeetingPoint
        {
          /*  public MeetingPoint(Runner runner1,Runner runner2)
            {
               
            }
            public double meetingTime { get; set; }
            public double AfterPos { get; set; }*/
        }
        private static readonly List<double> responsenull = new List<double> { -99, -99 };

        public static List<double> interpoint(Runner runner1, Runner runner2)
        {
            if (runner1.Rate >= runner2.Rate && runner1.OriginPos >= runner2.OriginPos)
            {
                return responsenull;
            }
            if (runner1.Rate <= runner2.Rate && runner1.OriginPos <= runner2.OriginPos)
            {
                return responsenull;
            }
            var meetingTime = (-1 * (runner1.OriginPos - runner2.OriginPos)) / (runner1.Rate - runner2.Rate);
            var y1 = runner1.Rate * meetingTime + runner1.OriginPos;
            var y2 = runner2.Rate * meetingTime + runner2.OriginPos;
            Double y_1 = Math.Round(y1, 6, MidpointRounding.AwayFromZero);
            Double y_2 = Math.Round(y2, 6, MidpointRounding.AwayFromZero);
            var response = new List<double> { meetingTime, y1 };
            return y_1 != y_2 ? responsenull : response;
        }

        public static int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            var interpointlist = new List<List<double>>();       //y = speed[i]*t+startposition[i];
            var runners = CreateLine(StartPosition, speed);
            Getinterpoints(runners, interpointlist);

            if (interpointlist.All(x => x == responsenull))    //All is parallel
            {
                return -1;
            }

            return CheckInterpoint(interpointlist) == 0 ? 2 : CheckInterpoint(interpointlist) + 1;
        }

        private static int CheckInterpoint(List<List<double>> interpointlist)
        {
            var max = 0;
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

        private static List<Runner> CreateLine(int[] StartPosition, int[] speed)
        {
            var Runners = new List<Runner>();
            for (int i = 0; i < StartPosition.Length; i++)
            {
                Runners.Add(new Runner(Convert.ToDouble(speed[i]), Convert.ToDouble(StartPosition[i])));
            }
            return Runners;
        }

        private static void Getinterpoints(List<Runner> runners, List<List<double>> interpointlist)
        {
            for (int i = 0; i < runners.Count; i++) //get interpoint
            {
                for (int j = i + 1; j < runners.Count; j++)
                {
                    interpointlist.Add(interpoint(runners[i], runners[j]));
                }
            }
        }
    }
}
