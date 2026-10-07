using System.Collections;
using System.Collections.Specialized;
using System.Drawing;

public sealed class Otter : Animal
{
    private Rock FavoriteRock;
    public Otter(string name, int age, GenderEnum gender, string favoriteHuman, Rock favoriteRock) : base(name, age, gender, favoriteHuman)
    {
        FavoriteRock = favoriteRock;
    }
    public sealed override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedOtter = new Dictionary<string, object>()
        {
            {"type","Otter"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedOtter.Add(entry.Key, entry.Value);
        }

        serializedOtter.Add("favoriteRock", FavoriteRock);

        return serializedOtter;
    }
}