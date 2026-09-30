using System.Text;

public sealed class JsonSerlizer : serlizeStretegy
{
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("[");

        foreach (ISerializeable serlized in serializeables)
        {
            jsonFormat.Append("{");
            Dictionary<string, object> serlizedObject = serlized.serialize();

            foreach (var kvp in serlizedObject)
            {
                string val = kvp.Value is string ? $"\"{kvp.Value}\"" : (kvp.Value?.ToString() ?? "");
                jsonFormat.Append($"\"{kvp.Key}\": {kvp.Value}");
            }
            jsonFormat.Append("}");
        }

        jsonFormat.Append("]");
        return jsonFormat.ToString();
    }
}