public static class AnimalFactory
{
    public static Animal CreateAnimal(AnimalEnum animaType, AnimalDetails details)
    {
        return animaType switch
        {
            AnimalEnum.Chameleon => new Chameleon(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.Color),
            AnimalEnum.Elephant => new Elephant(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.TrunkLength, details.Tusks),
            AnimalEnum.Otter => new Otter(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.FavoriteRock),
            AnimalEnum.Shark => new Shark(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.SharkType, details.IsLawyer),
            AnimalEnum.Tiger => new Tiger(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.HumansEaten, details.Stripes),
            AnimalEnum.Ostrich => new Ostrich(details.Name, details.Age, details.Gender, details.FavoriteHuman, details.IsHeadInTheGround),
            _ => throw new ArgumentException($"Unknown animal type: {animaType}")
        };
    }
}