using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers (separated by space)");
        
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int[] numbers = Array.ConvertAll(parts, int.Parse);

        Console.WriteLine("Sum: " + StatisticsHelper.CalculateSum(numbers));
    }
}

class StatisticsHelper
{
    public static int CalculateSum(int[] values)
    {
        int sum = 0;
        foreach (var v in values)
        {
            sum += v;
        }
        return sum;
    }
}