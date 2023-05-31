using System.Text;

List<string> people = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string[] commandTokens = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
StringBuilder stringBuilder = new();


Func<string, string, string, List<string>> goingToParty = (action, condition, statement) =>
{
    List<string> result = new List<string>(people);
    switch (action)
    {
        case "Double":
            switch (condition)
            {
                case "StartsWith":
                    foreach (var item in people)
                    {
                        if (item.StartsWith(statement))
                        {
                            result.Insert(people.IndexOf(item), item);
                        }
                    }
                    break;
                case "Length":
                    foreach (var item in people)
                    {
                        if (item.Length == int.Parse(statement))
                        {
                            result.Insert(people.IndexOf(item), item);
                        }
                    }
                    break;
                case "EndsWith":
                    foreach (var item in people)
                    {
                        if (item.EndsWith(statement))
                        {
                            result.Insert(people.IndexOf(item), item);
                        }
                    }
                    break;
            }
            break;
        case "Remove":
            switch (condition)
            {
                case "StartsWith":
                    foreach (var item in people)
                    {
                        if (item.StartsWith(statement))
                        {
                            result.Remove(item);
                        }
                    }
                    break;
                case "Length":
                    foreach (var item in people)
                    {
                        if (item.Length == int.Parse(statement))
                        {
                            result.Remove(item);
                        }
                    }
                    break;
                case "EndsWith":
                    foreach (var item in people)
                    {
                        if (item.EndsWith(statement))
                        {
                            result.Remove(item);
                        }
                    }
                    break;
            }
            break;
    }
    people = result;
    return people;
};

while (commandTokens[0] != "Party!")
{
    string action = commandTokens[0];
    string condition = commandTokens[1];
    string statement = commandTokens[2];
    people = goingToParty(action, condition, statement);
    commandTokens = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

if (people.Count == 0)
{
    Console.WriteLine("Nobody is going to the party!");
    return;
}
else
{
    for (int i = 0; i < people.Count; i++)
    {
        if (i != people.Count-1)
        {
            stringBuilder.Append($"{people[i]}, ");
        }
        else
        {
            stringBuilder.Append($"{people[i]} ");
        }
    }
}
stringBuilder.Append("are going to the party!");
Console.WriteLine(stringBuilder);