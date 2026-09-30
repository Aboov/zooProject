using System.Text;

public sealed class CsvSerlizer : serlizeStretegy
{
    public string serialize(ISerializeable[] serializeables)
    {

        //TODO: This serlize is inccorect for csv
        StringBuilder jsonFormat = new StringBuilder();

        jsonFormat.Append("");

        foreach (ISerializeable serlized in serializeables)
        {
            jsonFormat.Append("{\n");
            Dictionary<string, object> serlizedObject = serlized.serialize();

            foreach (KeyValuePair<string, object> kvp in serlizedObject)
            {
                string val = kvp.Value is string ? $"\"{kvp.Value}\"" : (kvp.Value?.ToString() ?? "");
                jsonFormat.Append($"\"{kvp.Key}\": {val} \n");
            }
            jsonFormat.Append("} \n");
        }

        jsonFormat.Append("]");
        return jsonFormat.ToString();
    }
}