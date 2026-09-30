public sealed class Shark : Animal
{
    private SharkTypeEnum _SharkType;
    private bool _isLawyer;

    public Shark(string name, int age, GenderEnum gender, string favoriteHuman, SharkTypeEnum sharkType, bool isLawyer) : base(name, age, gender, favoriteHuman)
    {
        _SharkType = sharkType;
        _isLawyer = isLawyer;
    }

    public override Dictionary<string, object> serialize()
    {
        Dictionary<string, object> serializedShark = base.serialize();
        serializedShark.Add("sharkType", _SharkType);
        serializedShark.Add("isLawyer", _isLawyer);
        return serializedShark;
    }
}