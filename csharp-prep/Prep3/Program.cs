using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string js_input = "yes";
        do {
            Console.WriteLine("Guess the magic number!");
            Random generator = new Random();
            int js_magic = generator.Next(1, 11);
            int js_guess = 0;
            int count = 0;
            while(js_guess != js_magic){
                Console.WriteLine("What is your guess?");
                js_guess = int.Parse(Console.ReadLine());
                if(js_guess > js_magic){
                    Console.WriteLine("Lower!");
                    count++;
                }
                else if(js_guess < js_magic){
                    Console.WriteLine("Higher!");
                    count++;
                }
                else if(js_guess == js_magic){
                    Console.WriteLine("You win!");
                    count++;
                }
            }
            Console.WriteLine($"You got it in {count} guesses.");
            Console.WriteLine("Do you want to play again?");
            js_input = Console.ReadLine();
        } while(js_input == "yes");
    }
}