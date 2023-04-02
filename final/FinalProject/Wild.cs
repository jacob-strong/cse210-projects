//Jacob Strong
public class Wild : SpecialCard{
    public Wild(string colorInput, string iconInput) : base(colorInput, iconInput){
        _color = colorInput;
        _icon = iconInput;
        _ability = "wild";
    }
}

