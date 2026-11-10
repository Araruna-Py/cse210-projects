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
            PromptGenerator promptGenerator = new PromptGenerator();
            Entry entry = new Entry();
            Journal journal = new Journal();

            if (userChoice == "1")
            {
                //thePrompt = promptGenerator.GetRandomPrompt();
                //Console.Write($"{thePrompt}");
                Console.Write($"{entry._promptText = promptGenerator.GetRandomPrompt()}");
                entry._entryText = Console.ReadLine();
                entry._date = dateText;
                journal._entries.Add(entry);
            }
            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }
        } while (userChoice != "5");
        Console.WriteLine("");
    }
}