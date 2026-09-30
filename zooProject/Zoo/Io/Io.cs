public static class IO
{
    public static void CreateFile(string filename)
    {
        using (File.Create($"{filename}")) { }
        ;
    }

    public static void WriteToFile(string filename, string text)
    {
        File.WriteAllText(filename, text);
    }
}