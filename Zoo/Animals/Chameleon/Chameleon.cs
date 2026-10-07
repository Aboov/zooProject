using System.Collections;
using System.Collections.Specialized;

public sealed class Chameleon : Animal
{
    private string Color;

    public Chameleon(string name, int age, GenderEnum gender, string favoriteHuman, string color) : base(name, age, gender, favoriteHuman)
    {
        Color = color;
    }

    public sealed override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedChamelon = new Dictionary<string, object>()
        {
            {"type","Chameleon"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedChamelon.Add(entry.Key, entry.Value);
        }
        serializedChamelon.Add("color", Color);
        return serializedChamelon;
    }
}