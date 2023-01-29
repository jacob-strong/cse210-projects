public class Journal{
    public void addEntry(){ 
        DateTime now = DateTime.Now;
        Random random = new Random();
        int randomInt = random.Next(0, 8);
        string randomPrompt = promptList[randomInt];
        Console.WriteLine(now);
        Console.WriteLine(randomPrompt);
        string entry = Console.ReadLine();
        entries.Add(now+"\n" + randomPrompt+"\n" + entry);
    }

    public void displayEntry(){
        Console.WriteLine(entries[^1]);
    }

    public void saveFile(){
        Console.WriteLine("What would you like the file to be named?");
        string fileName = Console.ReadLine();
        foreach(string x in entries){
            File.WriteAllText(fileName, x);
        }
    }

    public void loadFile(){
        Console.WriteLine("What is the name of the file to load?");
        string fileName = Console.ReadLine();
        string readEntry = File.ReadAllText(fileName);
        Console.WriteLine(readEntry);
    }
    public List<string> entries = new List<string>();
    public string[] promptList = {
        "What was the best thing that happened to you today?",
        "What is one thing you wish you could have done differently?",
        "Who was your favorite person to talk to today?",
        "Did I meet anyone interesting today?",
        "Did I do anything meaningful today?",
        "Did I meet my personal goals today?",
        "What was the coolest thing I saw today?",
        "What was an interesting thought I had today?",
        "What was something I could’ve done differently?"
    };
}