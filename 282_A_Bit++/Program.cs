using System;

namespace _282_A_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var statement = Console.ReadLine();
                if (statement == "++X" || statement == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine(x);
            
        }
    }
}
