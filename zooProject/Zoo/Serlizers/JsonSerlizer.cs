using System.Text;
using System.Text.Json;

public sealed class JsonSerlizer : serlizeStretegy
{
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("[\n");

        foreach (ISerializeable serlized in serializeables)
        {
            Dictionary<string, object> serlizedObject = serlized.serialize();

            jsonFormat.Append(serlizeDictionary(serlizedObject));
        }

        jsonFormat.Remove(jsonFormat.Length - 2, 1);
        jsonFormat.Append("]");

        return jsonFormat.ToString();
    }

    private string serlizeDictionary(Dictionary<string, object> dictionaryToSerlize)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("{\n");

        foreach (var kvp in dictionaryToSerlize)
        {
            StringBuilder val = new StringBuilder();
            if (kvp.Value is ISerializeable serializableObj)
            {
                val.Append(serlizeDictionary(serializableObj.serialize()));
                val.Remove(val.Length - 2, 2);
            }
            else
            {
                val.Append(kvp.Value is string ? $"\"{kvp.Value}\"" : (kvp.Value?.ToString() ?? ""));
            }
            jsonFormat.Append($"\"{kvp.Key}\": {val},\n");
        }

        jsonFormat.Remove(jsonFormat.Length - 2, 1);
        jsonFormat.Append("},\n");

        return jsonFormat.ToString();
    }
}