using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers (separated by space)");
        
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int[] numbers = Array.ConvertAll(parts, int.Parse);

        Console.WriteLine("You entered:");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}