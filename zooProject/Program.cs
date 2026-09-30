Console.WriteLine("hello world");
Chameleon banan = new Chameleon("ohav", 3, GenderEnum.Female, "ohav", "blue");
var result = banan.serialize();
foreach (var item in result)
{
    Console.WriteLine("{0} > {1}", item.Key, item.Value);
}
