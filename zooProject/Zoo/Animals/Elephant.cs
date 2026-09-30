using System.Drawing;

public sealed class Elephant : Animal
{
    private int TrunkLength;
    private int Tusks;

    public Elephant(int trunkLength, int tusks, string name, int age, GenderEnum gender, string favoriteHuman) : base(name, age, gender, favoriteHuman)
    {
        TrunkLength = trunkLength;
        Tusks = tusks;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedElephant = base.serialize();
        serializedElephant.Add("trunkLength", TrunkLength);
        serializedElephant.Add("tusks", Tusks);
        return serializedElephant;
    }
}