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

            Console.WriteLine("Average: " + StatisticsHelper.CalculateAverage(numbers));

            Console.WriteLine("Max: " + StatisticsHelper.CalculateMax(numbers));
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

    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0) return 0;

        int sum = CalculateSum(values);
        return (double)sum / values.Length;   
    }

    public static int CalculateMax(int[] values)
    {
    int max = values[0];
    foreach (var v in values)
        {
        if (v > max)
            max = v;
        }
    return max;
    }

    public static int CalculateMin(int[] values)
    {
        #placeholder for logic
    }
}