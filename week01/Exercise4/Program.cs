using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int> ();

       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       int input = -1;
       while (input != 0)
       {
           Console.Write("Enter a number: ");
           input = int.Parse(Console.ReadLine());
           if (input != 0)
           {
               numbers.Add(input);  
           }    
       }

       int sum = 0;
       int largest = numbers[0];
         foreach (int number in numbers)
         {
             sum += number;
             if (number > largest)
             {
                 largest = number;
             }
         }

         double average = (double)sum / numbers.Count;
         Console.WriteLine($"Sum: {sum}");
         Console.WriteLine($"Largest: {largest}");
         Console.WriteLine($"Average: {average}");

         int smallestPositive = int.MaxValue;
         bool foundPositive = false;

         foreach (int number in numbers)
         {
             if (number > 0 && number < smallestPositive)
             {
                 smallestPositive = number;
                 foundPositive = true;
             }
         }
         if (foundPositive)
         {
             Console.WriteLine($"The smallest Positive number is: {smallestPositive}");

         }

         numbers.Sort();
         Console.WriteLine("The sorted numbers are:");
         foreach (int number in numbers)
         {
             Console.Write($"{number} ");
         }
    }
}