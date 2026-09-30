Console.WriteLine("hello world");
Animal[] animals = new Animal[5];

Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
Otter otter = new Otter(new Rock(3, 3), "otter", 13, GenderEnum.Male, "banans");
animals[0] = banan;
animals[1] = banan;
animals[2] = banan;
animals[3] = banan;
animals[4] = otter;


JsonSerlizer jsonSerlizer = new JsonSerlizer();
Serlizer ser = new Serlizer(jsonSerlizer);

IO.CreateFile("hello.json");
IO.WriteToFile("hello.json", ser.Serlize(animals));