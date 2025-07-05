using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool correctGuess = false;

        while (correctGuess == false)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                correctGuess = true;
            }
            else if (guess > number)
            {
                Console.WriteLine("lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("higher");
            }
        } 
    }
}