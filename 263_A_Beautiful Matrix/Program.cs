using System;

namespace _263_A_Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                     x[i,j] = Int16.Parse(Console.ReadLine());
                }
                //Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                     if(x[i,j] == 1)
                    {
                        var result =   2-i + 2 - j;
                        Console.WriteLine(result);
                    }
                }
            }

            //Console.WriteLine();
        }
    }
}
