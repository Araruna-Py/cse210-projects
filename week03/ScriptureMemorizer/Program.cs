using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");
        string userChoice = "";
        string mainBook = "Proverbs";
        int mainChapter = 3;
        int mainStartVerse = 5;
        int mainEndVerse = 6;
        string mainScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths;";
        Reference reference = new Reference(mainBook, mainChapter, mainStartVerse, mainEndVerse);
        Scripture scripture = new Scripture(reference, mainScripture);
        
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userChoice = Console.ReadLine();
            if (userChoice != "quit")
            {
                scripture.HideRandomWords(3);
            }
            else if (scripture.IsCompletelyHidden() == true)
            {
                userChoice = "quit";
            }
        } while (userChoice != "quit");
    }
}