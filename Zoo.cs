public sealed class Zoo
{
    private Animal[] Animals;

    public Zoo()
    {
        try
        {
            var otter = new Otter("otter", 14, GenderEnum.Female, "ohav", new Rock(3, 3));
            var chameleon = new Chameleon("otter", 14, GenderEnum.Female, "ohav", "blue");
            var elephant = new Elephant("otter", 14, GenderEnum.Female, "ohav", 3, 4);
            var ostrich = new Ostrich("otter", 14, GenderEnum.Female, "ohav", false);
            var shark = new Shark("otter", 14, GenderEnum.Female, "ohav", SharkTypeEnum.HammerHead, true);
            var tiger = new Tiger("otter", 14, GenderEnum.Female, "ohav", 3, 9);

            Animals = new Animal[6];
            Animals[0] = otter;
            Animals[1] = chameleon;
            Animals[2] = elephant;
            Animals[3] = ostrich;
            Animals[4] = shark;
            Animals[5] = tiger;
        }
        catch (InvalidNameException e)
        {
            Console.WriteLine(e.Message);
        }

    }

    public void CreateJson()
    {
        var ser = new Serlizer(new JsonSerlizer());
        IO.CreateFile("animals.json");
        IO.WriteToFile("animals.json", ser.Serlize(Animals));
    }

    public void CreateCsv()
    {
        CsvSerlizer csvSerlizer = new CsvSerlizer(["Type", "Name", "Age", "Gender", "FavoriteHuman"]);
        Serlizer ser = new Serlizer(csvSerlizer);
        IO.CreateFile("animals.csv");
        IO.WriteToFile("animals.csv", ser.Serlize(Animals));
    }

}