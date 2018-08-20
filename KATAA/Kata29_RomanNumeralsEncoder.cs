using System;
using System.Collections.Generic;
using System.Linq;

namespace KATAA
{
    public class Kata29_RomanNumeralsEncoder
    {

        public string Solution(int n)
        {
            var dic = new Dictionary<int, char>()
            {
                {1,'I'},
                {5,'V'},
                {10,'X'},
                {50,'L'},
                {100,'C'},
                {500,'D'},
                {1000,'M'}
            };
            var charArray = n.ToString().ToCharArray();
            String ans = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                var number = (int)((charArray[i] - 48) * Math.Pow(10, charArray.Length - 1 - i));
                if (number < 1000)
                {
                    switch (number)
                    {
                        case 900:
                            ans += "CM";
                            break;
                        case 400:
                            ans += "CD";
                            break;
                        case 90:
                            ans += "XC";
                            break;
                        case 40:
                            ans += "XL";
                            break;
                        case 9:
                            ans += "IX";
                            break;
                        case 4:
                            ans += "IV";
                            break;
                        default:
                            var index = dic.Where(x => x.Key <= number).ToList().Count-1;

                            while (index >= 0 && number > 0)
                            {
                                if (number >= dic.ElementAt(index).Key)
                                {
                                    number = number - dic.ElementAt(index).Key;
                                    ans += dic.ElementAt(index).Value.ToString();
                                }
                                else
                                {
                                    index--;
                                }

                            }
                            break;
                    }
                }
                else
                {
                    for (int j = 0; j < number / 1000; j++)
                    {
                        ans += "M";
                    }
                }
            }

            return ans;
        }

    }


}

