using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("");
        string userResponse = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            //Console.Write("What is the magic number? ");
            //string magicUserNumber = Console.ReadLine();
            //int magicNumber = int.Parse(magicUserNumber);

            int guessNumber = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guessNumber != magicNumber);

            Console.Write("You want to play again? (yes/no) ");
            userResponse = Console.ReadLine();
            Console.WriteLine("");
        } while (userResponse == "yes");
    }
}