using System;

namespace _263_A_Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                string[] value = input.Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    if (value[j] == "1")
                    {
                        Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
                        return;
                    }
                }
            }
        }
    }
}
