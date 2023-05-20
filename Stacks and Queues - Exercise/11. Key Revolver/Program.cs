var bulletPrice = int.Parse(Console.ReadLine());
var barrel = int.Parse(Console.ReadLine());
var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
var inteligenceValue = int.Parse(Console.ReadLine());

while (locks.Count > 0)
{
    for (int i = 1; i <= barrel; i++)
    {
        if (bullets.Pop() <= locks.Peek())
        {
            Console.WriteLine("Bang!");
            locks.Dequeue();
            inteligenceValue -= bulletPrice;
        }
        else
        {
            Console.WriteLine("Ping!");
            inteligenceValue -= bulletPrice;
        }
        if (i == barrel && bullets.Count > 0)
        {
            Console.WriteLine("Reloading!");
        }
        if (bullets.Count == 0 || locks.Count == 0)
        {
            break;
        }
    }
    if (bullets.Count == 0)
    {
        break;
    }
}
if (locks.Count == 0)
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${inteligenceValue}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}

