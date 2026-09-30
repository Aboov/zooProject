using System.Drawing;

public sealed class Chameleon : Animal
{
    private string _color;

    public Chameleon(string name, int age, GenderEnum gender, string favoriteHuman, string color) : base(name, age, gender, favoriteHuman)
    {
        _color = color;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedChamelon = base.serialize();
        serializedChamelon.Add("color", _color);
        return serializedChamelon;
    }
}