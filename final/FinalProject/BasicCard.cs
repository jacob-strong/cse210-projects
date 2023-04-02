//Jacob Strong
public class BasicCard : Card{

    public BasicCard(string colorInput, string iconInput) : base (colorInput, iconInput){
        _icon = iconInput; 
        _color = colorInput;
        _ability = "none";
    }

    public override string display(){
        return "["+_icon+"] - "+_color;
    }
}