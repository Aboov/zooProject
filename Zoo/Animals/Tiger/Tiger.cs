using System.Collections;
using System.Collections.Specialized;

public sealed class Tiger : Animal
{
    private int _stripes;
    private int _humansEaten;

    public Tiger(string name, int age, GenderEnum gender, string favoriteHuman, int humansEaten, int stripes) : base(name, age, gender, favoriteHuman)
    {
        _stripes = stripes;
        _humansEaten = humansEaten;
    }
    public sealed override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedTiger = new Dictionary<string, object>()
        {
            {"type","Tiger"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedTiger.Add(entry.Key, entry.Value);
        }

        serializedTiger.Add("stripes", _stripes);
        serializedTiger.Add("humansEaten", _humansEaten);
        return serializedTiger;
    }
}