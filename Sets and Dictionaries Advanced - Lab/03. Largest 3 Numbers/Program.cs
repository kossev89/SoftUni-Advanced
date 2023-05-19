var input = Console.ReadLine()
    .Split()
    .Select(int.Parse);

var sorted = input.OrderByDescending(x => x).ToArray();

if (sorted.Length > 3)
{
    Console.WriteLine(string.Join(' ', sorted.Take(3)));
}
else
{
    Console.WriteLine(string.Join(' ', sorted));
}
