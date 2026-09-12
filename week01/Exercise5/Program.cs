using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        double squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static double SquareNumber(int number)
        {
            double squared = Math.Pow(number, 2);
            return squared;
        }

        static void DisplayResult(string name, double squared)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squared}.");
        }
}