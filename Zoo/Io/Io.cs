public static class IO
{
    public static void CreateFile(string filename)
    {
        using (File.Create($"/home/aboov/ZooProject/zooProject/Zoo/outputs/{filename}")) { }
        ;
    }

    public static void WriteToFile(string filename, string text)
    {
        File.WriteAllText("/home/aboov/ZooProject/zooProject/Zoo/outputs/" + filename, text);
    }
}