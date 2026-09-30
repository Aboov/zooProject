Console.WriteLine("hello world");
Animal[] animals = new Animal[5];

Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
Otter otter = new Otter(new Rock(3, 3), "otter", 13, GenderEnum.Male, "ohav");
animals[0] = banan;
animals[1] = banan;
animals[2] = banan;
animals[3] = banan;
animals[4] = otter;


CsvSerlizer jsonSerlizer = new CsvSerlizer(["name", "age", "gender", "favHuman"]);
Serlizer ser = new Serlizer(jsonSerlizer);

IO.CreateFile("hello.csv");
IO.WriteToFile("hello.csv", ser.Serlize(animals));