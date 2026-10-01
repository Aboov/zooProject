using System.Collections;
using System.Collections.Specialized;

public sealed class Chameleon : Animal
{
    private string _color;

    public Chameleon(string name, int age, GenderEnum gender, string favoriteHuman, string color) : base(name, age, gender, favoriteHuman)
    {
        _color = color;
    }

    public override OrderedDictionary serialize()
    {
        OrderedDictionary serializedChamelon = new OrderedDictionary()
        {
            {"type","Chameleon"}
        };

        foreach (DictionaryEntry entry in base.serialize())
        {
            serializedChamelon.Add(entry.Key, entry.Value);
        }
        serializedChamelon.Add("color", _color);
        return serializedChamelon;
    }
}