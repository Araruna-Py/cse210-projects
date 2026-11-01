using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        string userNumber = "";
        //int sumNumber = 0;
        int totalNumbers = 0;
        int total = 0;
        int oldNumber = 0;
        //float average = 0;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            List<int> numbers = new List<int>();
            do
            {
                    Console.Write("Enter number: ");
                    userNumber = Console.ReadLine();
                    if (userNumber != "0")
                    {
                        int enterNumber = int.Parse(userNumber);
                        numbers.Add(enterNumber);
                        totalNumbers++;
                    }
            } while (userNumber != "0");
            foreach (int number in numbers)
            {
                //Console.WriteLine(number);
                total = oldNumber + number;
                Console.WriteLine(total);
                oldNumber = total;
                //Console.WriteLine(oldNumber);
            }
        } while (userNumber != "0");
    }
}