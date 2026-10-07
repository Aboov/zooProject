using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;

public sealed class JsonSerlizer : ISerializefiles
{
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("[\n");
        bool isFirst = true;


        foreach (ISerializeable serlized in serializeables)
        {
            if (!isFirst)
            {
                jsonFormat.Append(",\n");
            }
            isFirst = false;
            Dictionary<string, object> serlizedObject = serlized.serialize();

            jsonFormat.Append(serlizeDictionary(serlizedObject));
        }

        jsonFormat.Append("]");

        return jsonFormat.ToString();
    }

    private string serlizeDictionary(Dictionary<string, object> dictionaryToSerlize)
    {
        var jsonFormat = new StringBuilder();
        jsonFormat.Append("{\n");
        bool isFirst = true;

        foreach (KeyValuePair<string, object> kvp in dictionaryToSerlize)
        {
            if (!isFirst)
            {
                jsonFormat.Append(",\n");
            }
            isFirst = false;

            string formattedValue = kvp.Value switch
            {
                ISerializeable serializableObj => serlizeDictionary(serializableObj.serialize()),
                string stringObject => $"\"{stringObject}\"",
                bool booleanObject => booleanObject ? "true" : "false",
                Enum enumObject => $"\"{enumObject}\"",
                null => "",
                _ => kvp.Value.ToString() ?? ""
            };

            jsonFormat.Append($"\"{kvp.Key}\": {formattedValue}");
        }

        jsonFormat.Append("\n}");

        return jsonFormat.ToString();
    }
}