using System.Drawing;

public sealed class Chameleon : Animal
{
    private string Color;

    public Chameleon(string name, int age, GenderEnum gender, string favoriteHuman, string color) : base(name, age, gender, favoriteHuman)
    {
        Color = color;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedChamelon = base.serialize();
        serializedChamelon.Add("color", Color);
        return serializedChamelon;
    }
}