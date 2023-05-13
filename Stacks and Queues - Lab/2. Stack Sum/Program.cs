int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string commandInput = Console.ReadLine().ToLower();
Stack<int> stack = new Stack<int>();
foreach (var item in input)
{
    stack.Push(item);
}

while (commandInput != "end")
{
    string[] commandTokens = commandInput.Split(' ');
    if (commandTokens[0] == "add")
    {
        stack.Push(int.Parse(commandTokens[1]));
        stack.Push(int.Parse(commandTokens[2]));
    }
    else if (commandTokens[0] == "remove" && int.Parse(commandTokens[1]) <= stack.Count)
    {
        for (int i = 0; i < int.Parse(commandTokens[1]); i++)
        {
            stack.Pop();
        }
    }
    commandInput = Console.ReadLine().ToLower();
}
Console.WriteLine($"Sum: {stack.Sum()}");