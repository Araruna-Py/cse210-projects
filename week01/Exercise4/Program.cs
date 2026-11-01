using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        string userNumber = "";
        float sumNumber = 0;
        float totalNumbers = 0;
        float total = 0;
        float average = 0;
        float highestNumber = 0;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            List<float> numbers = new List<float>();
            do
            {
                    Console.Write("Enter number: ");
                    userNumber = Console.ReadLine();
                    if (userNumber != "0")
                    {
                        float enterNumber = float.Parse(userNumber);
                        numbers.Add(enterNumber);
                        totalNumbers++;
                    }
            } while (userNumber != "0");
            foreach (float number in numbers)
            {
                total = sumNumber + number;
                sumNumber = total;
                if (number > highestNumber)
                {
                    highestNumber = number;
                }
            }
            average = total/totalNumbers;
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {highestNumber}");
        } while (userNumber != "0");
    }
}