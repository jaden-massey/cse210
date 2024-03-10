using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write($"{number}");

        int guess = 0;
        bool guessed = false;

        while (guessed == false)
        { 

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
            guessed = true;
            Console.WriteLine("You guessed the number!");
            }
        }
    }
}