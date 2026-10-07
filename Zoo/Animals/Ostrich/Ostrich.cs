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

    public sealed override Dictionary<string, object> serialize()
    {

        Dictionary<string, object> serializedOstrich = new Dictionary<string, object>()
        {
            {"type","Ostrich"}
        };

        foreach (KeyValuePair<string, object> entry in base.serialize())
        {
            serializedOstrich.Add(entry.Key, entry.Value);
        }
        serializedOstrich.Add("isHeadInTheGround", _isHeadInTheGround);
        return serializedOstrich;
    }
}