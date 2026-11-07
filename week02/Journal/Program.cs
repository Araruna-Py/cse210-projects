using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        string userChoice = "";
        List<string> _userOptions = new List<string> {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            foreach (string option in _userOptions)
            {
                Console.WriteLine($"{option}");
            }
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
        } while (userChoice != "5");
    }
}