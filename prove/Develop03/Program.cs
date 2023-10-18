using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {

        // Gets the Scripture element
        Scripture scripture = new Scripture();
        Console.Clear();
        scripture.ShowScripture();
        scripture.CreateList();

        string answer = "";

        while ((answer != "quit") || (scripture.GetStatus() == true)) {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            
            
            scripture.IsCompletlytHidden(); // присваивает знаенчие переменной _isCompletlytHidden. Возвращает значение 
            scripture.HideWords(); // Прячет слова
            scripture.GetRenderedText(); // Получает текст для вывода
            Console.Clear(); // очищает консоль
            scripture.ShowScripture(); //Печатает текст
            
           


        }
    }
}