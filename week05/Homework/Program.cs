using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();
        Assignment assgnment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assgnment1.GetSummary());
        
        Console.WriteLine();

        //Assignment assignment2 = new Assignment("Roberto Rodriguez", "Fractions");
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}