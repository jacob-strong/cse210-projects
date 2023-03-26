public abstract class Card {

    private string color;

    public Card(string colorInput){
        color = colorInput;
    }

    public string getColor(){
        return color;
    }
    public abstract void display();
}