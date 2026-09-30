using System.Drawing;

public sealed class Elephant : Animal
{
    private int _trunkLength;
    private int _tusks;

    public Elephant(int trunkLength, int tusks, string name, int age, GenderEnum gender, string favoriteHuman) : base(name, age, gender, favoriteHuman)
    {
        _trunkLength = trunkLength;
        _tusks = tusks;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedElephant = base.serialize();
        serializedElephant.Add("trunkLength", _trunkLength);
        serializedElephant.Add("tusks", _tusks);
        return serializedElephant;
    }
}