using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
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
}
///Move logic for guess into a function, so that it can run 4 times unless the user guess correctly. 