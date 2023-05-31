List<string> invitations = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();
List<string> filtered = new(invitations);
string[] commandTokens = Console.ReadLine()
    .Split(';', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

while (commandTokens[0] != "Print")
{
    string command = commandTokens[0];
    string filterType = commandTokens[1];
    string filterValue = commandTokens[2];
    if (command=="Add filter")
    {
        filtered.RemoveAll(Filter(filterType, filterValue));
    }
    else if (command == "Remove filter")
    {
        List<string> peopleToAdd = invitations.FindAll(Filter(filterType, filterValue));
        foreach (var item in peopleToAdd)
        {
            filtered.Add(item);
        }
    }
    commandTokens = Console.ReadLine()
    .Split(';', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
}
Console.WriteLine(String.Join(' ', filtered));

static Predicate<string> Filter(string filterType, string filterValue)
{
    switch (filterType)
    {
        case "Ends with":
            return x => x.EndsWith(filterValue);
            break;
        case "Starts with":
            return x => x.StartsWith(filterValue);
            break;

        case "Length":
            return x => x.Length == int.Parse(filterValue);
            break;
        case "Contains":
            return x => x.Contains(filterValue);
            break;
        default:
            return default;
    }
}
