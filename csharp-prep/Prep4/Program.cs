using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Creating the int list

        List<int> numbers;
        numbers = new List<int>();

        // Asking for users input
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;

        // Adding numbers to the list till user enters 0

        while (number != 0)
        {
           Console.Write("Enter number: ");
           number = int.Parse(Console.ReadLine());
           if (number != 0)
           {
            numbers.Add(number);
           }
        }

        // Compute the sum/total
        int total = 0;
        int smallestPositive = 10000000;

        foreach (int nextNumber in numbers)
        {
            total = total + nextNumber;

            //find the smallest positive number
            if ((nextNumber > 0) & (nextNumber < smallestPositive))
            {
                smallestPositive = nextNumber;
            }
        }
        
        //Compute the average
        int countNumbers = numbers.Count;
        float average = ((float)total) / countNumbers;

        // Output
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        

    }
}