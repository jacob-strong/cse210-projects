//Jacob  Strong
public class SpecialCard : Card{

    public SpecialCard(string colorInput, string iconInput) : base (colorInput, iconInput){
        _icon = iconInput; 
        _color = colorInput;
        _ability = "none";
    }

    public override string display(){
        return "["+_icon+"] - "+_color;
    }
}