public sealed class Shark : Animal
{
    private SharkTypeEnum SharkType;
    private bool IsLawyer;

    public Shark(string name, int age, GenderEnum gender, string favoriteHuman, SharkTypeEnum sharkType, bool isLawyer) : base(name, age, gender, favoriteHuman)
    {

    }
}