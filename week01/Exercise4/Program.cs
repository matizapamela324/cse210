using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositiveNumber = 0;

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (smallestPositiveNumber == 0 || num < smallestPositiveNumber)
                {
                    smallestPositiveNumber = num;
                }
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort();

        Console.WriteLine("The sorted numbers are:");

        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}