using System.Collections.Specialized;

public sealed class Rock : ISerializeable
{
    private int _height;
    private int _weight;

    public Rock(int height, int weight)
    {
        _height = height;
        _weight = weight;
    }

    public Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedRock = new Dictionary<string, object>()
        {
            {"height",_height},
            {"weight",_weight}
        };
        return serializedRock;
    }
}