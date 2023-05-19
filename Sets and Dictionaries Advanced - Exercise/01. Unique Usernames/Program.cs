var numberOfInputs = int.Parse(Console.ReadLine());
var names = new HashSet<string>();

for (int i = 0; i < numberOfInputs; i++)
{
    var name = Console.ReadLine();
    names.Add(name);
}

foreach (var item in names)
{
    Console.WriteLine(item);
}
