//Jacob Strong
public abstract class Card {

    protected string _color;
    protected string _icon;
    protected string _ability;

    public Card(string colorInput, string iconInput){
        _color = colorInput;
        _icon = iconInput;
        _ability = "none";
    }

    public string getColor(){
        return _color;
    }

    public string getIcon(){
        return _icon;
    }

    public string getAbility(){
        return _ability;
    }

    public void setAbility(string newAbility){
        _ability = newAbility;
    }

    public void setColor(string newColor){
        _color = newColor;
    }
    public abstract string display();
}