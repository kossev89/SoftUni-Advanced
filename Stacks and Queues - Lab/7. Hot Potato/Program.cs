Queue<string> children = new Queue<string>(Console.ReadLine().Split());
int numberOfThosses = int.Parse(Console.ReadLine());

while (children.Count > 1)
{
    for (int i = 1; i < numberOfThosses; i++)
    {
        string name = children.Peek();
        children.Dequeue();
        children.Enqueue(name);
    }
    Console.WriteLine($"Removed {children.Dequeue()}");
}
Console.WriteLine($"Last is {children.Peek()}");