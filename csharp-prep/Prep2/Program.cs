using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade?");
        string input1 = Console.ReadLine();
        int numGrade = int.Parse(input1);
        string letterGrade = "a";

        if (numGrade >= 90){
            letterGrade = "A";
        }

        else if (numGrade >= 80){
            letterGrade = "B";
        }

        else if (numGrade >= 70){
            letterGrade = "C";
        }

        else if (numGrade >= 60){
            letterGrade = "D";
        }

        else {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (numGrade >= 70){
            Console.WriteLine("You passed the course :)");
        }

        else {
            Console.WriteLine("You failed the course :(");
        }
    }
}