public class prompt{
    public void startPrompt(){ 
        string answer = "yes";
        do {
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a previous entry");
            Console.WriteLine("3. Save all entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Type 'end' to end the program");
            Console.WriteLine("What is your choice?");
            answer = Console.ReadLine();
        } while(answer != "end");
    }

    List<string> promptList = new List<string>();

    promptList.add('');
}
