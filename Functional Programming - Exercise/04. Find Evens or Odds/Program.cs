using System.Text;

var range = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> numbers = new();

Predicate<int> isEven = number =>
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
};

for (int i = range[0]; i <= range.Last(); i++)
{
    numbers.Add(i);
}

string command = Console.ReadLine();

foreach (var item in numbers)
{
    switch (command)
    {
        case "even":
            if (isEven(item))
            {
                Console.Write($"{item} ");
            }
            break;
        case "odd":
            if (isEven(item) == false)
            {
                Console.Write($"{item} ");
            }
            break;
        default:
            break;
    }
}