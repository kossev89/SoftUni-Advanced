var numberOfinputs = int.Parse(Console.ReadLine());
var elements = new HashSet<string>();

for (int i = 0; i < numberOfinputs; i++)
{
    var input = Console.ReadLine()
        .Split();
    foreach (var item in input)
    {
        elements.Add(item);
    }
}
var printSet = elements.OrderBy(x => x);
Console.WriteLine(string.Join(' ', printSet));
