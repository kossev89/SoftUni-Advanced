int totalFoodQuantity = int.Parse(Console.ReadLine());
int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> ordersQueue = new Queue<int>(ordersInput);
Console.WriteLine(ordersQueue.Max());

while (ordersQueue.Count > 0)
{
    if (totalFoodQuantity >= ordersQueue.Peek())
    {
        totalFoodQuantity -= ordersQueue.Dequeue();
    }
    else
    {
        break;
    }
}

if (ordersQueue.Count > 0)
{
    Console.WriteLine($"Orders left: {string.Join(' ', ordersQueue)}");
}
else if (ordersQueue.Count == 0)
{
    Console.WriteLine("Orders complete");
}