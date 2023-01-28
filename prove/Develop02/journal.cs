public class journal{
    public void newEntry(string entry){
        entries.Add(entry);
    }

    public void save(){
        Console.WriteLine("What would you like the file to be named?");
        string fileName = Console.ReadLine();
        foreach(string x in entries){
            File.WriteAllText(fileName, x);
        }
    }

    public void load(){
        Console.WriteLine("What is the name of the file to load?");
        string fileName = Console.ReadLine();
        string readEntry = File.ReadAllText(fileName);
        Console.WriteLine(readEntry);
    }
    public List<string> entries = new List<string>();
}