using System;

public class Program
{
    public static void Main(string[] args)
    {
<<<<<<< HEAD
        int[] b = { 1, 2, 3, 4, 5 };
=======
        int[] a = { 1, 2, 3, 4, 5 };
>>>>>>> feature-newnew
        double sum = 0;
        

        ///////modified loop
<<<<<<< HEAD
        for (int i = 0; i < b.Length; i++)
=======
        for (int i = 0; i < a.Length; i++)
>>>>>>> feature-newnew
        {
            if (a[i] % 2 == 0)
            {
<<<<<<< HEAD
                sum += b[i];
=======
                sum += a[i];
>>>>>>> feature-newnew
            }

           
            
        }


<<<<<<< HEAD
        double average = sum / b.Length;
=======
        double average = sum / a.Length;
>>>>>>> feature-newnew


        Console.WriteLine($"Average: {average}");
        
        
        
    }
}