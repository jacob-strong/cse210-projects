using System;

class Program
{
    static void Main(string[] args){
        Journal journal = new Journal();
        string choice = "";
        do{
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a previous entry");
            Console.WriteLine("3. Save all entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. End program");
            Console.WriteLine("What is your choice?");
            choice = Console.ReadLine();
            if (choice == "1"){
                journal.addEntry();
            }
            else if(choice == "2"){
                journal.displayEntry();
            }
            else if(choice == "3"){
                journal.saveFile();
            }
            else if(choice == "4"){
                journal.loadFile();
            }
            else if(choice == "5"){
                Console.WriteLine("Have a nice day!");
            }
            else{
                Console.WriteLine("Invalid choice, try again");
            }
        } while (choice != "5");
    }
}