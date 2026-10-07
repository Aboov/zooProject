using System.Collections;
using System.Collections.Specialized;
using System.Text;

public sealed class CsvSerlizer : ISerializefiles
{
    private string[] ColumnHeaders;
    public CsvSerlizer(string[] columnHeaders)
    {
        ColumnHeaders = columnHeaders;
    }
    public string serialize(ISerializeable[] serializeables)
    {
        StringBuilder csvFormat = new StringBuilder();

        csvFormat.Append($"{string.Join(",", ColumnHeaders)}\n");
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

            string formattedValue = kvp.Value switch
            {
                ISerializeable serializableObj => serlizeDictionary(serializableObj.serialize()),
                string stringObject => stringObject,
                null => "",
                _ => kvp.Value.ToString() ?? ""
            };
            csvFormat.Append(formattedValue);
        }

        return csvFormat.ToString();
    }
}