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
            int secret_number = 42;
            if (result == secret_number)
            {
                Console.WriteLine("Success, you guessed the secret number!");
            }
            else
            {
                Console.WriteLine("Failure");
            }
        }
    }
}
