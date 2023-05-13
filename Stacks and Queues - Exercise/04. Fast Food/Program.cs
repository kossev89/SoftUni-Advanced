int totalFoodQuantity = int.Parse(Console.ReadLine());
int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> ordersQueue = new Queue<int>(ordersInput);
Console.WriteLine(ordersQueue.Max());

while (ordersQueue.Count > 0)
{
    int lastOrder = ordersQueue.Peek();
    totalFoodQuantity -= ordersQueue.Dequeue();
    if (totalFoodQuantity < 0)
    {
        ordersQueue.Enqueue(lastOrder);
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