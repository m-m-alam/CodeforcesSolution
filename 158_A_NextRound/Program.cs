using System;

namespace _158_A_NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            int nextRound = 0;
            int n = Int32.Parse(input[0]);
            int k = Int32.Parse(input[1]);
            var score = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                if (Int32.Parse(score[i])>0 && Int32.Parse(score[i]) >= Int32.Parse(score[k-1]))
                {
                    nextRound++;
                }

            }
            Console.WriteLine(nextRound);
        }
    }
}
