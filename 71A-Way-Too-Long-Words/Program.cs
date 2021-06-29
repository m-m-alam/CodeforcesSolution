using System;

namespace _71A_Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                var word = Console.ReadLine();
                if (word.Length > 10)
                {
                    var result = word[0] + (word.Length - 2).ToString() + word[word.Length - 1];                    
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(word);
                }
                n--;
            }
        }
    }
}
