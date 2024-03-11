using System;

class Program
{
    static void Main(string[] args)
    {
        // define functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        static double SquareNumber(int number)
        {
            return Math.Pow(number, 2);
        }

        static void DisplayResult()
        {
            Console.WriteLine($"{PromptUserName()}, the square of your number is {SquareNumber(PromptUserNumber())}");
        }

        DisplayWelcome();
        DisplayResult();
    }
}