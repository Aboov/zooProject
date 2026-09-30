public sealed class Tiger : Animal
{
    private int _stripes;
    private int _humansEaten;

    public Tiger(string name, int age, GenderEnum gender, string favoriteHuman, int humansEaten, int stripes) : base(name, age, gender, favoriteHuman)
    {
        _stripes = stripes;
        _humansEaten = humansEaten;
    }
    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedTiger = base.serialize();
        serializedTiger.Add("stripes", _stripes);
        serializedTiger.Add("humansEaten", _humansEaten);
        return serializedTiger;
    }
}