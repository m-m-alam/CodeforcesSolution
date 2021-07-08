using System;

namespace _231_A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int Petya, Vasya, Tonya, result=0;
            int problem = Int32.Parse(Console.ReadLine());
            for(int i=0; i < problem; i++)
            {
                var input = Console.ReadLine().Split(" ");
                Petya = Convert.ToInt32(input[0]);
                Vasya = Convert.ToInt32(input[1]);
                Tonya = Convert.ToInt32(input[2]);
                if (Petya + Vasya + Tonya >= 2)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
