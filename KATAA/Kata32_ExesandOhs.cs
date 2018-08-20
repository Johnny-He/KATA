using System.Linq;

namespace KATAA
{
    public class Kata32_ExesandOhs
    {
        public bool XO(string input)
        {
            return input.Count(x => x == 'o' || x == 'O')== input.Count(x => x == 'x' || x == 'X');
        }
    }
}
