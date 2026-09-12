using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter grade as percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string result = "";

        if (grade >= 90)
        {
            if (grade >= 93)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade >= 83)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade >= 73)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade >= 63)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (grade >= 70)
        {
            result = "Congratulations! You passed!";
        }
        else
        {
            result = "Sorry, you did not pass. Better luck next time!";
        }

        Console.WriteLine(result);
    }
}