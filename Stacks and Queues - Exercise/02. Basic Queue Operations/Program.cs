int[] inputInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToAdd = inputInfo[0];
int elementsToRemove = inputInfo[1];
int elementToFind = inputInfo[2];
Queue<int> queue = new Queue<int>();

int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < elementsToAdd; i++)
{
    queue.Enqueue(ints[i]);
}
for (int i = 0; i < elementsToRemove; i++)
{
    queue.Dequeue();
}
if (queue.Contains(elementToFind))
{
    Console.WriteLine("true");
}
else if (queue.Count > 0)
{
    Console.WriteLine(queue.Min());
}
else
{
    Console.WriteLine("0");
}