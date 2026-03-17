using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter numbers (separated by space)");
        
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int[] numbers = Array.ConvertAll(parts, int.Parse);

            Console.WriteLine("Sum: " + StatisticsHelper.CalculateSum(numbers));
        }
        catch (Exception)
        {
            Console.WriteLine("an error occured");
        }
        
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