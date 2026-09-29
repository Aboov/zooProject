using System.Drawing;

public sealed class Chameleon : Animal
{
    private string Color;

    public Chameleon(string color, string name, int age, GenderEnum gender, string favoriteHuman) : base(name, age, gender, favoriteHuman)
    {
        Color = color;
    }
}