int[] input = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(input);
List<int> output = new List<int>();

while (queue.Count > 0)
{
    int number = queue.Dequeue();
    if (number % 2 == 0)
    {
        output.Add(number);
    }
}
Console.WriteLine(string.Join(", ", output));
