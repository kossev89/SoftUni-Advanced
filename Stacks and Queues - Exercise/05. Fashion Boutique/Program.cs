int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int ragCapacity = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>(clothes);
int ragsUsed = 0;
int currentSum = 0;
if (ragCapacity > 0)
{
    ragsUsed++;
}

while (stack.Count > 0)
{
    currentSum += stack.Peek();
    if (currentSum == ragCapacity)
    {
        ragsUsed++;
        currentSum = 0;
        stack.Pop();
        continue;
    }
    else if (currentSum > ragCapacity && ragCapacity > 0)
    {
        ragsUsed++;
        currentSum = 0;
        continue;
    }
    else if (ragCapacity == 0)
    {
        ragsUsed++;
        currentSum = 0;
        stack.Pop();
        continue;
    }
    stack.Pop();
}
Console.WriteLine(ragsUsed);