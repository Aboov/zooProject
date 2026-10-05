Animal[] animals = new Animal[5];

Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
Otter otter = (Otter)AnimalFactory.CreateAnimal(AnimalEnum.Otter, new AnimalDetails { Name = "otter", Age = 100, Gender = GenderEnum.Male, FavoriteHuman = "ohav", FavoriteRock = new Rock(3, 3) });
Tiger tiger = (Tiger)AnimalFactory.CreateAnimal(AnimalEnum.Tiger, new AnimalDetails { Name = "otter", Age = 100, Gender = GenderEnum.Male, FavoriteHuman = "ohav", HumansEaten = 3, Stripes = 3 });
Animal elephant = AnimalFactory.CreateAnimal(AnimalEnum.Elephant, new AnimalDetails { Name = "otter", Age = 100, Gender = GenderEnum.Male, FavoriteHuman = "ohav", TrunkLength = 3, Tusks = 3 });

animals[0] = elephant;
animals[1] = banan;
animals[2] = otter;
animals[3] = tiger;
animals[4] = elephant;

CsvSerlizer jsonSerlizer = new CsvSerlizer(["Type", "Name", "Age", "Gender", "FavoriteHuman"]);
Serlizer ser = new Serlizer(jsonSerlizer);
IO.CreateFile("animals.csv");
IO.WriteToFile("animals.csv", ser.Serlize(animals));

ser.SerlizeStretegy = new JsonSerlizer();
IO.CreateFile("animals.json");
IO.WriteToFile("animals.json", ser.Serlize(animals));
