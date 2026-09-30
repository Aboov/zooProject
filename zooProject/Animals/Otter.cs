using System.Drawing;

public sealed class Otter : Animal
{
    private Rock FavoriteRock;
    public Otter(Rock favoriteRock, string name, int age, GenderEnum gender, string favoriteHuman) : base(name, age, gender, favoriteHuman)
    {
        FavoriteRock = favoriteRock;
    }
    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedOtter = base.serialize();
        serializedOtter.Add("FavoriteRock", FavoriteRock);
        return serializedOtter;
    }
}