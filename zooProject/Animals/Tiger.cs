public sealed class Tiger : Animal
{
    private int Stripes;
    private int HumansEaten;

    public Tiger(string name, int age, GenderEnum gender, string favoriteHuman, int humansEaten, int stripes) : base(name, age, gender, favoriteHuman)
    {
        Stripes = stripes;
        HumansEaten = humansEaten;
    }
}