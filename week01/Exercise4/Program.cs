using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int newNum = int.Parse(input);
        int total = 0;
        int largestNum = -100;

        while (newNum != 0)
        {
            numbers.Add(newNum);
            total += newNum;

            if (largestNum < newNum)
            {
                largestNum = newNum;
            }

            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            newNum = int.Parse(input);

        }

        float amountOfNumbers = numbers.Count;
        float average = total / amountOfNumbers;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}