using System.Collections;
using System.Collections.Specialized;
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
        StringBuilder csvFormat = new StringBuilder();

        csvFormat.Append($"{string.Join(",", _columnHeaders)}\n");
        bool isFirst = true;

        foreach (ISerializeable serlized in serializeables)
        {
            if (!isFirst)
            {
                csvFormat.Append("\n");
            }
            isFirst = false;
            Dictionary<string, object> serlizedObject = serlized.serialize();

            csvFormat.Append(serlizeDictionary(serlizedObject));
        }

        return csvFormat.ToString();
    }

    private string serlizeDictionary(Dictionary<string, object> dictionaryToSerlize)
    {
        StringBuilder csvFormat = new StringBuilder();

        bool isFirst = true;

        foreach (KeyValuePair<string, object> kvp in dictionaryToSerlize)
        {
            if (!isFirst)
            {
                csvFormat.Append(",");
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
            csvFormat.Append(val);
        }

        return csvFormat.ToString();
    }
}