var numberOfInputs = int.Parse(Console.ReadLine());
var names = new List<string>();
var name = string.Empty;

for (int i = 0; i < numberOfInputs; i++)
{
    name = Console.ReadLine();
	if (!names.Contains(name))
	{
		names.Add(name);
	}
}

foreach (var item in names)
{
	Console.WriteLine(item);
}