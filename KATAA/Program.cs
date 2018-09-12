using System;

namespace KATAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new FindTheOddInt().find_it(new[] { 1, 5, -1, 2, -2, 3, 3, 20, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Console.Read();

        }
    }
}   
    