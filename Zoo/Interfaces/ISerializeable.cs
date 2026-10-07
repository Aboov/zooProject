using System.Collections.Specialized;

public interface ISerializeable
{
    Dictionary<string, object> serialize();
}