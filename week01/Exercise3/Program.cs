using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string response = "yes";
        Random random = new Random();

        while (response == "yes")
        {
            int counter = 0;
            int guess = 0;

            int magicNumber = random.Next(1, 101);

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                counter++;

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {counter} guesses.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high.");
                }
            }

            Console.Write("Do you want to play again? (yes / no): ");
            response = Console.ReadLine().ToLower();
        }
    }
}