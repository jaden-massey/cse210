using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade as a percent? ");
        string gradePercent = Console.ReadLine();
        var gradeDecimal = decimal.Parse(gradePercent.TrimEnd(new char[] { '%', ' ' } ) ) / 100M;
        
        var gradeLetter = "";
        var gradeSymbol = "";

        // determine letter grade
        if(gradeDecimal >= 0.9m)
        {
            gradeLetter = "A";
        }
        else if (gradeDecimal >= 0.8m)
        {
            gradeLetter = "B";
        }
        else if (gradeDecimal >= 0.7m)
        {
            gradeLetter = "C";
        }
        else if (gradeDecimal >= 0.6m)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // determine -, nothing, or +
        decimal symbolDeterminer = (gradeDecimal % 0.1m);
        
        if (symbolDeterminer >= 0.07m && gradeLetter != "A" && gradeLetter != "F")
        {
            gradeSymbol = "+";
        }
        else if (symbolDeterminer <= 0.03m && gradeLetter != "F")
        {
            gradeSymbol = "-";
        }

        Console.WriteLine($"\nYour current letter grade is: {gradeLetter}{gradeSymbol}");

        if (gradeDecimal >= .7m)
        {
            Console.WriteLine("Congratulations, you are passing the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you are not passing the class at this time, please work harder to get your grade up!");
        }
        
    }
}