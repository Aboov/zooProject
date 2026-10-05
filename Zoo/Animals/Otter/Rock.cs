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

    public OrderedDictionary serialize()
    {
        OrderedDictionary serializedRock = new OrderedDictionary()
        {
            {"height",_height},
            {"weight",_weight}
        };
        return serializedRock;
    }
}