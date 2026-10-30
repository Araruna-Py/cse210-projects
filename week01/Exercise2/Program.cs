using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");
        Console.Write("Write your grade percentage: ");
        string usePercentage = Console.ReadLine();
        int percentageNumber = int.Parse(usePercentage);
        Console.WriteLine("");
        string letter = "";
        string sinal = "";
        float sinalPercentage = percentageNumber;
        float sinalFilter = sinalPercentage / 10;
        if (percentageNumber >= 90)
        {
            letter = "A";
            float filter = sinalFilter - 9;
            if (filter < 0.39)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
        }
        else if (percentageNumber >= 80)
        {
            letter = "B";
            float filter = sinalFilter - 8;
            if (filter >= 0.69)
            {
                sinal = "+";
            }
            else if (filter < 0.39)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
        }
        else if (percentageNumber >= 70)
        {
            letter = "C";
            float filter = sinalFilter - 7;
            if (filter >= 0.69)
            {
                sinal = "+";
            }
            else if (filter < 0.39)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
        }
        else if (percentageNumber >= 60)
        {
            letter = "D";
            float filter = sinalFilter - 6;
            if (filter >= 0.69)
            {
                sinal = "+";
            }
            else if (filter < 0.39)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
        }
        else if (percentageNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{sinal}.");
        if (percentageNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, but unfortunately you didn't passed the course.");
        }
    }
}