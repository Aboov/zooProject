public struct Rock : ISerializeable
{
    public int Height;
    public int Weight;

    public Rock(int height, int weight)
    {
        Height = height;
        Weight = weight;
    }

    public Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedRock = new Dictionary<string, object>()
        {
            {"height",Height},
            {"weight",Weight}
        };
        return serializedRock;
    }
}