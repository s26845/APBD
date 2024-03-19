using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double sum = 0;
        

        ///////modified loop
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }

           
            
        }


        double average = sum / numbers.Length;


        Console.WriteLine($"Average: {average}");
        
        
        
    }
}