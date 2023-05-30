int range = int.Parse(Console.ReadLine());
int[] divisors = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] numbers = new int[range];
for (int i = 0; i < range; i++)
{
    numbers[i] = i + 1;
}

Func<int[], int[], List<int>> divisible = (divisors, numbers) =>
{
    List<int> result = new List<int>();
    bool isDivisible = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < divisors.Length; j++)
        {
            if (numbers[i] % divisors[j] == 0)
            {
                isDivisible = true;
            }
            else
            {
                isDivisible = false;
                break;
            }
        }
        if (isDivisible)
        {
            result.Add(numbers[i]);
        }
    }
    return result;
};

Console.WriteLine(string.Join(' ', divisible(divisors,numbers)));

