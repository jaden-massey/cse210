using System;

class Program
{
    static void Main(string[] args)
    {

        // initialize variables & lists
        int input = 0;
        int sum = 0;

        List<int> numbers = new List<int>();

        // generate list, add user inputs until 0 is enetered
        do
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }   

        } while (input != 0);

        // calc sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        // calc average
        float average =  (float)sum / (numbers.Count);


        // get max
        int max = numbers.Max();

        // print results to user
        Console.WriteLine($@"
The sum is: {sum}
The average is: {average}
The largest number is: {max}");

    }
}