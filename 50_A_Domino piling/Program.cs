using System;

namespace _50_A_Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var m = Convert.ToInt16(input[0]);
            var n = Convert.ToInt16(input[1]);
            int result = (m * n) / 2;
            Console.WriteLine(result);
        }
    }
}
