using System.Text;

public sealed class CsvSerlizer : ISerlizeStretegy
{
    private string[] _columnHeaders;
    public CsvSerlizer(string[] columnHeaders)
    {
        _columnHeaders = columnHeaders;
    }
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder jsonFormat = new StringBuilder();

        jsonFormat.Append($"{string.Join(", ", _columnHeaders)}\n");
        bool isFirst = true;

        foreach (ISerializeable serlized in serializeables)
        {
            if (!isFirst)
            {
                jsonFormat.Append("\n");
            }
            isFirst = false;
            Dictionary<string, object> serlizedObject = serlized.serialize();

            jsonFormat.Append(serlizeDictionary(serlizedObject));
        }


        return jsonFormat.ToString();
    }

    private string serlizeDictionary(Dictionary<string, object> dictionaryToSerlize)
    {
        StringBuilder jsonFormat = new StringBuilder();
        jsonFormat.Append("");

        bool isFirst = true;

        foreach (var kvp in dictionaryToSerlize)
        {
            if (!isFirst)
            {
                jsonFormat.Append(",");
            }
            isFirst = false;

            StringBuilder val = new StringBuilder();
            if (kvp.Value is ISerializeable serializableObj)
            {
                val.Append(serlizeDictionary(serializableObj.serialize()));
            }
            else
            {
                val.Append(kvp.Value);
            }
            jsonFormat.Append(val);
        }

        jsonFormat.Append("");

        return jsonFormat.ToString();
    }
}