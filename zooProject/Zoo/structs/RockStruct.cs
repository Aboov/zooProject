using System.Collections.Specialized;

public record struct Rock(int Height, int Weight) : ISerializeable
{
    public OrderedDictionary serialize()
    {
        OrderedDictionary serializedRock = new OrderedDictionary()
        {
            {"height",Height},
            {"weight",Weight}
        };
        return serializedRock;
    }
}