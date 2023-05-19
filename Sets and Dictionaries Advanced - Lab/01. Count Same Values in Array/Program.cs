var input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse);

var numbers = new Dictionary<double, int>();

foreach (var item in input)
{
    if (!numbers.ContainsKey(item))
    {
        numbers.Add(item, 1);
    }
    else
    {
        numbers[item]++;
    }
}

foreach (var item in numbers)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}