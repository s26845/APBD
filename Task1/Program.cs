using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int max = FindMaximum(numbers);
        Console.WriteLine($"The max value  is: {max}");
    }

    public static int FindMaximum(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(nums));
        }

        int max = nums[0];
        foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
    }

    
    
