using System.Collections;
using System.Collections.Specialized;

public sealed class Shark : Animal
{
    private SharkTypeEnum SharkType;
    private bool IsLawyer;

    public Shark(string name, int age, GenderEnum gender, string favoriteHuman, SharkTypeEnum sharkType, bool isLawyer) : base(name, age, gender, favoriteHuman)
    {
        SharkType = sharkType;
        IsLawyer = isLawyer;
    }

    public sealed override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedShark = new Dictionary<string, object>()
        {
            {"type","Shark"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedShark.Add(entry.Key, entry.Value);
        }
        serializedShark.Add("sharkType", SharkType);
        serializedShark.Add("isLawyer", IsLawyer);
        return serializedShark;
    }
}