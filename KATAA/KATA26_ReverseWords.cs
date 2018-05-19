using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KATAA.KATA
{
    public class Kata26ReverseWords
    {
       
        public string ReverseWords(string str)
        {
            var strings =  str.Split(' ');
            var result = "";
            foreach (var splitstring in strings)
            {
                result = result + reverse(splitstring)+" ";
            }

            return result.Trim();
        }

        private string reverse(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }

}
