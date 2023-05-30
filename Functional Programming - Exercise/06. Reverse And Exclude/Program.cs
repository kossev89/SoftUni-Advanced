List<int> inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int divisor = int.Parse(Console.ReadLine());

Func<List<int>, int, List<int>> reverseAndExclude = (numbers, divisor) =>
{
    inputNumbers.RemoveAll(x => x % divisor == 0);
    inputNumbers.Reverse();
    return inputNumbers;
};

List<int> result = reverseAndExclude(inputNumbers, divisor);
Console.WriteLine(String.Join(' ', result));