using System.Collections;
using System.Collections.Specialized;

public sealed class Shark : Animal
{
    private SharkTypeEnum _SharkType;
    private bool _isLawyer;

    public Shark(string name, int age, GenderEnum gender, string favoriteHuman, SharkTypeEnum sharkType, bool isLawyer) : base(name, age, gender, favoriteHuman)
    {
        _SharkType = sharkType;
        _isLawyer = isLawyer;
    }

    public sealed override OrderedDictionary serialize()
    {
        OrderedDictionary serializedShark = new OrderedDictionary()
        {
            {"type","Shark"}
        };

        foreach (DictionaryEntry entry in base.serialize())
        {
            serializedShark.Add(entry.Key, entry.Value);
        }
        serializedShark.Add("sharkType", _SharkType);
        serializedShark.Add("isLawyer", _isLawyer);
        return serializedShark;
    }
}