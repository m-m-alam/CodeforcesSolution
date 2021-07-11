using System;

namespace _112_A_Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsString = Console.ReadLine();
            var secondString = Console.ReadLine();            
            var result = string.Compare(firsString.ToLower(), secondString.ToLower());
            Console.WriteLine(result);
        }
    }
}
