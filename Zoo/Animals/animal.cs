using System.Collections.Specialized;
using System.Runtime.Serialization;

public abstract class Animal : ISerializeable
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected GenderEnum Gender { get; set; }
    protected string FavoriteHuman { get; set; }

    protected Animal(string name, int age, GenderEnum gender, string favoriteHuman)
    {
        if (name[0] != favoriteHuman[0])
        {
            throw new InvalidNameException("invalid name -> the name of the human must " +
            "with the first letter of the animal's name ");
        }

        Name = name;
        Age = age;
        Gender = gender;
        FavoriteHuman = favoriteHuman;
    }

    public virtual Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serlizedObject = new Dictionary<string, object>(){
        { "name", Name },
        { "age", Age },
        { "gender", (int)Gender },
        { "FavoriteHuman", FavoriteHuman}
        };
        return serlizedObject;
    }
}