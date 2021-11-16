using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret_number = new Random().Next(0, 100);
            for (int i = 4; i > 0; i--)
            {
                Console.Write("Guess the secret number: ");
                string input = Console.ReadLine();
                Console.WriteLine($"Your guess is {input}. ");
                Console.WriteLine($" You have {i - 1} guesses left");
                int result = Int32.Parse(input);
                if (result == secret_number)
                {
                    Console.WriteLine("Success, you guessed the secret number!");
                    break;
                }
                else if (secret_number > result)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else
                {

                    Console.WriteLine($"Your guess is too low! ");
                }
            }
        }
    }
}
///Move logic for guess into a function, so that it can run 4 times unless the user guess correctly. 