Console.WriteLine("hello world");
Animal[] animals = new Animal[4];

Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
animals[0] = banan;
animals[1] = banan;
animals[2] = banan;
animals[3] = banan;

JsonSerlizer jsonSerlizer = new JsonSerlizer();
Serlizer ser = new Serlizer(jsonSerlizer);
Console.WriteLine(ser.Serlize(animals));