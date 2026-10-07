using System.Collections;
using System.Collections.Specialized;
using System.Drawing;

public sealed class Elephant : Animal
{
    private int TrunkLength;
    private int Tusks;

    public Elephant(string name, int age, GenderEnum gender, string favoriteHuman, int trunkLength, int tusks) : base(name, age, gender, favoriteHuman)
    {
        TrunkLength = trunkLength;
        Tusks = tusks;
    }

    public sealed override Dictionary<string, object> serialize()
    {

        Dictionary<string, object> serializedElephant = new Dictionary<string, object>()
        {
            {"type","Elephant"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedElephant.Add(entry.Key, entry.Value);
        }
        serializedElephant.Add("trunkLength", TrunkLength);
        serializedElephant.Add("tusks", Tusks);
        return serializedElephant;
    }
}