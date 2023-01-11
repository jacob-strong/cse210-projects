using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> js_numbers = new List<int>();
        Console.WriteLine("Enter a list of variables, press 0 when finished");
        int js_num = 1;
        while(js_num != 0){
            Console.WriteLine("Enter a number:");
            js_num = int.Parse(Console.ReadLine());
            if(js_num == 0){
                Console.Write("");
            }
            else{
                js_numbers.Add(js_num);
            }
        }
        int js_sum = 0;
        int js_largest = 0;
        foreach(int js_int in js_numbers){
            js_sum += js_int;
            if(js_int > js_largest){
                js_largest = js_int;
            }
        }
        int js_avg = js_sum / js_numbers.Count();
        Console.WriteLine($"The sum of the list is {js_sum}");
        Console.WriteLine($"The average of the list is {js_avg}");
        Console.WriteLine($"The largest number in the list is {js_largest}");
    }
}