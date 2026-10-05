using System.Collections;
using System.Collections.Specialized;
using System.Drawing;

public sealed class Otter : Animal
{
    private Rock _favoriteRock;
    public Otter(string name, int age, GenderEnum gender, string favoriteHuman, Rock favoriteRock) : base(name, age, gender, favoriteHuman)
    {
        _favoriteRock = favoriteRock;
    }
    public sealed override OrderedDictionary serialize()
    {
        OrderedDictionary serializedOtter = new OrderedDictionary()
        {
            {"type","Otter"}
        };

        foreach (DictionaryEntry entry in base.serialize())
        {
            serializedOtter.Add(entry.Key, entry.Value);
        }
        serializedOtter.Add("favoriteRock", _favoriteRock);
        return serializedOtter;
    }
}