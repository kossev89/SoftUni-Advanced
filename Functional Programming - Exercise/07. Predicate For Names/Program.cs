int nameLength = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Func<int, List<string>, List<string>> filterNames = (nameLength, names) =>
{
    names.RemoveAll(x => x.Length > nameLength);
    return names;
};

List<string> filteredNames = filterNames(nameLength, names);
foreach (var item in filteredNames)
{
    Console.WriteLine(item);
}