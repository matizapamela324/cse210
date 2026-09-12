using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num =-1;
        while (num!=0)
        {
            Console.Write("Enter number:");
            num =int.Parse(Console.ReadLine());
            if (num!=0) numbers.Add(num);
        }
        int sum = 0;
        int max = 0;
        foreach (int n in numbers)
        {
            sum += n;
            if (n>max) max = n;
        } 
        float avg = (float)sum/numbers.Count;
        Console.WriteLine($"The sum is:{sum}");
        Console.WriteLine($"The average is:{avg}");
        Console.WriteLine($"The largest number is:{max}");
    }
}