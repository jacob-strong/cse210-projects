public class SpecialCard : Card{
    private int num;
    private string color;

    public SpecialCard(string colorInput, int numInput) : base (colorInput){
        num = numInput; 
        color = colorInput;
    }

    public int getNum(){
        return num;
    }

    public void ability(){

    }

    public override void display(){
        //if(color == "blue"){Console.BackgroundColor = ConsoleColor.Blue;}
        //if(color == "red"){Console.BackgroundColor = ConsoleColor.Red;}
        //if(color == "yellow"){Console.BackgroundColor = ConsoleColor.Yellow;}
        //if(color == "green"){Console.BackgroundColor = ConsoleColor.Green;}
        //if(color == "black"){Console.BackgroundColor = ConsoleColor.Black;}
        Console.WriteLine("["+num+"] - "+color);
        Console.WriteLine();
    }
}