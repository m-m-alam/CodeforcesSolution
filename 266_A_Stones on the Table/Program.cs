using System;

namespace _266_A_Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {            
            int testCase = int.Parse(Console.ReadLine());
            string stone = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < testCase-1; i++)
            {
                if (stone[i] == stone[i + 1])
                    count++;
            }            
            Console.WriteLine(count);
        }
    }
}
