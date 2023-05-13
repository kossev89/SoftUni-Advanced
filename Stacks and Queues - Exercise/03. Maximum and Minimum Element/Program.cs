int numberOfqueries = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < numberOfqueries; i++)
{
    int[] queryType = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (queryType[0] == 1)
    {
        stack.Push(queryType[1]);
    }
    else if (queryType[0] == 2)
    {
        stack.Pop();
    }
    else if (queryType[0] == 3 && stack.Count > 0)
    {
        Console.WriteLine(stack.Max());
    }
    else if (queryType[0] == 4 && stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }
}
Console.WriteLine(string.Join(", ", stack));