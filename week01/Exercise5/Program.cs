using System;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareResult = SquareNumber(userNumber);
        DisplayResult(name, userSquareResult);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number);
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }
        static void DisplayResult(string userName, int squareResult)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareResult}");
        }
    }
}