var integers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int> printMin = numbers =>
{
    var minValue = integers.Min();
    return minValue;
};

Console.WriteLine(printMin(integers));