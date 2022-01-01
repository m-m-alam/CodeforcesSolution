using System;
using System.Collections.Generic;
using System.Linq;

namespace _236_A_Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();            
            var boyOrGirl = name.Distinct().Count();
            if (boyOrGirl % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
            
        }
    }
}
