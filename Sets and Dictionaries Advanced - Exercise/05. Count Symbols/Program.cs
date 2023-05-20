var chars = new SortedDictionary<char, int>();

var input = Console.ReadLine().ToCharArray();

foreach (var item in input)
{
    if (chars.ContainsKey(item))
    {
        chars[item]++;
    }
    else
    {
        chars.Add(item, 1);
    }
}

foreach (var item in chars)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}