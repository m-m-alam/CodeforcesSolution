using System;
using System.Linq;

namespace _281_A_Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string capitalization = word.First().ToString().ToUpper() + word.Substring(1);
            Console.WriteLine(capitalization);
        }
    }
}
