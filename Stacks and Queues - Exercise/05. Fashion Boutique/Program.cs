int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int ragCapacity = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>(clothes);
int ragsUsed = 0;
int currentSum = 0;


while (stack.Count > 0)
{
    var currentCloth = stack.Pop();
    currentSum += currentCloth;

    if (currentSum == ragCapacity)
    {
        currentSum = 0;
        ragsUsed++;
        continue;
    }
    else if (currentSum > ragCapacity)
    {
        currentSum = 0;
        ragsUsed++;
        stack.Push(currentCloth);
        continue;
    }
    else if (stack.Count == 0)
    {
        ragsUsed++;
    }
}
if (stack.Count == 0 && ragsUsed == 0)
{
    ragsUsed++;
}
Console.WriteLine(ragsUsed);