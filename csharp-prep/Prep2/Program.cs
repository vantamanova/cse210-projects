using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string usersInput = Console.ReadLine();
        int gradePercentage = int.Parse(usersInput);

        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
            //Console.WriteLine("Your grade is A");
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            //Console.WriteLine("Your grade is B");
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            //Console.WriteLine("Your grade is C");
        }
        else if (gradePercentage == 60)
        {
            letter = "D";
            //Console.WriteLine("Your grade is D");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("Your grade is F");
        }
       
       //  the ability to include a "+" or "-"
        string sign = "";

        if (letter != "F")
        {
            if (((gradePercentage % 10) >= 7) && letter != "A")
            {
                sign = "+";
            }
            else if ((gradePercentage % 10) < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        // Print the letter
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Check if they passed the class
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have not passed the class. Try again next time!");
        }

    }
}