using System.Text;

public sealed class JsonSerlizer : serlizeStretegy
{
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("[\n");

        foreach (ISerializeable serlized in serializeables)
        {
            jsonFormat.Append("{\n");
            Dictionary<string, object> serlizedObject = serlized.serialize();

            foreach (var kvp in serlizedObject)
            {
                string val = kvp.Value is string ? $"\"{kvp.Value}\"" : (kvp.Value?.ToString() ?? "");
                jsonFormat.Append($"\"{kvp.Key}\": {val} \n");
            }
            jsonFormat.Append("},\n");
        }

        jsonFormat.Append("]");
        return jsonFormat.ToString();
    }
}