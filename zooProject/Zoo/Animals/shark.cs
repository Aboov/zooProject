public sealed class Shark : Animal
{
    private SharkTypeEnum SharkType;
    private bool IsLawyer;

    public Shark(string name, int age, GenderEnum gender, string favoriteHuman, SharkTypeEnum sharkType, bool isLawyer) : base(name, age, gender, favoriteHuman)
    {
        SharkType = sharkType;
        IsLawyer = isLawyer;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedShark = base.serialize();
        serializedShark.Add("sharkType", SharkType);
        serializedShark.Add("isLawyer", IsLawyer);
        return serializedShark;
    }
}