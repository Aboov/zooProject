Console.WriteLine("hello world");
Animal[] animals = new Animal[5];

Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
Otter otter = new Otter(new Rock(3, 3), "otter", 13, GenderEnum.Male, "ohav");
Tiger tiger = new Tiger("IAMTIGER", 14, GenderEnum.Male, "IAMOHAVTHETIGER", 3, 9);
animals[0] = otter;
animals[1] = banan;
animals[2] = otter;
animals[3] = tiger;
animals[4] = tiger;


CsvSerlizer jsonSerlizer = new CsvSerlizer(["Type", "Name", "Age", "Gender", "FavoriteHuman"]);
Serlizer ser = new Serlizer(jsonSerlizer);
ser.SerlizeStretegy = new JsonSerlizer();

IO.CreateFile("hello.json");
IO.WriteToFile("hello.json", ser.Serlize(animals));