public abstract class Animal : ISerializeable
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected GenderEnum Gender { get; set; }
    protected string FavoriteHuman { get; set; }

    protected Animal(string name, int age, GenderEnum gender, string favoriteHuman)
    {
        Name = name;
        Age = age;
        Gender = gender;
        FavoriteHuman = favoriteHuman;
    }

    public string serialize()
    {
        //TODO: implement the serlizer
        return $"\"type\": \"{Name}\",\n \"age\":{Age},\n";
    }
}