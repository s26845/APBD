using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
        double sum = 0;
        

        ///////modified loop
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                sum += a[i];
            }

           
            
        }


        double average = sum / a.Length;


        Console.WriteLine($"Average: {average}");
        
        
        
    }
}