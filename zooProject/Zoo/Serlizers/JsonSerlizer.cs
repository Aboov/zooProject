using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;

public sealed class JsonSerlizer : ISerlizeStretegy
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
            OrderedDictionary serlizedObject = serlized.serialize();

            jsonFormat.Append(serlizeDictionary(serlizedObject));
        }

        jsonFormat.Append("]");

        return jsonFormat.ToString();
    }

    private string serlizeDictionary(OrderedDictionary dictionaryToSerlize)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("{\n");

        bool isFirst = true;

        foreach (DictionaryEntry kvp in dictionaryToSerlize)
        {
            if (!isFirst)
            {
                jsonFormat.Append(",\n");
            }
            isFirst = false;

            StringBuilder val = new StringBuilder();
            if (kvp.Value is ISerializeable serializableObj)
            {
                val.Append(serlizeDictionary(serializableObj.serialize()));
            }
            else
            {
                val.Append(kvp.Value is string ? $"\"{kvp.Value}\"" : (kvp.Value?.ToString() ?? ""));
            }
            jsonFormat.Append($"\"{kvp.Key}\": {val}");
        }

        jsonFormat.Append("\n}");

        return jsonFormat.ToString();
    }
}