public class BasicCard : Card{
    private int num;
    private string color;

    public BasicCard(string colorInput, int numInput) : base (colorInput){
        num = numInput; 
        color = colorInput;
    }

    public int getNum(){
        return num;
    }

    public override void display(){
        //if(color == "blue"){Console.BackgroundColor = ConsoleColor.Blue;}
        //if(color == "red"){Console.BackgroundColor = ConsoleColor.Red;}
        //if(color == "yellow"){Console.BackgroundColor = ConsoleColor.Yellow;}
        //if(color == "green"){Console.BackgroundColor = ConsoleColor.Green;}
        Console.WriteLine("["+num+"] - "+color);
    }
}