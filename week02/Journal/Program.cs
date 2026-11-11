using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        string userChoice = "";
        List<string> _userOptions = new List<string> {
            "1. Write", 
            "2. Display", 
            "3. Load", 
            "4. Save", 
            "5. Quit"
            };
        
        Console.WriteLine("Welcome to the Journal Program!");
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        
        do
        {
            foreach (string option in _userOptions)
            {
                Console.WriteLine($"{option}");
            }
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            
            //string thePrompt = "";
            //string theEntry = "";

            if (userChoice == "1")
            {
                //thePrompt = promptGenerator.GetRandomPrompt();
                //Console.Write($"{thePrompt}");
                Entry entry = new Entry();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.Write($"{entry._promptText}");
                entry._entryText = Console.ReadLine();
                entry._date = dateText;
                //journal._entries.Add(entry);
                journal.AddEntry(entry);
            }
            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Ok, goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        } while (userChoice != "5");
        Console.WriteLine("");
    }
}