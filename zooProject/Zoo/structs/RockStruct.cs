public record struct Rock(int Height, int Weight) : ISerializeable
{
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