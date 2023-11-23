using System;

class Program
{
    static void Main(string[] args)
    {
        int progress = 0;
        Menu menu = new Menu();

        Console.WriteLine("Welcome to Math Tytoring Program!");
        menu.DisplayMenu();
        menu.DisplayOperations();
    }
}