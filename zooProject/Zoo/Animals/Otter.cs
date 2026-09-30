using System.Drawing;

public sealed class Otter : Animal
{
    private Rock _favoriteRock;
    public Otter(Rock favoriteRock, string name, int age, GenderEnum gender, string favoriteHuman) : base(name, age, gender, favoriteHuman)
    {
        _favoriteRock = favoriteRock;
    }
    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedOtter = base.serialize();
        serializedOtter.Add("favoriteRock", _favoriteRock);
        return serializedOtter;
    }
}