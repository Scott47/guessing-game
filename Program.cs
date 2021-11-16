using System;

Main();
void Main()
{
    Console.WriteLine("Let's play guess the secret number! What level of difficulty would you like to choose? Easy, medium, hard, or cheater?");
    string response = Console.ReadLine();
    GuessController(response);

}
void GuessController(string difficultyChoice)
{
    int numberOfGuesses = 0;
    if (difficultyChoice == "cheater")
    {
        Convert.ToInt32(difficultyChoice);
    }
    else if (difficultyChoice == "easy")
    {
        numberOfGuesses = 8;
    }
    else if (difficultyChoice == "medium")
    {
        numberOfGuesses = 6;
    }
    else if (difficultyChoice == "hard")
    {
        numberOfGuesses = 4;
    }
    else
    {
        numberOfGuesses = 0;
        Console.WriteLine("Invalid response. Please try again.");
        Main();
    }
    Game(numberOfGuesses);
}
void Game(int allowedGuesses)
{
    Console.WriteLine("What do you think it is? Take your first guess.");

    string prompt = "What do you think it is?";
    int answer = Convert.ToInt32(Console.ReadLine());
    int secretNumber = new Random().Next(1, 100);
    int attemptedGuesses = 1;


    while (attemptedGuesses != allowedGuesses)
    {
        if (secretNumber == answer)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (secretNumber < answer)
        {
            Console.WriteLine("Oh no, I'm sorry... That's too high. Guess again.");
            Console.WriteLine($"{prompt} Guesses left: {allowedGuesses - attemptedGuesses}");
            answer = Convert.ToInt32(Console.ReadLine());
            attemptedGuesses++;
        }
        else if (secretNumber > answer)
        {
            Console.WriteLine("Oh no, I'm sorry... That's too low. Guess again.");
            Console.WriteLine($"{prompt} Guesses left: {allowedGuesses - attemptedGuesses}");
            answer = Convert.ToInt32(Console.ReadLine());
            attemptedGuesses++;
        }
    }

    if (attemptedGuesses == allowedGuesses)
    {
        Console.WriteLine("I'm sorry, you're out of guesses. Better luck next time!");
    }
}

///Move logic for guess into a function, so that it can run 4 times unless the user guess correctly. 