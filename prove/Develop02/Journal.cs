using System;

public class Journal {
public List <Entry> entries;
public PromptGenerator promptGenerator;

    //Constructor initializes and empty list of entries
    public Journal() {
        entries = new List<Entry>();
        Entry entry = new Entry();
        //Initializes the prompt generator
        promptGenerator = new PromptGenerator();
    }

    //Adds a new entry to the journal from user input
    public void AddEntry() {
    
        string prompt = promptGenerator.GenerateRandomPrompt();
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        Console.WriteLine(_date);
        
        Console.WriteLine($"Today's Prompt: {prompt}");
        Console.Write("> ");
        string _entryText = Console.ReadLine();
    }

    //Displays data input this session
    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            entry.DisplayEntry();
        }
    }

    //Saves Entries to a file named by the user
    public void SaveToFile() {
        //Console.Write("Please enter the filename you would like to save to: ");
        string filename = "journal.txt";
        try {
            using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in entries) {
                    writer.WriteLine($"{entry._date}\n{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } catch (Exception e) {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    //Loads Entries from a file named by the user
    public void LoadFromFile() {
        
        String filename = "journal.txt";
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    string _date = reader.ReadLine();
                    string _entryText = reader.ReadLine();
                    Entry entry = new Entry();
                    entries.Add(entry);
                }
            } 
        } catch (Exception e) {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }

}