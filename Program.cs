using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            Console.WriteLine(result);
        }
    }
}
