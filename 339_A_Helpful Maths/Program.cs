using System;

namespace _339_A_Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = Console.ReadLine().Split("+");            
             Array.Sort(math);
            var result = string.Join("+", math);
            Console.WriteLine(result);
        }
    }
}
