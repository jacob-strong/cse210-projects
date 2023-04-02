//Jacob Strong
public class Reverse : SpecialCard{
    //Note, reverse has the same effect as skip when there are only 2 players
    public Reverse(string colorInput, string iconInput) : base(colorInput, iconInput){
        _color = colorInput;
        _icon = iconInput;
        _ability = "skip";
    }
}