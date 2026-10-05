using System.Collections;
using System.Collections.Specialized;
using System.Drawing;

public sealed class Ostrich : Animal
{
    private bool _isHeadInTheGround;

    public Ostrich(string name, int age, GenderEnum gender, string favoriteHuman, bool isHeadInTheGround) : base(name, age, gender, favoriteHuman)
    {
        _isHeadInTheGround = isHeadInTheGround;
    }

    public sealed override OrderedDictionary serialize()
    {

        OrderedDictionary serializedOstrich = new OrderedDictionary()
        {
            {"type","Ostrich"}
        };

        foreach (DictionaryEntry entry in base.serialize())
        {
            serializedOstrich.Add(entry.Key, entry.Value);
        }
        serializedOstrich.Add("isHeadInTheGround", _isHeadInTheGround);
        return serializedOstrich;
    }
}