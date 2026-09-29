public abstract class Animal
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected GenderEnum Gender { get; set; }
    protected string FavoriteHuman { get; set; }

    Animal(string name, int age, GenderEnum gender, string FavoriteHuman)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
        this.FavoriteHuman = FavoriteHuman;
    }

}