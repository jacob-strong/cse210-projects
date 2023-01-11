using System;

class Program
{
    static void Main(string[] args)
    {
        js_DisplayWelcome();
        string js_name = js_PromptUserName();
        int js_num = js_PromptUserNumber();
        js_DisplayResult(js_name, js_num);
    }

    static void js_DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string js_PromptUserName(){
        Console.WriteLine("What is your name?");
        return Console.ReadLine();
    }

    static int js_PromptUserNumber(){
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static int js_SquareNumber(int js_num){
        return js_num*js_num;
    }

    static void js_DisplayResult(string js_name, int js_num){
        Console.WriteLine($"{js_name}, the square of your number is {js_SquareNumber(js_num)}");
    }
}